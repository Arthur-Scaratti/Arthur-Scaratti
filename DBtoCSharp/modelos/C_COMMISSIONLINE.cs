
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_COMMISSIONLINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_COMMISSIONLINE_ID { get; set; }
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
        public int C_COMMISSION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LINE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AMTSUBTRACT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AMTMULTIPLIER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTYSUBTRACT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTYMULTIPLIER { get; set; }
            [Required]
        /// <summary>
        /// Only positive amounts are considered
        /// </summary>
        public string ISPOSITIVEONLY { get; set; }
            [Required]
        /// <summary>
        /// Commission orders only
        /// </summary>
        public string COMMISSIONORDERS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_CATEGORY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BP_GROUP_ID { get; set; }
        
        /// <summary>
        /// Customer
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_SALESREGION_ID { get; set; }

    }
}
