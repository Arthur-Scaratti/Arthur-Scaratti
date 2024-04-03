
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_PAYMENT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENT_ID { get; set; }
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
        public string DOCUMENTNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATETRX { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISRECEIPT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_DOCTYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// S=Sales
        /// </summary>
        public string TRXTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_BANKACCOUNT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BP_BANKACCOUNT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENTBATCH_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TENDERTYPE { get; set; }
        
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
        public string MICR { get; set; }
        
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
        public string CHECKNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_NAME { get; set; }
        
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
        public string A_IDENT_SSN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_EMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VOICEAUTHCODE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ORIG_TRXID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PONUM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PAYAMT { get; set; }
        
        /// <summary>
        /// Copied into Allocation
        /// </summary>
        public int DISCOUNTAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int WRITEOFFAMT { get; set; }
        
        /// <summary>
        /// Only used for CreditCard Trx
        /// </summary>
        public int TAXAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISAPPROVED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string R_PNREF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string R_RESULT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string R_RESPMSG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string R_AUTHCODE { get; set; }
        
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
        public string R_INFO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OPROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCACTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISRECONCILED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISALLOCATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISONLINE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string POSTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISOVERUNDERPAYMENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OVERUNDERAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string A_COUNTRY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSELFSERVICE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CHARGEAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CHARGE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDELAYEDCAPTURE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string R_AUTHCODE_DC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string R_CVV2MATCH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string R_PNREF_DC { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string SWIPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGTRX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CAMPAIGN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACTIVITY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USER1_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USER2_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CONVERSIONTYPE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATEACCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPREPAYMENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REF_PAYMENT_ID { get; set; }

    }
}
