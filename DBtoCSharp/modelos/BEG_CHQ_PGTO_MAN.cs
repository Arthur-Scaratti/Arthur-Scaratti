
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CHQ_PGTO_MAN
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_PGTO_MAN_ID { get; set; }
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
        public int BEG_CHQ_CHEQUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_CHEQUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_PGTO_MANUAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BI_CHQ_PGTO_MAN { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\n  CURSOR BUSCA_CHEQUE IS \n    SELECT *\n    FROM   BEG_CHQ_CHEQUE \n    WHERE  BEG_CHQ_CHEQUE_ID = :NEW.BEG_CHQ_CHEQUE_ID;\n  --\n  V_CHEQUE   BUSCA_CHEQUE%ROWTYPE;\n  --\nbegin\n  --\n  OPEN BUSCA_CHEQUE;\n  FETCH BUSCA_CHEQUE INTO V_CHEQUE;\n  CLOSE BUSCA_CHEQUE;\n  :NEW.VALOR := V_CHEQUE.VALOR;\n  :NEW.NRO_CHEQUE := V_CHEQUE.VALUE;\n  --:NEW.BEG_BANCO_ID := V_CHEQUE.BEG_BANCO_ID;\nend BEG_TRG_BI_CHQ_PGTO_MAN;\n"}`;
    
    }
}
