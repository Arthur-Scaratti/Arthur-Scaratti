
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class M_RMA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int M_RMA_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int M_INOUT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_DOCTYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SALESREP_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCACTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISAPPROVED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_RMATYPE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }

    }
}
