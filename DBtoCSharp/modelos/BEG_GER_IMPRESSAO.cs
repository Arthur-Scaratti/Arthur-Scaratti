
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_IMPRESSAO
    {
        
        /// <summary>
        /// Data Final
        /// </summary>
        public string DT_FINAL { get; set; }
        
        /// <summary>
        /// Id do parceiro Comercial
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Situacao Titulo (A)berto (E)ncerrado
        /// </summary>
        public string SIT_TITULO { get; set; }
        
        /// <summary>
        /// Id da filial
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO { get; set; }
        
        /// <summary>
        /// ID DO LOTE DE COBRANCA
        /// </summary>
        public int BEG_COB_LOTE_COBR_ID { get; set; }
        
        /// <summary>
        /// Id da Cidade
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// Id do cobrador
        /// </summary>
        public int BEG_VW_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// Id das regioes de vendas
        /// </summary>
        public int DIE_VEN_REGIAO_ID { get; set; }
        
        /// <summary>
        /// Número da página do catálogo
        /// </summary>
        public int NRO_PAGINA { get; set; }
        
        /// <summary>
        /// ID da classificação comercial
        /// </summary>
        public int BEG_PRD_COMERCIAL_CLASS_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Codigo estruturado do produto
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica produto no relatorio
        /// </summary>
        public string IND_PRODUTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Nome do usuario
        /// </summary>
        public string AD_USER_NAME { get; set; }
        
        /// <summary>
        /// Id do lote de rec. do convenio
        /// </summary>
        public int BEG_VEN_CONV_REC_LOT_ID { get; set; }
        
        /// <summary>
        /// Id do tipo do titulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Mes do nascimento (01,02,03,...,12
        /// </summary>
        public string MES_NASCIMENTO { get; set; }
        
        /// <summary>
        /// Dia do nascimento
        /// </summary>
        public int DIA_NASCIMENTO { get; set; }
        
        /// <summary>
        /// Quantidade de meses inativo
        /// </summary>
        public int QTD_MES_INATIVO { get; set; }
        
        /// <summary>
        /// Reemissao (Y/N)
        /// </summary>
        public string REEMISSAO { get; set; }
        
        /// <summary>
        /// Id do convenio
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// Id do Usuario
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// Data Inicial 
        /// </summary>
        public string DT_INICIAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indicativo utilizado no relatório do catálogo referente a saída do relatório
        /// </summary>
        public string IND_TELA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da tabela auxiliar para impress?o
        /// </summary>
        public int BEG_GER_IMPRESSAO_ID { get; set; }
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
        /// Contador da linha para ordenac?o
        /// </summary>
        public int NRO_LINHA { get; set; }
            [StringLength(88)]
        /// <summary>
        /// Linha formatada para impress?o
        /// </summary>
        public string DES_LINHA { get; set; }
        
        /// <summary>
        /// Texto formatado para impress?o
        /// </summary>
        public string DES_TEXTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica se a autorizac?o de pagamento deve ser impressa junto com a nota
        /// </summary>
        public string IND_AUT_PGTO { get; set; }
        
        /// <summary>
        /// ID da sess?o do Compiere
        /// </summary>
        public int AD_SESSION_ID { get; set; }
        
        /// <summary>
        /// ID da nota fiscal de entrada
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// ID da nota fiscal de entrada especial
        /// </summary>
        public int BEG_VW_CPR_NFE_ESPECIAL_ID { get; set; }
        
        /// <summary>
        /// ID da autorizac?o de pagamento
        /// </summary>
        public int BEG_CPG_AUTORIZACAO_PGTO_ID { get; set; }
        
        /// <summary>
        /// ID da ordem de compra
        /// </summary>
        public int BEG_CPR_ORDEM_ID { get; set; }
        
        /// <summary>
        /// Data de referência
        /// </summary>
        public string DT_REFERENCIA { get; set; }

    }
}
