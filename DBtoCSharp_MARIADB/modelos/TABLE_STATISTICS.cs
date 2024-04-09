
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TABLE_STATISTICS
    {
            [Required]
    [StringLength(192)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_SCHEMA { get; set; }
            [Required]
    [StringLength(192)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ROWS_READ { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ROWS_CHANGED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ROWS_CHANGED_X_INDEXES { get; set; }

}
}
