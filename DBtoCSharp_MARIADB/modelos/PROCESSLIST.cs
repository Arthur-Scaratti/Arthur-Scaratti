
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PROCESSLIST
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ID { get; set; }
            [Required]
    [StringLength(128)]
        /// <summary>
        /// 
        /// </summary>
        public string USER { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string HOST { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string DB { get; set; }
            [Required]
    [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string COMMAND { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TIME { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string STATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string INFO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal TIME_MS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int STAGE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MAX_STAGE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public decimal PROGRESS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long MEMORY_USED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long MAX_MEMORY_USED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int EXAMINED_ROWS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long QUERY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] INFO_BINARY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long TID { get; set; }

}
}
