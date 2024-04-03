
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_EST_ACERTO_ESTOQUE_ITEM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_EST_ACERTO_ESTOQUE_ITEM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// ITEM ENTRADA
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// QTDE ENTRADA
        /// </summary>
        public int QTDE { get; set; }
            [Required]
        /// <summary>
        /// ITEM SAIDA
        /// </summary>
        public int BEG_VW_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// QTDE SAIDA
        /// </summary>
        public int QTDE1 { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_EST_ACERTO_ESTOQUE_ID { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_ACERTO_EST_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  V_ALMOX_ID NUMBER(10);\n\n  CURSOR C1 IS\n    SELECT P.*\n      FROM BEG_PRODUTO P\n     WHERE P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n\n  R1 C1%ROWTYPE;\n\n  CURSOR C2 IS\n    SELECT P.*\n      FROM BEG_PRODUTO P\n     WHERE P.BEG_PRODUTO_ID = :NEW.BEG_VW_PRODUTO_ID;\n\n  R2 C2%ROWTYPE;\n\n  CURSOR C3 IS\n    SELECT P.QTD\n      FROM BEG_ESTOQUE P\n     WHERE P.BEG_PRODUTO_ID = :NEW.BEG_VW_PRODUTO_ID\n       AND P.BEG_EST_ALMOXARIFADO_ID = V_ALMOX_ID;\n\n  R3 C3%ROWTYPE;\n\n  CURSOR C_ALMOX IS\n    SELECT A.BEG_EST_ALMOXARIFADO_ID\n      FROM DIE_EST_ACERTO_ESTOQUE A\n     WHERE A.DIE_EST_ACERTO_ESTOQUE_ID = :NEW.DIE_EST_ACERTO_ESTOQUE_ID;\n  R_ALMOX C_ALMOX%ROWTYPE;\n\nbegin\n\n  OPEN C_ALMOX;\n  FETCH C_ALMOX\n    INTO R_ALMOX;\n  CLOSE C_ALMOX;\n\n  V_ALMOX_ID := R_ALMOX.BEG_EST_ALMOXARIFADO_ID;\n\n  OPEN C1;\n  FETCH C1\n    INTO R1;\n  CLOSE C1;\n\n  OPEN C2;\n  FETCH C2\n    INTO R2;\n  CLOSE C2;\n\n  IF INSERTING OR (UPDATING AND :NEW.DOCSTATUS = :OLD.DOCSTATUS) THEN\n\n    IF :new.qtde = 0 THEN\n\n      raise_application_error(-20001,\n                              'Faltou informar a quantidade do item ' ||\n                              R1.DIE_COD_ESTRUTURADO);\n\n    END IF;\n\n    IF :new.qtde1 = 0 THEN\n\n      raise_application_error(-20001,\n                              'Faltou informar a quantidade do item ' ||\n                              R2.DIE_COD_ESTRUTURADO);\n\n    END IF;\n\n    IF :new.qtde1 <> :new.qtde THEN\n\n      raise_application_error(-20001,\n                              'Quantidades diferentes. Somente pode ajustar a mesma quantidade de itens');\n\n    END IF;\n\n    IF R1.CONTROLA_COR = 'N' THEN\n\n      raise_application_error(-20001,\n                              'Produto ' || R1.DIE_COD_ESTRUTURADO ||\n                              ' sem controle de cor. Não permitido acerto.');\n    END IF;\n\n    IF R2.CONTROLA_COR = 'N' THEN\n\n      raise_application_error(-20001,\n                              'Produto ' || R2.DIE_COD_ESTRUTURADO ||\n                              ' sem controle de cor. Não permitido acerto.');\n    END IF;\n\n    IF :NEW.BEG_PRODUTO_ID = :NEW.BEG_VW_PRODUTO_ID THEN\n\n      raise_application_error(-20001,\n                              'Códigos de produtos iguais. Verifique!');\n\n    END if;\n\n    IF NVL(R1.DIE_VW_PRD_PAI_ID, :NEW.BEG_PRODUTO_ID) <>\n       NVL(R2.DIE_VW_PRD_PAI_ID, :NEW.BEG_VW_PRODUTO_ID) THEN\n\n      raise_application_error(-20001,\n                              'Códigos diferentes. Somente permitido acerto entre codigos iguais e cores diferentes.');\n\n    END if;\n\n    OPEN C3;\n    FETCH C3\n      INTO R3;\n    CLOSE C3;\n\n    IF NVL(R3.QTD,0) < :NEW.QTDE1 THEN\n\n      raise_application_error(-20001,\n                              'Quantidade de saída do item ' ||\n                              R2.DIE_COD_ESTRUTURADO ||\n                              ' menor que saldo em estoque.');\n\n    END IF;\n\n  END IF;\nend;\n"}`;
    
    }
}
