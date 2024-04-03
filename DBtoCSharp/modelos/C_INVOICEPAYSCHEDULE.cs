
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_INVOICEPAYSCHEDULE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICEPAYSCHEDULE_ID { get; set; }
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
        public int C_INVOICE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYSCHEDULE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DUEDATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DUEAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DISCOUNTDATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNTAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVALID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }

    }
}
