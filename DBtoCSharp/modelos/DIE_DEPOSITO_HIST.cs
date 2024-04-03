
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_DEPOSITO_HIST
    {
            [Required]
        /// <summary>
        /// id do banco
        /// </summary>
        public int BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALUE { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_CONTA_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE_CONTA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_HISTORICO_ID { get; set; }
            [Required]
        /// <summary>
        /// se deposito do dia = 1 se dia seguinte=2
        /// </summary>
        public int TIPO { get; set; }
        
        /// <summary>
        /// Id do portador para carregar correto relatorio dos depositos efetuados. Nao interfere no PDV
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }

    }
}
