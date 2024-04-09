
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_TRX
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long trx_id { get; set; }
            [Required]
    [StringLength(13)]
        /// <summary>
        /// 
        /// </summary>
        public string trx_state { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string trx_started { get; set; }
            [StringLength(81)]
        /// <summary>
        /// 
        /// </summary>
        public string trx_requested_lock_id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string trx_wait_started { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long trx_weight { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long trx_mysql_thread_id { get; set; }
            [StringLength(1024)]
        /// <summary>
        /// 
        /// </summary>
        public string trx_query { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string trx_operation_state { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long trx_tables_in_use { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long trx_tables_locked { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long trx_lock_structs { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long trx_lock_memory_bytes { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long trx_rows_locked { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long trx_rows_modified { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long trx_concurrency_tickets { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string trx_isolation_level { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int trx_unique_checks { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int trx_foreign_key_checks { get; set; }
            [StringLength(256)]
        /// <summary>
        /// 
        /// </summary>
        public string trx_last_foreign_key_error { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int trx_is_read_only { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int trx_autocommit_non_locking { get; set; }

}
}
