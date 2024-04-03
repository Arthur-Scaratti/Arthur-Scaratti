
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_PRODUCT_CATEGORY_ACCT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_CATEGORY_ID { get; set; }
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
        public int P_COGS_ACCT { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COSTINGMETHOD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COSTINGLEVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int P_INVENTORYCLEARING_ACCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int P_COSTADJUSTMENT_ACCT { get; set; }

    }
}
