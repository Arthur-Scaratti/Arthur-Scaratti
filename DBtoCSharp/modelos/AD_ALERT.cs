
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_ALERT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ALERT_ID { get; set; }
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
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ALERTSUBJECT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ALERTMESSAGE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ENFORCECLIENTSECURITY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ENFORCEROLESECURITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ALERTPROCESSOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVALID { get; set; }

    }
}
