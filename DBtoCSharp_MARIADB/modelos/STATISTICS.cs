
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class STATISTICS
    {
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long NON_UNIQUE { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string INDEX_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string INDEX_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long SEQ_IN_INDEX { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string COLUMN_NAME { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string COLLATION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long CARDINALITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long SUB_PART { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string PACKED { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string NULLABLE { get; set; }
            [Required]
    [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string INDEX_TYPE { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string COMMENT { get; set; }
            [Required]
    [StringLength(1024)]
        /// <summary>
        /// 
        /// </summary>
        public string INDEX_COMMENT { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IGNORED { get; set; }

}
}
