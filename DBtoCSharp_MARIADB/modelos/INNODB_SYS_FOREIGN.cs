
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_SYS_FOREIGN
    {
            [Required]
    [StringLength(193)]
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }
            [Required]
    [StringLength(193)]
        /// <summary>
        /// 
        /// </summary>
        public string FOR_NAME { get; set; }
            [Required]
    [StringLength(193)]
        /// <summary>
        /// 
        /// </summary>
        public string REF_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int N_COLS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TYPE { get; set; }

}
}
