
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class SPATIAL_REF_SYS
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public short SRID { get; set; }
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string AUTH_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AUTH_SRID { get; set; }
            [Required]
    [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string SRTEXT { get; set; }

}
}
