
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_SYS_TABLESTATS
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long TABLE_ID { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int STATS_INITIALIZED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NUM_ROWS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long CLUST_INDEX_SIZE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long OTHER_INDEX_SIZE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long MODIFIED_COUNTER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long AUTOINC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int REF_COUNT { get; set; }

}
}
