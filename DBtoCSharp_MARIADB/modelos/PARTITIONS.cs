
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PARTITIONS
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
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string PARTITION_NAME { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string SUBPARTITION_NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long PARTITION_ORDINAL_POSITION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long SUBPARTITION_ORDINAL_POSITION { get; set; }
            [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string PARTITION_METHOD { get; set; }
            [StringLength(12)]
        /// <summary>
        /// 
        /// </summary>
        public string SUBPARTITION_METHOD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PARTITION_EXPRESSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUBPARTITION_EXPRESSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PARTITION_DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long TABLE_ROWS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long AVG_ROW_LENGTH { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long DATA_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long MAX_DATA_LENGTH { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long INDEX_LENGTH { get; set; }
            [Required]
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
    [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string PARTITION_COMMENT { get; set; }
            [Required]
    [StringLength(12)]
        /// <summary>
        /// 
        /// </summary>
        public string NODEGROUP { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLESPACE_NAME { get; set; }

}
}
