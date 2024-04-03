
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_ORDERLINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDERLINE_ID { get; set; }
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
        public int C_ORDER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LINE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_LOCATION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATEORDERED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEPROMISED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEDELIVERED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_WAREHOUSE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTYORDERED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTYRESERVED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTYDELIVERED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTYINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_SHIPPER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRICELIST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRICEACTUAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRICELIMIT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LINENETAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FREIGHTAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CHARGE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_TAX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int S_RESOURCEASSIGNMENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REF_ORDERLINE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTESETINSTANCE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTYENTERED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRICEENTERED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRICECOST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTYLOSTSALES { get; set; }

    }
}
