
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class OPTIMIZER_TRACE
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string QUERY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TRACE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MISSING_BYTES_BEYOND_MAX_MEM_SIZE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INSUFFICIENT_PRIVILEGES { get; set; }

}
}
