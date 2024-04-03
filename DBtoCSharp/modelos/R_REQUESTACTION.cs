
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class R_REQUESTACTION
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUMMARY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATENEXTACTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ACTIVITY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_REQUESTTYPE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int A_ASSET_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_INOUT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_RMA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NULLCOLUMNS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int R_REQUESTACTION_ID { get; set; }
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
        public int R_REQUEST_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_GROUP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_CATEGORY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_STATUS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int R_RESOLUTION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALESREP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ROLE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISESCALATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CONFIDENTIALTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISSELFSERVICE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRIORITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRIORITYUSER { get; set; }

    }
}
