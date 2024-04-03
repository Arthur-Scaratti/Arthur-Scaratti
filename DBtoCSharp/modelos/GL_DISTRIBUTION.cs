
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class GL_DISTRIBUTION
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int GL_DISTRIBUTION_ID { get; set; }
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
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string POSTINGTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_DOCTYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_ACCTSCHEMA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYORG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORG_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYACCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ACCOUNT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYPRODUCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYBPARTNER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYPROJECT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYCAMPAIGN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CAMPAIGN_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYACTIVITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACTIVITY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYSALESREGION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_SALESREGION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYORGTRX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGTRX_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYLOCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYLOCFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCFROM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYUSER1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USER1_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANYUSER2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USER2_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERCENTTOTAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVALID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }

    }
}
