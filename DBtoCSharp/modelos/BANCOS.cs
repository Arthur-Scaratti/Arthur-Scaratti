
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BANCOS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string BANCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ORGAORECEBEDOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CODRESUMIDO { get; set; }

    }
}
