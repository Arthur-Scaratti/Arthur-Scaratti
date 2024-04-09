
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_SYS_FOREIGN_COLS
    {
            [Required]
    [StringLength(193)]
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string FOR_COL_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string REF_COL_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int POS { get; set; }

}
}
