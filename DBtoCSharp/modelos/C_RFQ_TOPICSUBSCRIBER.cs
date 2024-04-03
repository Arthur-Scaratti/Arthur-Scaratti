
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_RFQ_TOPICSUBSCRIBER
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_RFQ_TOPICSUBSCRIBER_ID { get; set; }
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
        public int C_RFQ_TOPIC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_LOCATION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUBSCRIBEDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OPTOUTDATE { get; set; }

    }
}
