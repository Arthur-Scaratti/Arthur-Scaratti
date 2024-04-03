
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_CASHLINE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_CASHLINE_ID { get; set; }
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
        public int C_CASH_ID { get; set; }
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
        public string CASHTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_BANKACCOUNT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CHARGE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_INVOICE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AMOUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNTAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int WRITEOFFAMT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISGENERATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }

    }
}
