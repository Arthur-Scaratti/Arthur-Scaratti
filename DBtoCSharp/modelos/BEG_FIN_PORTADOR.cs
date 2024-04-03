
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_PORTADOR
    {
            [StringLength(1)]
        /// <summary>
        /// Indica que a conta deste portador aceita movimentacao
        /// </summary>
        public string IND_ACEITA_MOVTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica que o deposito para este portador requer o nr do envelope
        /// </summary>
        public string IND_NR_ENVELOPE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do portador
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
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
        /// Codigo do Portador
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica vendor
        /// </summary>
        public string IND_VENDOR { get; set; }
        
        /// <summary>
        /// Id da conta corrente
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
        
        /// <summary>
        /// Id do banco
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// id da Agencia
        /// </summary>
        public int BEG_AGENCIA_ID { get; set; }
            [Required]
        /// <summary>
        /// Indica emissao de boleto
        /// </summary>
        public string IND_BOLETO { get; set; }
            [Required]
        /// <summary>
        /// Indica cobranca escritural
        /// </summary>
        public string IND_COBR_ESCR { get; set; }
        
        /// <summary>
        /// Indica pagamento escritural
        /// </summary>
        public string IND_PGTO_ESCR { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// Descrição do Portador
        /// </summary>
        public string NAME { get; set; }

    }
}
