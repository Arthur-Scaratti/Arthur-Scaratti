
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class HTMLDB_PLAN_TABLE
    {
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string STATEMENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PLAN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TIMESTAMP { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string REMARKS { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string OPERATION { get; set; }
            [StringLength(255)]
        /// <summary>
        /// 
        /// </summary>
        public string OPTIONS { get; set; }
            [StringLength(128)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_NODE { get; set; }
            [StringLength(128)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_OWNER { get; set; }
            [StringLength(128)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_NAME { get; set; }
            [StringLength(261)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_ALIAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OBJECT_INSTANCE { get; set; }
            [StringLength(128)]
        /// <summary>
        /// 
        /// </summary>
        public string OBJECT_TYPE { get; set; }
            [StringLength(255)]
        /// <summary>
        /// 
        /// </summary>
        public string OPTIMIZER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEARCH_COLUMNS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DEPTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int POSITION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CARDINALITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BYTES { get; set; }
            [StringLength(255)]
        /// <summary>
        /// 
        /// </summary>
        public string OTHER_TAG { get; set; }
            [StringLength(255)]
        /// <summary>
        /// 
        /// </summary>
        public string PARTITION_START { get; set; }
            [StringLength(255)]
        /// <summary>
        /// 
        /// </summary>
        public string PARTITION_STOP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARTITION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OTHER { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DISTRIBUTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CPU_COST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IO_COST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TEMP_SPACE { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string ACCESS_PREDICATES { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string FILTER_PREDICATES { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string PROJECTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TIME { get; set; }
            [StringLength(128)]
        /// <summary>
        /// 
        /// </summary>
        public string QBLOCK_NAME { get; set; }

    }
}
