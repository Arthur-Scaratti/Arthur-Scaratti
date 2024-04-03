
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_SALDO_CONTABIL_MENSAL
    {
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo diario  (C)liente ; (F)ornecedor
        /// </summary>
        public string TP_DIARIO { get; set; }
            [Required]
        /// <summary>
        /// Ano do saldo
        /// </summary>
        public int ANO_SDO { get; set; }
            [Required]
        /// <summary>
        /// Mes do saldo
        /// </summary>
        public int MES_SDO { get; set; }
            [Required]
        /// <summary>
        /// Codigo da conta contabil
        /// </summary>
        public int COD_CTA { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Codigo do centro de custo
        /// </summary>
        public string COD_CCUS { get; set; }
            [Required]
        /// <summary>
        /// Saldo inicial do mes
        /// </summary>
        public int VL_SDO_INI { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indicativo se (D)evedor ou (C)redor inicial
        /// </summary>
        public string IND_DC_INI { get; set; }
            [Required]
        /// <summary>
        /// Valor dos movimentos a debito
        /// </summary>
        public int VL_MVTO_DEB { get; set; }
            [Required]
        /// <summary>
        /// Valor dos movimentos a credito
        /// </summary>
        public int VL_MVTO_CRE { get; set; }
            [Required]
        /// <summary>
        /// Saldo Final do mes
        /// </summary>
        public int VL_SDO_FIN { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indicativo se (D)evedor ou (C)redor final
        /// </summary>
        public string IND_DC_FIN { get; set; }

    }
}
