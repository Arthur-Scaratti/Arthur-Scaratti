
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_SYS_TABLESPACES
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SPACE { get; set; }
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
            [StringLength(22)]
        /// <summary>
        /// 
        /// </summary>
        public string ROW_FORMAT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PAGE_SIZE { get; set; }
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string FILENAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FS_BLOCK_SIZE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long FILE_SIZE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ALLOCATED_SIZE { get; set; }

}
}
