
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_DISCOUNTSCHEMABREAK
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_DISCOUNTSCHEMABREAK_ID { get; set; }
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
        public int M_DISCOUNTSCHEMA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BREAKVALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BREAKDISCOUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_CATEGORY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISBPARTNERFLATDISCOUNT { get; set; }

    }
}
