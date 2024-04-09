
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_BUFFER_POOL_STATS
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int POOL_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long POOL_SIZE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long FREE_BUFFERS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long DATABASE_PAGES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long OLD_DATABASE_PAGES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long MODIFIED_DATABASE_PAGES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long PENDING_DECOMPRESS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long PENDING_READS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long PENDING_FLUSH_LRU { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long PENDING_FLUSH_LIST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long PAGES_MADE_YOUNG { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long PAGES_NOT_MADE_YOUNG { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public float PAGES_MADE_YOUNG_RATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public float PAGES_MADE_NOT_YOUNG_RATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NUMBER_PAGES_READ { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NUMBER_PAGES_CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NUMBER_PAGES_WRITTEN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public float PAGES_READ_RATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public float PAGES_CREATE_RATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public float PAGES_WRITTEN_RATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NUMBER_PAGES_GET { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long HIT_RATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long YOUNG_MAKE_PER_THOUSAND_GETS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NOT_YOUNG_MAKE_PER_THOUSAND_GETS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NUMBER_PAGES_READ_AHEAD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NUMBER_READ_AHEAD_EVICTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public float READ_AHEAD_RATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public float READ_AHEAD_EVICTED_RATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long LRU_IO_TOTAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long LRU_IO_CURRENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long UNCOMPRESS_TOTAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long UNCOMPRESS_CURRENT { get; set; }

}
}
