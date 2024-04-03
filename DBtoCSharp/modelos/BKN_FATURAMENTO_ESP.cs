
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BKN_FATURAMENTO_ESP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_SEGUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOTAL_NFS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOTAL_PROD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_PIS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CST_ICMS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CST_COFINS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CST_IPI { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CST_PIS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_VALOR_INF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BKN_FAT_ESP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IND_FINALIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ICMS_ST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PREC_ICMS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_NF { get; set; }
        
        /// <summary>
        /// desinado as notas de credito ciap
        /// </summary>
        public int VLR_INFORMADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BKN_FATURAMENTO_ESP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALOR_INF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_CFOP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_PRODUTO { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string HIST_PADRAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_IRRF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ISENTA_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ISENTA_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_OUTRAS_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_OUTRAS_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESP_FINANCEIRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_OUTRAS_DESPESAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_SEGURO { get; set; }

        [NotMapped]
        public string Trigger_BKN_TRG_BIU_BKN_FATURAMENTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"DECLARE\n  --\n  CURSOR C1 IS\n    SELECT P.BEG_CFOP_ID\n         , P.DESC_CFOP\n         , P.PERC_ICMS\n         , P.PERC_PIS\n         , P.PERC_COFINS\n         , P.CST_ICMS\n         , P.CST_PIS\n         , P.CST_COFINS\n         , P.BEG_PRODUTO_ID\n         , P.DESC_PRODUTO\n         , P.HIST_PADR\n         , P.IND_VALOR\n         , P.TP_NF\n         , NVL(P.VALOR_INF,'N')\n         , P.PERC_ICMS_ST\n         , P.FINALIDADE\n      FROM BKN_FAT_ESP P\n     WHERE P.BKN_FAT_ESP_ID = :NEW.BKN_FAT_ESP_ID;\n  --\n  R_C1 C1%ROWTYPE;\n  --\nBEGIN\n  --\n  IF NOT DELETING THEN\n   :NEW.VL_TOTAL_NFS  := NVL(:NEW.VL_ICMS_SUBST,0);\n  END IF;  \n  --:NEW.VL_TOTAL_PROD := NVL(:NEW.VL_ICMS_SUBST,0);\n  --\n  IF DELETING AND :OLD.DOCSTATUS = 'CO' THEN\n    \n     raise_application_error(-20001,'Nao e permitido excluir nota ja faturada');\n  \n  END IF;\n  \n  \n  \n  IF INSERTING THEN\n    :NEW.DOCSTATUS := 'IP'; \n    OPEN C1;\n    FETCH C1 INTO :NEW.BEG_CFOP_ID\n                , :NEW.DESC_CFOP\n                , :NEW.ALQ_ICMS\n                , :NEW.ALQ_IPI\n                , :NEW.ALQ_COFINS\n                , :NEW.CST_ICMS\n                , :NEW.CST_PIS\n                , :NEW.CST_COFINS\n                , :NEW.BEG_PRODUTO_ID\n                , :NEW.DESC_PRODUTO\n                , :NEW.HIST_PADRAO\n                , :NEW.IND_VALOR\n                , :NEW.TP_NF\n                , :NEW.IND_VALOR_INF\n                , :NEW.PERC_ICMS_ST\n                , :NEW.IND_FINALIDADE;\n    CLOSE C1;\n  END IF;\n\n  IF UPDATING AND :NEW.BKN_FAT_ESP_ID <> :OLD.BKN_FAT_ESP_ID THEN\n    \n  raise_application_error(-20001,'Nao e permitido alterar o codigo de faturamento');\n  \n  END IF;\n\n\nEND;\n"}`;
    
    }
}
