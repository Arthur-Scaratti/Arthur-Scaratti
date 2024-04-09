
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class THREAD_POOL_GROUPS
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
        public int CONNECTIONS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int THREADS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ACTIVE_THREADS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int STANDBY_THREADS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QUEUE_LENGTH { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int HAS_LISTENER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int IS_STALLED { get; set; }

}
}
