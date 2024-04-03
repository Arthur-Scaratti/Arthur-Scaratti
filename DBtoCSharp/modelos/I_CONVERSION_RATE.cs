
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class I_CONVERSION_RATE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int I_CONVERSION_RATE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CONVERSION_RATE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISO_CODE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISO_CODE_TO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID_TO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CONVERSIONTYPEVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CONVERSIONTYPE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALIDFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALIDTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MULTIPLYRATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIVIDERATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATERECIPROCALRATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string I_ISIMPORTED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string I_ERRORMSG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }

    }
}
