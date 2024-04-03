
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_INOUTLINE
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTESETINSTANCE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONFIRMEDQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PICKEDQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SCRAPPEDQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TARGETQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REF_INOUTLINE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CHARGE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_INOUTLINE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_INOUT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDERLINE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_LOCATOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MOVEMENTQTY { get; set; }

    }
}
