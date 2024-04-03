
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NFE_DESP_RATEIO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_NFE_DESP_RATEIO_ID { get; set; }
        
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
        public int DIE_NFE_DESPESAS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LOJA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_NFE_DESP_RATEIO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n PRAGMA AUTONOMOUS_TRANSACTION;\nBEGIN\n\n\nIF DELETING AND :OLD.DOCSTATUS <>'CO' THEN\n  UPDATE DIE_NFE_DESPESAS A SET\n     A.VLR_ACUMULADO = A.VLR_ACUMULADO - :OLD.VLR_LOJA\n  WHERE A.DIE_NFE_DESPESAS_ID = :OLD.DIE_NFE_DESPESAS_ID;\n\nEND IF;\nIF DELETING AND :OLD.DOCSTATUS ='CO' THEN\n  RAISE_APPLICATION_ERROR(-20001,'Lote ja encerrado não permite exclusão');\n\nEND IF;\n\n/*IF UPDATING AND :OLD.VLR_LOJA <> :NEW.VLR_LOJA  THEN\n  UPDATE DIE_NFE_DESPESAS  A SET\n     A.VLR_ACUMULADO = A.VLR_ACUMULADO + :NEW.VLR_LOJA - :OLD.VLR_LOJA\n  WHERE A.DIE_NFE_DESPESAS_ID = :NEW.DIE_NFE_DESPESAS_ID;*/\n\n--END IF;\n\n\nCOMMIT;\nEND DIE_TRG_BIUD_CAIXA_MOVIMENTO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AIUD_NFE_DESP_RATEIO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  PRAGMA AUTONOMOUS_TRANSACTION;\n\nBEGIN\n\n  IF INSERTING THEN\n\n    UPDATE DIE_NFE_DESPESAS A\n       SET A.VLR_ACUMULADO = A.VLR_ACUMULADO + :NEW.VLR_LOJA\n     WHERE A.DIE_NFE_DESPESAS_ID = :NEW.DIE_NFE_DESPESAS_ID;\n\n    COMMIT;\n\n  END IF;\n\nEND DIE_TRG_AIUD_CAIXA_MOVIMENTO;\n"}`;
    
    }
}
