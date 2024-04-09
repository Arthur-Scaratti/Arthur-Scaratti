
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_CMPMEM_RESET
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
        public int buffer_pool_instance { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int pages_used { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int pages_free { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long relocation_ops { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int relocation_time { get; set; }

}
}
