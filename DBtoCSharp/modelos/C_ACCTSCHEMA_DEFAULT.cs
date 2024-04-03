
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_ACCTSCHEMA_DEFAULT
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
        public int W_INVENTORY_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int W_INVACTUALADJUST_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int W_DIFFERENCES_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int W_REVALUATION_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int P_REVENUE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int P_EXPENSE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int P_ASSET_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int P_PURCHASEPRICEVARIANCE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int P_INVOICEPRICEVARIANCE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int P_TRADEDISCOUNTREC_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int P_TRADEDISCOUNTGRANT_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int P_COGS_ACCT { get; set; }
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
        public int WRITEOFF_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PAYDISCOUNT_REV_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UNREALIZEDGAIN_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UNREALIZEDLOSS_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int REALIZEDGAIN_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int REALIZEDLOSS_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int WITHHOLDING_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int E_PREPAYMENT_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int E_EXPENSE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PJ_ASSET_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PJ_WIP_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int T_EXPENSE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int T_LIABILITY_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int T_RECEIVABLES_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int T_DUE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int T_CREDIT_ACCT { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CH_EXPENSE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CH_REVENUE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UNEARNEDREVENUE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NOTINVOICEDRECEIVABLES_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NOTINVOICEDREVENUE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NOTINVOICEDRECEIPTS_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CB_ASSET_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CB_CASHTRANSFER_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CB_DIFFERENCES_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CB_EXPENSE_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CB_RECEIPT_ACCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_RECEIVABLE_SERVICES_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int P_INVENTORYCLEARING_ACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int P_COSTADJUSTMENT_ACCT { get; set; }

    }
}
