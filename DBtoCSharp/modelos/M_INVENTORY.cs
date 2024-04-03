
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_INVENTORY
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_INVENTORY_ID { get; set; }
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
        public string DOCUMENTNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_WAREHOUSE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string MOVEMENTDATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string POSTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATEQTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GENERATELIST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PERPETUALINV_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGTRX_ID { get; set; }
        
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISAPPROVED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCACTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int APPROVALAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_DOCTYPE_ID { get; set; }

    }
}
