
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_PRICELIST_VERSION
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRICELIST_VERSION_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRICELIST_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_DISCOUNTSCHEMA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALIDFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCCREATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRICELIST_VERSION_BASE_ID { get; set; }

    }
}
