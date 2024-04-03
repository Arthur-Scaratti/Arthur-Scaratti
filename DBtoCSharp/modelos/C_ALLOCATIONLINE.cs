
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_ALLOCATIONLINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_ALLOCATIONLINE_ID { get; set; }
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
        public int ALLOCATIONNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATETRX { get; set; }
        
        /// <summary>
        /// If not manual the open item balance of the business partner is updated
        /// </summary>
        public string ISMANUAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_ORDER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CASHLINE_ID { get; set; }
            [Required]
        /// <summary>
        /// PaymentAmount
        /// </summary>
        public int AMOUNT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNTAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int WRITEOFFAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string POSTED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OVERUNDERAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_ALLOCATIONHDR_ID { get; set; }

    }
}
