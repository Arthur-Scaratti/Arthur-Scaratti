
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class SESSION_VARIABLES
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string VARIABLE_NAME { get; set; }
            [Required]
    [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string VARIABLE_VALUE { get; set; }

}
}
