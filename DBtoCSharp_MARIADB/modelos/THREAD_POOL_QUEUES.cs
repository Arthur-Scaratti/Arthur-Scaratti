
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class THREAD_POOL_QUEUES
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int GROUP_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int POSITION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRIORITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long CONNECTION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long QUEUEING_TIME_MICROSECONDS { get; set; }

}
}
