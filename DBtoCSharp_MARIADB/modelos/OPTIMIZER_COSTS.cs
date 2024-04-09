
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class OPTIMIZER_COSTS
    {
            [Required]
    [StringLength(192)]
        /// <summary>
        /// 
        /// </summary>
        public string ENGINE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_DISK_READ_COST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_INDEX_BLOCK_COPY_COST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_KEY_COMPARE_COST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_KEY_COPY_COST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_KEY_LOOKUP_COST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_KEY_NEXT_FIND_COST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_DISK_READ_RATIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_ROW_COPY_COST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_ROW_LOOKUP_COST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_ROW_NEXT_FIND_COST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_ROWID_COMPARE_COST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal OPTIMIZER_ROWID_COPY_COST { get; set; }

}
}
