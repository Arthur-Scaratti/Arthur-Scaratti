
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class KEY_COLUMN_USAGE
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
        public string CONSTRAINT_NAME { get; set; }
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_SCHEMA { get; set; }
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
        public string COLUMN_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ORDINAL_POSITION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long POSITION_IN_UNIQUE_CONSTRAINT { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCED_TABLE_SCHEMA { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCED_TABLE_NAME { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCED_COLUMN_NAME { get; set; }

}
}
