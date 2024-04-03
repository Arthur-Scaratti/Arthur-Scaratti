
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PRD_ACERTO_CODIGO
    {
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CODANTC9 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_DETALC20 { get; set; }
            [Required]
    [StringLength(30)]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string CODNOVOC9 { get; set; }

    }
}
