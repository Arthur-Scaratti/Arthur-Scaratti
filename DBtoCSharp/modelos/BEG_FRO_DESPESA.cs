
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FRO_DESPESA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FRO_DESPESA_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_DESPESA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FRO_DESPESA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  :new.DESC_DESPESA := UPPER(:new.DESC_DESPESA);\nend TRG_BIU_BEG_FRO_DESPESA;\n"}`;
    
    }
}
