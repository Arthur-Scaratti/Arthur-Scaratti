
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class S_TIMEEXPENSELINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int S_TIMEEXPENSELINE_ID { get; set; }
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
        public int S_TIMEEXPENSE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LINE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTIMEREPORT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEEXPENSE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EXPENSEAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONVERTEDAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int S_RESOURCEASSIGNMENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NOTE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACTIVITY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CAMPAIGN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICELINE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int INVOICEPRICE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDERLINE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECTPHASE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECTTASK_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int S_TIMETYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTYINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTYREIMBURSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRICEINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRICEREIMBURSED { get; set; }

    }
}
