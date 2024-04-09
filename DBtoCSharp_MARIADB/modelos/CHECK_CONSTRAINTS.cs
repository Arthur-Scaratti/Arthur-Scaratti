
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CHECK_CONSTRAINTS
    {
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string CONSTRAINT_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string CONSTRAINT_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string CONSTRAINT_NAME { get; set; }
            [Required]
    [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string LEVEL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CHECK_CLAUSE { get; set; }

}
}
