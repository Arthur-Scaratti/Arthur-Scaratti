
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class COLUMNS
    {
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
        public string COLUMN_DEFAULT { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IS_NULLABLE { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_TYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long CHARACTER_MAXIMUM_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long CHARACTER_OCTET_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long NUMERIC_PRECISION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long NUMERIC_SCALE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long DATETIME_PRECISION { get; set; }
            [StringLength(32)]
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
        public string COLUMN_TYPE { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string COLUMN_KEY { get; set; }
            [Required]
    [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string EXTRA { get; set; }
            [Required]
    [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string PRIVILEGES { get; set; }
            [Required]
    [StringLength(1024)]
        /// <summary>
        /// 
        /// </summary>
        public string COLUMN_COMMENT { get; set; }
            [Required]
    [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string IS_GENERATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string GENERATION_EXPRESSION { get; set; }

}
}
