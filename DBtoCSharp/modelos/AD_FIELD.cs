
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_FIELD
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int SORTNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSAMELINE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISHEADING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISFIELDONLY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISENCRYPTED { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OBSCURETYPE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_FIELD_ID { get; set; }
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
        public string ISCENTRALLYMAINTAINED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_TAB_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_FIELDGROUP_ID { get; set; }
            [Required]
        /// <summary>
        /// N = is displayed 
        /// </summary>
        public string ISDISPLAYED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DISPLAYLOGIC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DISPLAYLENGTH { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISREADONLY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }

    }
}
