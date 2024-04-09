
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class SCHEMATA
    {
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string CATALOG_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string SCHEMA_NAME { get; set; }
            [Required]
    [StringLength(32)]
        /// <summary>
        /// 
        /// </summary>
        public string DEFAULT_CHARACTER_SET_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string DEFAULT_COLLATION_NAME { get; set; }
            [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string SQL_PATH { get; set; }
            [Required]
    [StringLength(1024)]
        /// <summary>
        /// 
        /// </summary>
        public string SCHEMA_COMMENT { get; set; }

}
}
