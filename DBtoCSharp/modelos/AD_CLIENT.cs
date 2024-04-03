
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_CLIENT
    {
            [Required]
    [Key]
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SMTPHOST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REQUESTEMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REQUESTUSER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REQUESTUSERPW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REQUESTFOLDER { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string AD_LANGUAGE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMULTILINGUALDOCUMENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSMTPAUTHORIZATION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISUSEBETAFUNCTIONS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LDAPQUERY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MODELVALIDATIONCLASSES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string AUTOARCHIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string MMPOLICY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EMAILTEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSERVEREMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTDIR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPOSTIMMEDIATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCOSTIMMEDIATE { get; set; }

    }
}
