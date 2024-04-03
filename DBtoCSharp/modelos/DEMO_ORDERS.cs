
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DEMO_ORDERS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int ORDER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CUSTOMER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORDER_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ORDER_TIMESTAMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int USER_ID { get; set; }

    }
}
