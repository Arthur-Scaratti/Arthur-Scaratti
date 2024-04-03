
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_SCHEDULER
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_SCHEDULER_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PROCESS_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string FREQUENCYTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FREQUENCY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATELASTRUN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATENEXTRUN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SUPERVISOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int KEEPLOGDAYS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEEKDAY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SCHEDULETYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MONTHDAY { get; set; }

    }
}
