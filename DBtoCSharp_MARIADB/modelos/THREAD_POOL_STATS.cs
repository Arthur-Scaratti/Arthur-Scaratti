
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class THREAD_POOL_STATS
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
        public long THREAD_CREATIONS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long THREAD_CREATIONS_DUE_TO_STALL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long WAKES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long WAKES_DUE_TO_STALL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long THROTTLES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long STALLS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long POLLS_BY_LISTENER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long POLLS_BY_WORKER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long DEQUEUES_BY_LISTENER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long DEQUEUES_BY_WORKER { get; set; }

}
}
