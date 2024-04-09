
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_CMP_PER_INDEX
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string database_name { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string table_name { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string index_name { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int compress_ops { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int compress_ops_ok { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int compress_time { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int uncompress_ops { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int uncompress_time { get; set; }

}
}
