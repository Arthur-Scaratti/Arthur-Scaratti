
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_BANKACCOUNT_ACCT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_BANKACCOUNT_ID { get; set; }
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
        public int B_INTRANSIT_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_ASSET_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_EXPENSE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_INTERESTREV_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_INTERESTEXP_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_UNIDENTIFIED_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_UNALLOCATEDCASH_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_PAYMENTSELECT_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_SETTLEMENTGAIN_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_SETTLEMENTLOSS_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_REVALUATIONGAIN_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int B_REVALUATIONLOSS_ACCT { get; set; }

    }
}
