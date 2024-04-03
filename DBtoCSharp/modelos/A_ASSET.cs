
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class A_ASSET
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int A_ASSET_ID { get; set; }
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
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int A_ASSET_GROUP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SERNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LOT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VERSIONNO { get; set; }
        
        /// <summary>
        /// Guarantee Valid Unyil
        /// </summary>
        public string GUARANTEEDATE { get; set; }
        
        /// <summary>
        /// Date Last Serviced
        /// </summary>
        public string ASSETSERVICEDATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISOWNED { get; set; }
        
        /// <summary>
        /// Date Last Depreciated
        /// </summary>
        public string ASSETDEPRECIATIONDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USELIFEYEARS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USELIFEMONTHS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIFEUSEUNITS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USEUNITS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDISPOSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ASSETDISPOSALDATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINPOSESSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LOCATIONCOMMENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_LOCATOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_LOCATION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCATION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEPRECIATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISFULLYDEPRECIATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_ATTRIBUTESETINSTANCE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNERSR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_INOUTLINE_ID { get; set; }

    }
}
