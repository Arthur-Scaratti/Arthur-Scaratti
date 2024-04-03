
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_BAIXA_CRED_BANC
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_BAIXA_CRED_BANC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
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
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CREDITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CREDITO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_DEP_CRED_BANC_ID { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CREDITO_BANCARIO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_LOTE_CRED_BANC_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AI_BAIXA_CRED_BANC { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"DECLARE\n\n  VN_LOTE_ID NUMBER;\n\nbegin\n\n  SELECT D.DIE_FIN_LOTE_CRED_BANC_ID\n    INTO VN_LOTE_ID\n    FROM DIE_FIN_DEP_CRED_BANC D\n   WHERE D.DIE_FIN_DEP_CRED_BANC_ID = :NEW.DIE_FIN_DEP_CRED_BANC_ID;\n\n  IF :NEW.ISACTIVE = 'Y' AND :OLD.ISACTIVE = 'N' THEN\n  \n    UPDATE DIE_FIN_LOTE_CRED_BANC L\n       SET L.VLR_MOVIMENTO = L.VLR_MOVIMENTO + :NEW.VLR_CREDITO\n     WHERE L.DIE_FIN_LOTE_CRED_BANC_ID = VN_LOTE_ID;\n  END IF;\n\n  IF :NEW.ISACTIVE = 'N' AND :OLD.ISACTIVE = 'Y' THEN\n    UPDATE DIE_FIN_LOTE_CRED_BANC L\n       SET L.VLR_MOVIMENTO = L.VLR_MOVIMENTO - :NEW.VLR_CREDITO\n     WHERE L.DIE_FIN_LOTE_CRED_BANC_ID = VN_LOTE_ID;\n  \n  END IF;\n\nend DIE_TRG_AI_DEP_CRED_BANC;\n"}`;
    
    }
}
