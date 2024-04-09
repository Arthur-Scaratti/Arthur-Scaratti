
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_SYS_INDEXES
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long INDEX_ID { get; set; }
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
        public long TABLE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int N_FIELDS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PAGE_NO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SPACE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MERGE_THRESHOLD { get; set; }

}
}
