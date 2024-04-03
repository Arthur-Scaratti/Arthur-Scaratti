
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class R_MAILTEXT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int R_MAILTEXT_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISHTML { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MAILHEADER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string MAILTEXT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MAILTEXT2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MAILTEXT3 { get; set; }

    }
}
