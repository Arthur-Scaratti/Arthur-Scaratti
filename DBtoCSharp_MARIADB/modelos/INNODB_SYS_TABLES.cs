
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_SYS_TABLES
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long TABLE_ID { get; set; }
            [Required]
    [StringLength(655)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FLAG { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int N_COLS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SPACE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ROW_FORMAT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ZIP_PAGE_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SPACE_TYPE { get; set; }

}
}
