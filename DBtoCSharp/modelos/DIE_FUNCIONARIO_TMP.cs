
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FUNCIONARIO_TMP
    {
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [Required]
    [StringLength(11)]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ARQ { get; set; }

    }
}
