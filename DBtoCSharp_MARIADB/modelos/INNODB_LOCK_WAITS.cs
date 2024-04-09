
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_LOCK_WAITS
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long requesting_trx_id { get; set; }
            [Required]
    [StringLength(81)]
        /// <summary>
        /// 
        /// </summary>
        public string requested_lock_id { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long blocking_trx_id { get; set; }
            [Required]
    [StringLength(81)]
        /// <summary>
        /// 
        /// </summary>
        public string blocking_lock_id { get; set; }

}
}
