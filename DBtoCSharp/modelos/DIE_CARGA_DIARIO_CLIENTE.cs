
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARGA_DIARIO_CLIENTE
    {
            [Required]
    [Key]
        /// <summary>
        /// Data do lancamento
        /// </summary>
        public string DT_LANCAMENTO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Nro lancamento
        /// </summary>
        public int NRO_LANCAMENTO { get; set; }
            [Required]
        /// <summary>
        /// Id a filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// Id do parceiro comercial - cliente
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
    [StringLength(28)]
        /// <summary>
        /// Contrapartida
        /// </summary>
        public string CONTRAPARTIDA { get; set; }
            [Required]
        /// <summary>
        /// Valor do lancamento
        /// </summary>
        public int VL_LANCAMENTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indicado de debito ou credito
        /// </summary>
        public string IND_DEB_CRE { get; set; }
            [StringLength(200)]
        /// <summary>
        /// historico
        /// </summary>
        public string HISTORICO { get; set; }

    }
}
