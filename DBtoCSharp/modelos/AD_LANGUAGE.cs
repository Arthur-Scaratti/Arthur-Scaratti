
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_LANGUAGE
    {
            [Required]
    [StringLength(6)]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string AD_LANGUAGE { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LANGUAGEISO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COUNTRYCODE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISBASELANGUAGE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSYSTEMLANGUAGE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_LANGUAGE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDECIMALPOINT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEPATTERN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TIMEPATTERN { get; set; }

    }
}
