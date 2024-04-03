
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_FORMA_PAGAMENTO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
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
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_FORMA_PGTO { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// Descricao resumida da forma de pagamento (relatorios)
        /// </summary>
        public string DESC_RESUMIDO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Quebra - usado em relatorios
        /// </summary>
        public string QUEBRA { get; set; }
            [Required]
        /// <summary>
        /// Codigo da forma de pagamento
        /// </summary>
        public int COD_FORMA_PAGTO { get; set; }
        
        /// <summary>
        /// Mensagem ref. instrucoes para cartorio
        /// </summary>
        public int BEG_GER_MENSAGEM_ID { get; set; }
        
        /// <summary>
        /// Mensagem extra
        /// </summary>
        public int BEG_VW_GER_MSG_EX_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que os dados bancarios da pessoa s?o obrigatorios na utilizac?o desta forma de pagamento
        /// </summary>
        public string IND_OBRIGA_DADOS_BANCARIOS { get; set; }
        
        /// <summary>
        /// Numero de dias de protesto
        /// </summary>
        public int DIAS_PROTESTO { get; set; }
        
        /// <summary>
        /// codigo de protesto 1.protestar dias corridos 2.protestar dias uteis e 3.nao protestar
        /// </summary>
        public int COD_PROTESTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string GERAR_TITULO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PAGAR_COMISSAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Utilizado na venda cartao para indicar ao tef parcelamento estabelecimento ou adm
        /// </summary>
        public string TIPOFI { get; set; }
        
        /// <summary>
        /// Percentual de desconto adicional para aprovacao de pedidos do simulador pela forma de pagto
        /// </summary>
        public int PERC_DESC_FORMA_PGTO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_VEN_FORMA_PGTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  :new.DESC_FORMA_PGTO := UPPER(:new.DESC_FORMA_PGTO);\n\n  if :new.GERAR_TITULO = 'N' then\n    :new.PAGAR_COMISSAO := 'N';\n  end if;\n\nend TRG_BIU_BEG_VEN_FORMA_PGTO;\n"}`;
    
    }
}
