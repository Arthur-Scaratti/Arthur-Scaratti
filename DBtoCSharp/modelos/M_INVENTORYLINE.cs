
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_INVENTORYLINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_INVENTORYLINE_ID { get; set; }
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
        public int M_INVENTORY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_LOCATOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LINE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTYBOOK { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTYCOUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTESETINSTANCE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CHARGE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string INVENTORYTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTYINTERNALUSE { get; set; }

    }
}
