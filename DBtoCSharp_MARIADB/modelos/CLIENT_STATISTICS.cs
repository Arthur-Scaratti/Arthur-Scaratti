
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CLIENT_STATISTICS
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string CLIENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long TOTAL_CONNECTIONS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long CONCURRENT_CONNECTIONS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long CONNECTED_TIME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public double BUSY_TIME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public double CPU_TIME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long BYTES_RECEIVED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long BYTES_SENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long BINLOG_BYTES_WRITTEN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ROWS_READ { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ROWS_SENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ROWS_DELETED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ROWS_INSERTED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ROWS_UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long SELECT_COMMANDS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long UPDATE_COMMANDS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long OTHER_COMMANDS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long COMMIT_TRANSACTIONS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ROLLBACK_TRANSACTIONS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long DENIED_CONNECTIONS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long LOST_CONNECTIONS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ACCESS_DENIED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long EMPTY_QUERIES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long TOTAL_SSL_CONNECTIONS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long MAX_STATEMENT_TIME_EXCEEDED { get; set; }

}
}
