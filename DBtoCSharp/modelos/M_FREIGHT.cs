
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_FREIGHT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_FREIGHT_ID { get; set; }
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
        public int M_SHIPPER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_FREIGHTCATEGORY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALIDFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_COUNTRY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TO_COUNTRY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_REGION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TO_REGION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FREIGHTAMT { get; set; }

    }
}
