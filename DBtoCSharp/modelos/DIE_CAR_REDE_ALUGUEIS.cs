
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_REDE_ALUGUEIS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_REDE_ALUGUEIS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// Tipo de Registo ('035')
        /// </summary>
        public int TIPO_REGISTRO { get; set; }
        
        /// <summary>
        /// Número do PV ajustado
        /// </summary>
        public int NUM_PV { get; set; }
        
        /// <summary>
        /// Número do RV ajustado
        /// </summary>
        public int NUM_RV { get; set; }
        
        /// <summary>
        /// Data do Ajuste
        /// </summary>
        public string DATA_AJUSTE { get; set; }
        
        /// <summary>
        /// Valor do Ajuste
        /// </summary>
        public int VLR_AJUSTE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 'D' (Débito)
        /// </summary>
        public string DEBITO { get; set; }
        
        /// <summary>
        /// Indicador de Débito
        /// </summary>
        public int IND_DEBITO { get; set; }
            [StringLength(28)]
        /// <summary>
        /// Identifica o motivo que originou o ajuste
        /// </summary>
        public string MOTIVO_AJUSTE { get; set; }
        
        /// <summary>
        /// Número do Cartão(Tabela III)
        /// </summary>
        public int NUM_CARTAO { get; set; }
        
        /// <summary>
        /// Data da Transação 'CV'
        /// </summary>
        public string DATA_TRANSACAO { get; set; }
        
        /// <summary>
        /// Número do RV original
        /// </summary>
        public int NUM_ORIG_RV { get; set; }
            [StringLength(15)]
        /// <summary>
        /// Número de Referência da carta/fax
        /// </summary>
        public string NUM_REFERENCIA { get; set; }
        
        /// <summary>
        /// Data da Carta
        /// </summary>
        public string DATA_CARTA { get; set; }
        
        /// <summary>
        /// Mês de Referência (serviços, POS)
        /// </summary>
        public int MES_REFERENCIA { get; set; }
        
        /// <summary>
        /// Número PV original
        /// </summary>
        public int NUM_ORIG_PV { get; set; }
        
        /// <summary>
        /// Data RV original
        /// </summary>
        public string DATA_ORIG_RV { get; set; }
        
        /// <summary>
        /// Valor da Transação
        /// </summary>
        public int VLR_TRANSACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// D(Desagendamento) ou N(Net)
        /// </summary>
        public string DESAGENDAMENTO { get; set; }
        
        /// <summary>
        /// Data do Crédito
        /// </summary>
        public string DATA_CREDITO { get; set; }
        
        /// <summary>
        /// Novo valor da parcela
        /// </summary>
        public int VLR_NOVO_PARCELA { get; set; }
        
        /// <summary>
        /// Valor original da parcela
        /// </summary>
        public int VLR_ORIG_PARCELA { get; set; }
        
        /// <summary>
        /// Valor bruto do Resumo de Vendas original
        /// </summary>
        public int VLR_BRUTO { get; set; }
        
        /// <summary>
        /// Valor do cancelamento solicitado
        /// </summary>
        public int VLR_CANCELADO { get; set; }
        
        /// <summary>
        /// Número do NSU
        /// </summary>
        public int NSU { get; set; }
            [StringLength(6)]
        /// <summary>
        /// Número da Autorização
        /// </summary>
        public string NUM_AUTORIZACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Tipo de Débito
        /// </summary>
        public string TIPO_DEBITO { get; set; }
        
        /// <summary>
        /// Número da Ordem de Débito
        /// </summary>
        public int ORDEM_DEBITO { get; set; }
        
        /// <summary>
        /// Valor do Dèbito Total
        /// </summary>
        public int VLR_DEBITO_TOTAL { get; set; }
        
        /// <summary>
        /// Valor Pendente
        /// </summary>
        public int VLR_PENDENTE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Bandeiro do RV de origem
        /// </summary>
        public string BANDEIRA_ORIG_RV { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Bandeiro do RV ajustado
        /// </summary>
        public string BANDEIRA_AJUS_RV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }

    }
}
