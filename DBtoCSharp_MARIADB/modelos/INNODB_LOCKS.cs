
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_LOCKS
    {
            [Required]
    [StringLength(81)]
        /// <summary>
        /// 
        /// </summary>
        public string lock_id { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long lock_trx_id { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string lock_mode { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string lock_type { get; set; }
            [Required]
    [StringLength(1024)]
        /// <summary>
        /// 
        /// </summary>
        public string lock_table { get; set; }
            [StringLength(1024)]
        /// <summary>
        /// 
        /// </summary>
        public string lock_index { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int lock_space { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int lock_page { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int lock_rec { get; set; }
            [StringLength(8192)]
        /// <summary>
        /// 
        /// </summary>
        public string lock_data { get; set; }

}
}
