
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class KEY_CACHES
    {
            [Required]
    [StringLength(192)]
        /// <summary>
        /// 
        /// </summary>
        public string KEY_CACHE_NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEGMENTS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEGMENT_NUMBER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long FULL_SIZE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long BLOCK_SIZE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long USED_BLOCKS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long UNUSED_BLOCKS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long DIRTY_BLOCKS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long READ_REQUESTS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long READS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long WRITE_REQUESTS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long WRITES { get; set; }

}
}
