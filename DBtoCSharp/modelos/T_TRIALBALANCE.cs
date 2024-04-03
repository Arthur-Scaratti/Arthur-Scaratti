
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class T_TRIALBALANCE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PINSTANCE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int FACT_ACCT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
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
        public int C_ACCTSCHEMA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ACCOUNT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATETRX { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATEACCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PERIOD_ID { get; set; }
        
        /// <summary>
        /// AD_Table_ID Definition
        /// </summary>
        public int AD_TABLE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RECORD_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LINE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GL_CATEGORY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GL_BUDGET_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_TAX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_LOCATOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string POSTINGTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AMTSOURCEDR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AMTSOURCECR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AMTSOURCEBALANCE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AMTACCTDR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AMTACCTCR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AMTACCTBALANCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGTRX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCFROM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_SALESREGION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
        
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
        public int A_ASSET_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ACCOUNTVALUE { get; set; }

    }
}
