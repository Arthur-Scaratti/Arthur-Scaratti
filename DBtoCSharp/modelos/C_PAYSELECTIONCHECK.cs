
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_PAYSELECTIONCHECK
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYSELECTIONCHECK_ID { get; set; }
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
        public int C_PAYSELECTION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PAYAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYMENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPRINTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PAYMENTRULE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNTAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISRECEIPT { get; set; }

    }
}
