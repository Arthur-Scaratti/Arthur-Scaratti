
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_TAX
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// Tax Indicator to print on Invoices, etc.
        /// </summary>
        public string TAXINDICATOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDOCUMENTLEVEL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALIDFROM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSUMMARY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string REQUIRESTAXCERTIFICATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int RATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARENT_TAX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_COUNTRY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_REGION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TO_COUNTRY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TO_REGION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_TAXCATEGORY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTAXEXEMPT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SOPOTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSALESTAX { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_TAX_ID { get; set; }
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

    }
}
