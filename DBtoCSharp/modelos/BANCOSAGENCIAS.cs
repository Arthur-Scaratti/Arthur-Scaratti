
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BANCOSAGENCIAS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string BANCO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string AGENCIA { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }

    }
}
