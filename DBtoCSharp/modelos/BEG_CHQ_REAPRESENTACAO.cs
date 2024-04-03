
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CHQ_REAPRESENTACAO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_REAPRESENTACAO_ID { get; set; }
        
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
        public int BEG_CHQ_CHEQUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_ALIQUOTA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CAIXA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_REAPRESENTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_HISTORICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_BANCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CHEQUE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_INTEGRA_CAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_CAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_CAIXA_HISTORICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_CAIXA_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_CHQ_REAPRESENTACAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  CURSOR C1 IS\n    SELECT C.VALOR\n         , C.AD_ORG_ID\n      FROM BEG_CHQ_CHEQUE C\n     WHERE C.BEG_CHQ_CHEQUE_ID = :NEW.BEG_CHQ_CHEQUE_ID;\n  --\nBEGIN\n  --\n  OPEN C1;\n  FETCH C1 INTO :NEW.VLR_CHEQUE\n              , :NEW.BEG_FILIAL_ID;\n  CLOSE C1;\n  --\n  IF INSERTING THEN\n    IF :NEW.IND_CAIXA = 'Y' AND\n      :NEW.IND_REAPRESENTA = 'Y' THEN\n      RAISE_APPLICATION_ERROR(-20001,'Não pode inserir os dois indicativos marcados!');\n    END IF;\n  END IF;\n  --\n  IF :NEW.IND_CAIXA = 'Y' AND\n     :new.ind_reapresenta = 'Y' and\n    :NEW.BEG_VW_FIN_CAIXA_ID IS NULL AND\n    :NEW.BEG_VW_FIN_CAIXA_HISTORICO_ID IS NULL AND\n    :NEW.BEG_VW_FIN_CAIXA_CONTA_ID IS NULL AND\n    :NEW.BEG_VW_FIN_BCO_CONTA_ID IS NULL THEN\n    --\n    RAISE_APPLICATION_ERROR(-20001,'Faltou informações de Saida de Caixa!');\n  END IF;\n\n  --\nEND;\n"}`;
    
    }
}
