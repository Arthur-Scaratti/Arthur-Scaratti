
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ROUTINES
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string SPECIFIC_NAME { get; set; }
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string ROUTINE_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string ROUTINE_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string ROUTINE_NAME { get; set; }
            [Required]
    [StringLength(13)]
        /// <summary>
        /// 
        /// </summary>
        public string ROUTINE_TYPE { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DTD_IDENTIFIER { get; set; }
            [Required]
    [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string ROUTINE_BODY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ROUTINE_DEFINITION { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string EXTERNAL_NAME { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string EXTERNAL_LANGUAGE { get; set; }
            [Required]
    [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string PARAMETER_STYLE { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IS_DETERMINISTIC { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string SQL_DATA_ACCESS { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string SQL_PATH { get; set; }
            [Required]
    [StringLength(7)]
        /// <summary>
        /// 
        /// </summary>
        public string SECURITY_TYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string LAST_ALTERED { get; set; }
            [Required]
    [StringLength(8192)]
        /// <summary>
        /// 
        /// </summary>
        public string SQL_MODE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ROUTINE_COMMENT { get; set; }
            [Required]
    [StringLength(384)]
        /// <summary>
        /// 
        /// </summary>
        public string DEFINER { get; set; }
            [Required]
    [StringLength(32)]
        /// <summary>
        /// 
        /// </summary>
        public string CHARACTER_SET_CLIENT { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string COLLATION_CONNECTION { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string DATABASE_COLLATION { get; set; }

}
}
