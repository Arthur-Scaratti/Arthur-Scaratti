
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_ATTACHMENT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ATTACHMENT_ID { get; set; }
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
        public int AD_TABLE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int RECORD_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TITLE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] BINARYDATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TEXTMSG { get; set; }

    }
}
