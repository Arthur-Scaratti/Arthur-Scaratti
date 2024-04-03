
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_RELATEDPRODUCT
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
        public int RELATEDPRODUCT_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string RELATEDPRODUCTTYPE { get; set; }
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
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }

    }
}
