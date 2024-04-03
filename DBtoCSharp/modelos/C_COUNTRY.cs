
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_COUNTRY
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string MEDIASIZE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_COUNTRY_ID { get; set; }
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
        /// ISO 3166 2Character code
        /// </summary>
        public string COUNTRYCODE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string HASREGION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REGIONNAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EXPRESSIONPHONE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DISPLAYSEQUENCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EXPRESSIONPOSTAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string HASPOSTAL_ADD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EXPRESSIONPOSTAL_ADD { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string AD_LANGUAGE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DISPLAYSEQUENCELOCAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISADDRESSLINESREVERSE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISADDRESSLINESLOCALREVERSE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EXPRESSIONBANKROUTINGNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EXPRESSIONBANKACCOUNTNO { get; set; }

    }
}
