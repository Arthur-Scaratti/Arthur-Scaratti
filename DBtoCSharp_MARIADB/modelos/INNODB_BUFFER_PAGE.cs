
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_BUFFER_PAGE
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
        public long BLOCK_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SPACE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PAGE_NUMBER { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string PAGE_TYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FLUSH_TYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FIX_COUNT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int IS_HASHED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NEWEST_MODIFICATION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long OLDEST_MODIFICATION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ACCESS_TIME { get; set; }
            [StringLength(1024)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_NAME { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string INDEX_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NUMBER_RECORDS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long DATA_SIZE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long COMPRESSED_SIZE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PAGE_STATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IO_FIX { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int IS_OLD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long FREE_PAGE_CLOCK { get; set; }

}
}
