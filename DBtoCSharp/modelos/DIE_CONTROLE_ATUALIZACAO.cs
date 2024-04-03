
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONTROLE_ATUALIZACAO
    {
            [Required]
    [StringLength(20)]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(19)]
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ATUALIZADO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string ORIGEM { get; set; }

    }
}
