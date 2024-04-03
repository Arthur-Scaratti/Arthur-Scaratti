
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_CASHBOOK_ACCT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_CASHBOOK_ID { get; set; }
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

    }
}
