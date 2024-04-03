
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_ELEMENTVALUE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_ELEMENTVALUE_ID { get; set; }
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
        public string VALUE { get; set; }
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
        public string ACCOUNTTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCOUNTSIGN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISDOCCONTROLLED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_ELEMENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSUMMARY { get; set; }
        
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
        public string POSTACTUAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string POSTBUDGET { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string POSTENCUMBRANCE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string POSTSTATISTICAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISBANKACCOUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BANKACCOUNT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISFOREIGNCURRENCY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }

    }
}
