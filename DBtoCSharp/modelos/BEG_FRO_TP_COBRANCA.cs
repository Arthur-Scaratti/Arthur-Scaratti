
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_TP_COBRANCA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_TP_COBRANCA_ID { get; set; }
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
    [StringLength(35)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_TP_COBRANCA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GERA_COBRANCA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_TP_COBRANCA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  :new.DESC_TP_COBRANCA := UPPER(:new.DESC_TP_COBRANCA);\n  --  \nend BEG_FRO_TRG_BIU_TP_COBRANCA;\n"}`;
    
    }
}
