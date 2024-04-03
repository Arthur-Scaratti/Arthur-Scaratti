
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CST_CALCULO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID da formula do calculo do custo
        /// </summary>
        public int BEG_CST_CALCULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// Codigo da formula do calculo do custo
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Descric?o da formula do calculo do custo
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do ICMS nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_ICMS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor de outros do ICMS nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_OUTROS_ICMS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do ICMS da substituic?o tributaria nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_ICMS_SUBST { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do IPI nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_IPI { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor de outros do IPI nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_OUTROS_IPI { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do IR nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_IR { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do INSS nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_INSS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do ISSQN nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_ISSQN { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do frete nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_FRETE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do seguro nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_SEGURO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor das despesas financeiras nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor das outras despesas nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_OUTRAS_DESPESAS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do desconto nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_DESCONTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do acrescimo nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_ACRESCIMO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor do PIS nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_PIS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica comportamento do valor da COFINS nos custos: S - Soma / D - Diminui / N - Nada
        /// </summary>
        public string IND_COFINS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o custo liquido e medio devem ser calculados
        /// </summary>
        public string IND_CALCULAR { get; set; }

    }
}
