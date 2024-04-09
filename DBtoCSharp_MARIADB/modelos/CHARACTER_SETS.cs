
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CHARACTER_SETS
    {
            [Required]
    [StringLength(32)]
        /// <summary>
        /// 
        /// </summary>
        public string CHARACTER_SET_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string DEFAULT_COLLATE_NAME { get; set; }
            [Required]
    [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long MAXLEN { get; set; }

}
}
