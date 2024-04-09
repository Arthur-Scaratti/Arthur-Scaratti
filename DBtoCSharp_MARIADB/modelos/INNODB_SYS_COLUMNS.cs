
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_SYS_COLUMNS
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long TABLE_ID { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long POS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LEN { get; set; }

}
}
