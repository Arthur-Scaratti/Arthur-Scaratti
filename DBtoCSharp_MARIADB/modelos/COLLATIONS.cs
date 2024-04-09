
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class COLLATIONS
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string COLLATION_NAME { get; set; }
            [StringLength(32)]
        /// <summary>
        /// 
        /// </summary>
        public string CHARACTER_SET_NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long ID { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IS_DEFAULT { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IS_COMPILED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long SORTLEN { get; set; }

}
}
