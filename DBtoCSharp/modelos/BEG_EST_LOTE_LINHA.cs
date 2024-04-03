
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_EST_LOTE_LINHA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_LOTE_LINHA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_LOTE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QUANTIDADE { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QUANTIDADE_INVENTARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QUANTIDADE_FISICA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string POSICAO_FISICA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_DISPONIVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ESTOQUE_ATUAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_RESERVA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00034 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_BEG_EST_LOT_LINHA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  cursor C_LOTE is\n    select B.INVENTARIO, B.ESPECIE_LINHA, DOCSTATUS\n      from BEG_EST_TP_LOTE A, BEG_EST_LOTE B\n     where B.BEG_EST_LOTE_ID =\n           NVL(:new.BEG_EST_LOTE_ID, :old.BEG_EST_LOTE_ID)\n       and B.BEG_EST_TP_LOTE_ID = A.BEG_EST_TP_LOTE_ID;\n\n  cursor C_SKU_PADRAO is\n    select BEG_PRD_SKU_ID\n      from BEG_PRD_SKU B\n     where B.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n       and PADRAO = 'Y';\n  V_ESPECIE_LINHA char(1);\n  V_INVENTARIO    char(1);\n  V_DOCSTATUS     char(2);\n  --\n  cursor C_SKU is\n    select BEG_PRD_SKU_ID\n      from BEG_PRD_SKU B\n     where B.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n       and B.BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID;\n  --\n  V_SKU C_SKU%rowtype;\n  --\n  cursor C_PRODUTO is\n    select *\n      from BEG_PRODUTO P\n     where P.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n  --\n  V_PRODUTO C_PRODUTO%rowtype;\n  --\n  CURSOR C_PROD IS\n    SELECT p.beg_produto_id, sk.beg_prd_situacao_id, p.die_cod_estruturado\n      FROM BEG_PRODUTO P, BEG_PRD_SKU_DETALHE SK\n     WHERE SK.BEG_PRODUTO_ID = P.BEG_PRODUTO_ID\n       AND P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n  R_PROD C_PROD%ROWTYPE;\n\n  --\nbegin\n  open C_LOTE;\n  fetch C_LOTE\n    into V_INVENTARIO, V_ESPECIE_LINHA, V_DOCSTATUS;\n  close C_LOTE;\n\n  if V_DOCSTATUS = 'CO' then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Lote completo n?o pode sofrer alteracoes ou ser deletado !!!');\n  end if;\n\n  if INSERTING or UPDATING then\n    :new.beg_est_tp_especie_id := 2000019;\n  end if;\n\n  /*\n       if :new.quantidade > :new.qtd_disponivel  then\n         Raise_Application_Error(-20001,\n                                'Quantidade informada maior que estoque disponível. Verifique');\n      \n      end if;*\\\n  */\n  open C_PROD;\n  fetch C_PROD\n    into R_PROD;\n  close C_PROD;\n\n  if r_prod.beg_prd_situacao_id = 2000004 then\n    Raise_Application_Error(-20001,\n                            'Produto ' || R_PROD.die_cod_estruturado ||\n                            ' está Liquidado não permite movimento');\n  end if;\n\n  if :new.BEG_PRD_SKU_ID is null then\n    open C_SKU_PADRAO;\n    fetch C_SKU_PADRAO\n      into :new.BEG_PRD_SKU_ID;\n    close C_SKU_PADRAO;\n  else\n    open C_SKU;\n    fetch C_SKU\n      into V_SKU;\n    if C_SKU%notfound then\n      open C_PRODUTO;\n      fetch C_PRODUTO\n        into V_PRODUTO;\n      close C_PRODUTO;\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Sku nao pertence ao produto ' ||\n                              V_PRODUTO.value || ' - ' || V_PRODUTO.name);\n    end if;\n    close C_SKU;\n  end if;\n\n  if V_ESPECIE_LINHA = 'Y' and :new.BEG_EST_TP_ESPECIE_ID is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Especie do movimento deve ser informada !!!');\n  end if;\n\n  if INSERTING or UPDATING then\n    if NVL(:new.QUANTIDADE, 0) = 0 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'N?o existe movimentacao sem quantidade !!!');\n    end if;\n  end if;\nend;\n  \n"}`;
    
    }
}
