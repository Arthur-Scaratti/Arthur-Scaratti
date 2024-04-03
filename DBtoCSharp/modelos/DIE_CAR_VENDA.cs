
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_VENDA
    {
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_LANCAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_PARCELA_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Identificacao de transacao realizada pelo ecommerce
        /// </summary>
        public string TID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da tabela
        /// </summary>
        public int DIE_CAR_VENDA_ID { get; set; }
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
        
        /// <summary>
        /// Data da emissão.
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Data do Vencimento.
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// Cliente.
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Número do resumo de venda.
        /// </summary>
        public string NUMERO_RESUMO { get; set; }
        
        /// <summary>
        /// Número da parcela.
        /// </summary>
        public int PARCELA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Número NSU.
        /// </summary>
        public string NSU_BANCO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Código de autorização do TEF.
        /// </summary>
        public string COD_AUTORIZACAO_TEF { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Situação do TEF.
        /// </summary>
        public string SITUACAO_TEF { get; set; }
        
        /// <summary>
        /// Tipo de venda.
        /// </summary>
        public int BEG_CAR_TIPO_VENDA_ID { get; set; }
        
        /// <summary>
        /// Conta corrente do depósito.
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
        
        /// <summary>
        /// Valor da parcela.
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// Valor em aberto.
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// Valor da taxa financeira.
        /// </summary>
        public int VLR_TAXA_FINANCEIRA { get; set; }
        
        /// <summary>
        /// Valor líquido.
        /// </summary>
        public int VLR_LIQUIDO { get; set; }
        
        /// <summary>
        /// Bandeira do Cartão de Crédito.
        /// </summary>
        public int BEG_CAR_BANDEIRA_ID { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VALE { get; set; }

    }
}
