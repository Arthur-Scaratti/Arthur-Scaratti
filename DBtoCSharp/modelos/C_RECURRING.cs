
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_RECURRING
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int FREQUENCY { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_RECURRING_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string RECURRINGTYPE { get; set; }
        
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
        public int C_PROJECT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GL_JOURNALBATCH_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string FREQUENCYTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int RUNSMAX { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int RUNSREMAINING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATELASTRUN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATENEXTRUN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }

    }
}
