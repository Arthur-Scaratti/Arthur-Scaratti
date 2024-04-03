
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CAR_TPMOV
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CAR_TPMOV_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
    [StringLength(50)]
        /// <summary>
        /// Descricao do tipo de movimento.
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Débito ou Crédito.
        /// </summary>
        public string DEBITO_CREDITO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Calcula juros.
        /// </summary>
        public string CALCULA_JUROS { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Tipo do Pagamento.
        /// </summary>
        public string TP_PGTO { get; set; }
            [Required]
        /// <summary>
        /// Identificador de pagamento manual.
        /// </summary>
        public string PGTO_MANUAL { get; set; }

    }
}
