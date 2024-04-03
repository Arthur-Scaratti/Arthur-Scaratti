
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_BANKSTATEMENTLINE
    {
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
        public int C_BANKSTATEMENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LINE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISREVERSAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Date when amount is available
        /// </summary>
        public string VALUTADATE { get; set; }
            [Required]
        /// <summary>
        /// Posting date (the main date on statements, sometimes valuta date is later)
        /// </summary>
        public string DATEACCT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// Transaction Amount (may be different than bank account currency)
        /// </summary>
        public int TRXAMT { get; set; }
            [Required]
        /// <summary>
        /// Statement Account (in Bank Statement Currency)
        /// </summary>
        public int STMTAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CHARGE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CHARGEAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INTERESTAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MEMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCENO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMANUAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTTRXID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTTRXTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTMEMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTPAYEE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTPAYEEACCOUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATEPAYMENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string STATEMENTLINEDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTSTATEMENTLINEDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTVALUTADATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTREFERENCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTCURRENCY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EFTAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string EFTCHECKNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string MATCHSTATEMENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_BANKSTATEMENTLINE_ID { get; set; }
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

    }
}
