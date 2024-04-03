
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_DISCOUNTSCHEMALINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_DISCOUNTSCHEMALINE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_CATEGORY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CONVERSIONDATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string LIST_BASE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LIST_ADDAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LIST_DISCOUNT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string LIST_ROUNDING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LIST_MINAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LIST_MAXAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIST_FIXED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string STD_BASE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int STD_ADDAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int STD_DISCOUNT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string STD_ROUNDING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int STD_MINAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int STD_MAXAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int STD_FIXED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string LIMIT_BASE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LIMIT_ADDAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LIMIT_DISCOUNT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string LIMIT_ROUNDING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LIMIT_MINAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LIMIT_MAXAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIMIT_FIXED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CONVERSIONTYPE_ID { get; set; }

    }
}
