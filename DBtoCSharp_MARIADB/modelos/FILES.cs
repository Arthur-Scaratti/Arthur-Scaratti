
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class FILES
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long FILE_ID { get; set; }
            [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string FILE_NAME { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FILE_TYPE { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLESPACE_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_CATALOG { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_SCHEMA { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_NAME { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string LOGFILE_GROUP_NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long LOGFILE_GROUP_NUMBER { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string ENGINE { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string FULLTEXT_KEYS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long DELETED_ROWS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long UPDATE_COUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long FREE_EXTENTS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long TOTAL_EXTENTS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long EXTENT_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long INITIAL_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long MAXIMUM_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long AUTOEXTEND_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATION_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LAST_UPDATE_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LAST_ACCESS_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long RECOVER_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long TRANSACTION_COUNTER { get; set; }
        
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
        public string CREATE_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATE_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CHECK_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long CHECKSUM { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
            [StringLength(255)]
        /// <summary>
        /// 
        /// </summary>
        public string EXTRA { get; set; }

}
}
