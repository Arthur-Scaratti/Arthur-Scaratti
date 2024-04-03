
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_BP_GROUP_ACCT
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int V_LIABILITY_SERVICES_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int V_PREPAYMENT_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PAYDISCOUNT_EXP_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PAYDISCOUNT_REV_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int WRITEOFF_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NOTINVOICEDRECEIPTS_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UNEARNEDREVENUE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NOTINVOICEDREVENUE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NOTINVOICEDRECEIVABLES_ACCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_RECEIVABLE_SERVICES_ACCT { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_ACCTSCHEMA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_BP_GROUP_ID { get; set; }
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
        public int C_RECEIVABLE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_PREPAYMENT_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int V_LIABILITY_ACCT { get; set; }

    }
}
