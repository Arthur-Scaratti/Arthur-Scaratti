
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_CONVERSION_RATE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_CONVERSION_RATE_ID { get; set; }
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
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID_TO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALIDFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALIDTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MULTIPLYRATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIVIDERATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CONVERSIONTYPE_ID { get; set; }

    }
}
