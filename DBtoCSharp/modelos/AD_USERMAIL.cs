
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_USERMAIL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_USERMAIL_ID { get; set; }
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
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_MAILTEXT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int W_MAILMSG_ID { get; set; }
            [StringLength(120)]
        /// <summary>
        /// 
        /// </summary>
        public string MESSAGEID { get; set; }
            [StringLength(120)]
        /// <summary>
        /// 
        /// </summary>
        public string DELIVERYCONFIRMATION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISDELIVERED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUBJECT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MAILTEXT { get; set; }

    }
}
