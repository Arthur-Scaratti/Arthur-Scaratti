
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TABLES
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
        public string TABLE_TYPE { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string ENGINE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long VERSION { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string ROW_FORMAT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long TABLE_ROWS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long AVG_ROW_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long DATA_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long MAX_DATA_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long INDEX_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long DATA_FREE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long AUTO_INCREMENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATE_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATE_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHECK_TIME { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_COLLATION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long CHECKSUM { get; set; }
            [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string CREATE_OPTIONS { get; set; }
            [Required]
    [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_COMMENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long MAX_INDEX_LENGTH { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TEMPORARY { get; set; }

}
}
