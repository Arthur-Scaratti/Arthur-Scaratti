
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class user_variables
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string VARIABLE_NAME { get; set; }
            [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string VARIABLE_VALUE { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string VARIABLE_TYPE { get; set; }
            [StringLength(32)]
        /// <summary>
        /// 
        /// </summary>
        public string CHARACTER_SET_NAME { get; set; }

}
}
