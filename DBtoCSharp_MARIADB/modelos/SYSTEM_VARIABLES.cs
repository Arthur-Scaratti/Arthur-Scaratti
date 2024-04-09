
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class SYSTEM_VARIABLES
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string VARIABLE_NAME { get; set; }
            [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string SESSION_VALUE { get; set; }
            [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string GLOBAL_VALUE { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string GLOBAL_VALUE_ORIGIN { get; set; }
            [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string DEFAULT_VALUE { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string VARIABLE_SCOPE { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string VARIABLE_TYPE { get; set; }
            [Required]
    [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string VARIABLE_COMMENT { get; set; }
            [StringLength(21)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERIC_MIN_VALUE { get; set; }
            [StringLength(21)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERIC_MAX_VALUE { get; set; }
            [StringLength(21)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERIC_BLOCK_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENUM_VALUE_LIST { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string READ_ONLY { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string COMMAND_LINE_ARGUMENT { get; set; }
            [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string GLOBAL_VALUE_PATH { get; set; }

}
}
