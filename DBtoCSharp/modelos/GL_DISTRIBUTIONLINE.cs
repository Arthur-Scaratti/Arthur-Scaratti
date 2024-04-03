
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class GL_DISTRIBUTIONLINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int GL_DISTRIBUTIONLINE_ID { get; set; }
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
        public int GL_DISTRIBUTION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LINE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERCENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITEORG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORG_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITEACCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ACCOUNT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITEPRODUCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITEBPARTNER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITEPROJECT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITECAMPAIGN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CAMPAIGN_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITEACTIVITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACTIVITY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITESALESREGION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_SALESREGION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITEORGTRX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGTRX_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITELOCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITELOCFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCFROM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITEUSER1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USER1_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OVERWRITEUSER2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USER2_ID { get; set; }

    }
}
