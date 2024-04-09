
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_CMP_RESET
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int page_size { get; set; }
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
