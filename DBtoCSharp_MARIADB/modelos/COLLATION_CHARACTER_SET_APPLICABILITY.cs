
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class COLLATION_CHARACTER_SET_APPLICABILITY
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string COLLATION_NAME { get; set; }
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
        public string FULL_COLLATION_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long ID { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IS_DEFAULT { get; set; }

}
}
