
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_EST_INV_ESTOQUE
    {
        
        /// <summary>
        /// Preco de Custo daTabela do produto
        /// </summary>
        public int PRECO_CUSTO { get; set; }
        
        /// <summary>
        /// Diferenca entre  QTD  e  QTD_CONFERIDA
        /// </summary>
        public int QTD_DIVERG { get; set; }
        
        /// <summary>
        /// Preco de Venda da Tabela do produto
        /// </summary>
        public int PRECO_VENDA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_INV_ESTOQUE_ID { get; set; }
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
            [Required]
        /// <summary>
        /// Qtde Estoque
        /// </summary>
        public int QTD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_INVENTARIO_ID { get; set; }
        
        /// <summary>
        /// Qtde Contagem
        /// </summary>
        public int QTD_CONFERIDA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00009 { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"DECLARE\n  CURSOR C1 IS\n    SELECT P.DIE_COD_ESTRUTURADO\n      FROM BEG_PRODUTO P\n     WHERE P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n  R1 C1%ROWTYPE;\n\n  CURSOR C2 IS\n    SELECT I.*\n      FROM BEG_EST_INVENTARIO I\n     WHERE I.BEG_EST_INVENTARIO_ID = :OLD.BEG_EST_INVENTARIO_ID;\n  R2 C2%ROWTYPE;\n\nBEGIN\n\n  IF INSERTING OR UPDATING THEN\n    IF NOT BEG_FNC_VALIDA_SKU(:NEW.BEG_PRODUTO_ID, :NEW.BEG_PRD_SKU_ID) THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n    END IF;\n  \n    IF INSERTING THEN\n    \n      OPEN C1;\n      FETCH C1\n        INTO R1;\n      CLOSE C1;\n    \n      :NEW.PRECO_CUSTO := DIE_FNC_CST_VALOR(1000016, R1.DIE_COD_ESTRUTURADO);\n      :NEW.PRECO_VENDA := BEG_FNC_PRD_PRECO(0,\n                                            :NEW.BEG_PRODUTO_ID,\n                                            :NEW.BEG_PRD_SKU_ID,\n                                            NULL,\n                                            'C');\n    \n    END IF;\n  \n    :NEW.QTD_DIVERG := :NEW.QTD - :NEW.QTD_CONFERIDA;\n  \n    IF :NEW.QTD - :NEW.QTD_CONFERIDA = 0 THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'QTDE DIVERGENTE IGUAL A ZERO. VERIFIQUE  ! ! ! ');\n    \n    END IF;\n  \n  END IF;\n\n  IF DELETING THEN\n  \n    OPEN C2;\n    FETCH C2\n      INTO R2;\n    CLOSE C2;\n  \n    IF R2.DOCSTATUS = 'CO' THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Balanço já processado não permite excluir itens. Verifique  ! ! ! ');\n    \n    END IF;\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
