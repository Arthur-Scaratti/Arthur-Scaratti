
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_BPARTNER_PRODUCT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SHELFLIFEMINPCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SHELFLIFEMINDAYS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QUALITYRATING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VENDORPRODUCTNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VENDORCATEGORY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MANUFACTURER { get; set; }

    }
}
