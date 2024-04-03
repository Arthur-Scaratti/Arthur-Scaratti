
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_REQUISITIONLINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_REQUISITIONLINE_ID { get; set; }
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
        public int LINE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_REQUISITION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRICEACTUAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LINENETAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDERLINE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTESETINSTANCE_ID { get; set; }

    }
}
