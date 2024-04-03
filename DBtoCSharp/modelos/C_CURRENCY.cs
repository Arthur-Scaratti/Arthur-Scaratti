
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_CURRENCY
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
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
        public string ISO_CODE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CURSYMBOL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int STDPRECISION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COSTINGPRECISION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISEURO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISEMUMEMBER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EMUENTRYDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EMURATE { get; set; }

    }
}
