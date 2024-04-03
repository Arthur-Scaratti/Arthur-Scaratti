
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_TPMOV
    {
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRA_PARTIDA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TPMOV_ID { get; set; }
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
        /// Descricao do tipo de movimento
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Historico sai no diaria auxiliar
        /// </summary>
        public string DIARIO_AUXILIAR { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Debito ou Credito
        /// </summary>
        public string DEBITO_CREDITO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Calcula juros
        /// </summary>
        public string CALCULA_JUROS { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_PGTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Como o tipo de movimento do titulo reletira na comissao L - Libera, E- Estorna ou D- Desconsidera
        /// </summary>
        public string REFLEXO_COMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PGTO_MANUAL { get; set; }

    }
}
