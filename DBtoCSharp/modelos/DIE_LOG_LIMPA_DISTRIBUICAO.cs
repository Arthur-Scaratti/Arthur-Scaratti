
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_LOG_LIMPA_DISTRIBUICAO
    {
            [Required]
    [Key]
        /// <summary>
        /// Data de execucao da rotina de limpeza (DIE_PRC_LIMPA_DISTR)
        /// </summary>
        public string DT_EXECUCAO { get; set; }
        
        /// <summary>
        /// Data e Hora de inicio da execucao da rotina
        /// </summary>
        public string DTH_INICIO { get; set; }
        
        /// <summary>
        /// Data e Hora  do final da execucao da rotina
        /// </summary>
        public string DTH_FINAL { get; set; }

    }
}
