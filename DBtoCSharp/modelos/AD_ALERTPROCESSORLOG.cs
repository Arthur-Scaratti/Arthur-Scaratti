
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_ALERTPROCESSORLOG
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ALERTPROCESSOR_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ALERTPROCESSORLOG_ID { get; set; }
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
        public string ISERROR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUMMARY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TEXTMSG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] BINARYDATA { get; set; }

    }
}
