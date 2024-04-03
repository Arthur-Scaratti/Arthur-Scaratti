
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PRINTFORM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTFORM_ID { get; set; }
        
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
        public int INVOICE_PRINTFORMAT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORDER_PRINTFORMAT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REMITTANCE_PRINTFORMAT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SHIPMENT_PRINTFORMAT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int INVOICE_MAILTEXT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORDER_MAILTEXT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REMITTANCE_MAILTEXT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SHIPMENT_MAILTEXT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROJECT_MAILTEXT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROJECT_PRINTFORMAT_ID { get; set; }

    }
}
