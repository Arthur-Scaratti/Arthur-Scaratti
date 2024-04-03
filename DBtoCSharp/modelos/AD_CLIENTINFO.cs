
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_CLIENTINFO
    {
            [Required]
    [Key]
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
        public string ISDISCOUNTLINEAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CALENDAR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACCTSCHEMA1_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_VOLUME_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_WEIGHT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_LENGTH_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_UOM_TIME_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TREE_MENU_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TREE_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TREE_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TREE_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TREE_SALESREGION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TREE_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// Default Product for Freightcosts
        /// </summary>
        public int M_PRODUCTFREIGHT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNERCASHTRX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PA_GOAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int KEEPLOGDAYS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TREE_ACTIVITY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TREE_CAMPAIGN_ID { get; set; }

    }
}
