
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PARAMETERS
    {
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string SPECIFIC_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string SPECIFIC_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string SPECIFIC_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ORDINAL_POSITION { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string PARAMETER_MODE { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string PARAMETER_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_TYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CHARACTER_MAXIMUM_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CHARACTER_OCTET_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUMERIC_PRECISION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUMERIC_SCALE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long DATETIME_PRECISION { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string CHARACTER_SET_NAME { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string COLLATION_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DTD_IDENTIFIER { get; set; }
            [Required]
    [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string ROUTINE_TYPE { get; set; }

}
}
