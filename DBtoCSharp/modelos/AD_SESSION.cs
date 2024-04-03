
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_SESSION
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string WEBSESSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REMOTE_ADDR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REMOTE_HOST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }

        [NotMapped]
        public string Trigger_TRG_AIU_AD_SESSION { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if :new.processed = 'Y' then\n    BEG_PCK_AD_Dictionary.vn_ad_session_id := 0;\n    BEG_PCK_AD_Dictionary.vn_ad_client_id  := 1000000;\n    BEG_PCK_AD_Dictionary.vn_ad_org_id     := 0;\n    BEG_PCK_AD_Dictionary.vn_ad_user_id    := 0;\n  else\n    BEG_PCK_AD_Dictionary.vn_ad_session_id := :new.ad_session_id;\n    BEG_PCK_AD_Dictionary.vn_ad_client_id  := :new.ad_client_id;\n    BEG_PCK_AD_Dictionary.vn_ad_org_id     := :new.ad_org_id;\n    BEG_PCK_AD_Dictionary.vn_ad_user_id    := :new.createdby;\n  end if;\n\nend TRG_AIU_AD_SESSION;\n"}`;
    
    }
}
