
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PA_REPORTSOURCE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int PA_REPORTSOURCE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PA_REPORTLINE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ELEMENTTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ELEMENTVALUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CAMPAIGN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCATION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_SALESREGION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACTIVITY_ID { get; set; }

    }
}
