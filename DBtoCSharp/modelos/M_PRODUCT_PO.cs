
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_PRODUCT_PO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
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
        public string ISCURRENTVENDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRICELIST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRICEPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRICEEFFECTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRICELASTPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRICELASTINV { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VENDORPRODUCTNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VENDORCATEGORY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DISCONTINUED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DISCONTINUEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORDER_MIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORDER_PACK { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COSTPERORDER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DELIVERYTIME_PROMISED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DELIVERYTIME_ACTUAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QUALITYRATING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ROYALTYAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MANUFACTURER { get; set; }

    }
}
