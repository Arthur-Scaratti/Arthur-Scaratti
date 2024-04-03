
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_TIPO_TITULO
    {
        
        /// <summary>
        /// Indica se é a primeira venda
        /// </summary>
        public string IND_VENDA { get; set; }
        
        /// <summary>
        /// Indica se é para gerar cobranca
        /// </summary>
        public string IND_GERA_COBRANCA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do tipo do titulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
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
            [StringLength(240)]
        /// <summary>
        /// Descricao completa
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica se Debito ou Credito
        /// </summary>
        public string DEBITO_CREDITO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// descricao resumida
        /// </summary>
        public string DESC_RESUMIDA { get; set; }

    }
}
