
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class S_RESOURCEASSIGNMENT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int S_RESOURCEASSIGNMENT_ID { get; set; }
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
        public int S_RESOURCE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ASSIGNDATEFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ASSIGNDATETO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCONFIRMED { get; set; }

    }
}
