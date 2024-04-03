
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_BP_BANKACCOUNT
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string A_STREET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_CITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_STATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_ZIP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_IDENT_DL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_EMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_IDENT_SSN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string R_AVSADDR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string R_AVSZIP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_COUNTRY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_BP_BANKACCOUNT_ID { get; set; }
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
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BANK_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISACH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BANKACCOUNTTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ROUTINGNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ACCOUNTNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREDITCARDTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREDITCARDNUMBER { get; set; }
            [StringLength(4)]
        /// <summary>
        /// Verification Value
        /// </summary>
        public string CREDITCARDVV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREDITCARDEXPMM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREDITCARDEXPYY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_NAME { get; set; }

    }
}
