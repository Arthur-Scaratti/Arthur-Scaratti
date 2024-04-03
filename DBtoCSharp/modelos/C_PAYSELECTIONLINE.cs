
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_PAYSELECTIONLINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYSELECTIONLINE_ID { get; set; }
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
        public int LINE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PAYMENTRULE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMANUAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICE_ID { get; set; }
            [Required]
        /// <summary>
        /// Payment Amount in bank account currency
        /// </summary>
        public int PAYAMT { get; set; }
            [Required]
        /// <summary>
        /// Amount in bank account currency between converted Invoice amount and payment amount
        /// </summary>
        public int DIFFERENCEAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYSELECTIONCHECK_ID { get; set; }
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
        public int OPENAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSOTRX { get; set; }

    }
}
