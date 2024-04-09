
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_METRICS
    {
            [Required]
    [StringLength(193)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(193)]
        /// <summary>
        /// 
        /// </summary>
        public string SUBSYSTEM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long COUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long MAX_COUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long MIN_COUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public float AVG_COUNT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long COUNT_RESET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long MAX_COUNT_RESET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long MIN_COUNT_RESET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public float AVG_COUNT_RESET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TIME_ENABLED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TIME_DISABLED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long TIME_ELAPSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TIME_RESET { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ENABLED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TYPE { get; set; }
            [Required]
    [StringLength(193)]
        /// <summary>
        /// 
        /// </summary>
        public string COMMENT { get; set; }

}
}
