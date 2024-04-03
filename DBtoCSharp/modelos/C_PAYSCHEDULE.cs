
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_PAYSCHEDULE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_PAYSCHEDULE_ID { get; set; }
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
        public int C_PAYMENTTERM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERCENTAGE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NETDAYS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NETDAY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNTDAYS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DISCOUNT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVALID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int GRACEDAYS { get; set; }

    }
}
