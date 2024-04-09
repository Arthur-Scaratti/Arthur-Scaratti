
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PROFILING
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QUERY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEQ { get; set; }
            [Required]
    [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string STATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal DURATION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public decimal CPU_USER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public decimal CPU_SYSTEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTEXT_VOLUNTARY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTEXT_INVOLUNTARY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BLOCK_OPS_IN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BLOCK_OPS_OUT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MESSAGES_SENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MESSAGES_RECEIVED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PAGE_FAULTS_MAJOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PAGE_FAULTS_MINOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SWAPS { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string SOURCE_FUNCTION { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string SOURCE_FILE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SOURCE_LINE { get; set; }

}
}
