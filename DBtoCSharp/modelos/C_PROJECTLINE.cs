
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_PROJECTLINE
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PLANNEDQTY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PLANNEDPRICE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PLANNEDAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PLANNEDMARGINAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMMITTEDAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_CATEGORY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INVOICEDAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INVOICEDQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMMITTEDQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECTISSUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDERPO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPRINTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOPRICING { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECTLINE_ID { get; set; }
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
        public int C_PROJECT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LINE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }

    }
}
