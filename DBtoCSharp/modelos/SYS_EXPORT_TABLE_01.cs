
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class SYS_EXPORT_TABLE_01
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int PROCESS_ORDER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DUPLICATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DUMP_FILEID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DUMP_POSITION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DUMP_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DUMP_ORIG_LENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DUMP_ALLOCATION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMPLETED_ROWS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ERROR_COUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ELAPSED_TIME { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_TYPE_PATH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OBJECT_PATH_SEQNO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_TYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IN_PROGRESS { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_NAME { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_LONG_NAME { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_SCHEMA { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string ORIGINAL_OBJECT_SCHEMA { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string ORIGINAL_OBJECT_NAME { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string PARTITION_NAME { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string SUBPARTITION_NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DATAOBJ_NUM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FLAGS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROPERTY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TRIGFLAG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATION_LEVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COMPLETION_TIME { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_TABLESPACE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SIZE_ESTIMATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OBJECT_ROW { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING_STATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING_STATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASE_PROCESS_ORDER { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string BASE_OBJECT_TYPE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string BASE_OBJECT_NAME { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string BASE_OBJECT_SCHEMA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ANCESTOR_PROCESS_ORDER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DOMAIN_PROCESS_ORDER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARALLELIZATION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UNLOAD_METHOD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LOAD_METHOD { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GRANULES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SCN { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string GRANTOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string XML_CLOB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARENT_PROCESS_ORDER { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE_T { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALUE_N { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IS_DEFAULT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FILE_TYPE { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string USER_DIRECTORY { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string USER_FILE_NAME { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string FILE_NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EXTEND_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FILE_MAX_SIZE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESS_NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LAST_UPDATE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string WORK_ITEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OBJECT_NUMBER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMPLETED_BYTES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_BYTES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int METADATA_IO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DATA_IO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CUMULATIVE_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PACKET_NUMBER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int INSTANCE_ID { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string OLD_VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LAST_FILE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string USER_NAME { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string OPERATION { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string JOB_MODE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QUEUE_TABNUM { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTROL_QUEUE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS_QUEUE { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string REMOTE_LINK { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VERSION { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string JOB_VERSION { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DB_VERSION { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TIMEZONE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string STATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PHASE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] GUID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string START_TIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BLOCK_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int METADATA_BUFFER_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DATA_BUFFER_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DEGREE { get; set; }
            [StringLength(101)]
        /// <summary>
        /// 
        /// </summary>
        public string PLATFORM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ABORT_STEP { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string INSTANCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CLUSTER_OK { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string SERVICE_NAME { get; set; }
            [StringLength(32)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_INT_OID { get; set; }

    }
}
