
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class THREAD_POOL_WAITS
    {
            [Required]
    [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string REASON { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long COUNT { get; set; }

}
}
