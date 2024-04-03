
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_ACCTSCHEMA_GL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_ACCTSCHEMA_ID { get; set; }
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
        public string USESUSPENSEBALANCING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SUSPENSEBALANCING_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string USESUSPENSEERROR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SUSPENSEERROR_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string USECURRENCYBALANCING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CURRENCYBALANCING_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int RETAINEDEARNING_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INCOMESUMMARY_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INTERCOMPANYDUETO_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INTERCOMPANYDUEFROM_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PPVOFFSET_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COMMITMENTOFFSET_ACCT { get; set; }

    }
}
