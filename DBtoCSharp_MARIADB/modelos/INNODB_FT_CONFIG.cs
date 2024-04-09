
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_FT_CONFIG
    {
            [Required]
    [StringLength(193)]
        /// <summary>
        /// 
        /// </summary>
        public string KEY { get; set; }
            [Required]
    [StringLength(193)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }

}
}
