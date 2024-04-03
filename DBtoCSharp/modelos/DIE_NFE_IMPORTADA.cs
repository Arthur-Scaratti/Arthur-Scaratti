
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NFE_IMPORTADA
    {
            [StringLength(28)]
        /// <summary>
        /// 
        /// </summary>
        public string DIGEST_VALUE { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string HR_AUTORIZACAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Numero da fatura da nota fiscal de entrada
        /// </summary>
        public string NRO_FATURA { get; set; }
        
        /// <summary>
        /// Quantidade de parcelas
        /// </summary>
        public int QTD_PARCELAS { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Quantidade de dias para vencimento das parcelas
        /// </summary>
        public string DIAS_VENCIMENTO { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status da nota fiscal de entrada: WC - Aguardando confirmac?o (Waiting Confirmation) / WP - Aguardando pagamento de TODOS os titulos/parcelas (Waiting Payment) / PA - TODOS os titulos/parcelas pagos (PAyed) / CO - Processamento completo e nota n?o possui titulos ( COmpleted) / CA - Nota cancelada (CAnceled)
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se foram gerados titulos do contas a pagar
        /// </summary>
        public string IND_TITULO_CPG { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que gerou autorizac?es de pagamento do contas a pagar
        /// </summary>
        public string IND_AUT_PGTO_CPG { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica nota fiscal especial
        /// </summary>
        public string IND_ESPECIAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica frete na nota
        /// </summary>
        public string IND_FRETE_NOTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se a nota foi gerada por uma ou mais ordens de compra
        /// </summary>
        public string IND_NFE_ORDEM { get; set; }
            [Required]
        /// <summary>
        /// Numero da via que foi impressa
        /// </summary>
        public int NRO_VIA_IMPRESSA { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observac?o da nota fiscal de entrada
        /// </summary>
        public string OBS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observac?o da despesa da nota fiscal de entrada
        /// </summary>
        public string OBS_OUTRAS_DESPESAS { get; set; }
        
        /// <summary>
        /// ID do fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// ID do CFOP (Codigo Fiscal de Operac?es e Prestac?es) de entrada da nota
        /// </summary>
        public int BEG_VW_CFOP_ENT_ID { get; set; }
        
        /// <summary>
        /// ID do CFOP (Codigo Fiscal de Operac?es e Prestac?es) de saida da nota
        /// </summary>
        public int BEG_VW_CFOP_SAI_ID { get; set; }
        
        /// <summary>
        /// ID do almoxarifado
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// ID da transportadora
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// ID da unidade de medida
        /// </summary>
        public int BEG_PRD_UNIDADE_ID { get; set; }
        
        /// <summary>
        /// ID da transportadora de redespacho
        /// </summary>
        public int BEG_VW_REDESPACHO_ID { get; set; }
        
        /// <summary>
        /// ID da UF da placa do transporte de frete
        /// </summary>
        public int BEG_UF_ID { get; set; }
        
        /// <summary>
        /// ID da UF da placa do transporte de redespacho
        /// </summary>
        public int BEG_VW_UF_RDP_ID { get; set; }
        
        /// <summary>
        /// ID da condic?o de pagamento
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID da condic?o de pagamento para NFE especial
        /// </summary>
        public int BEG_VW_CPR_CND_PGTO_NFE_ID { get; set; }
        
        /// <summary>
        /// ID da forma de pagamento
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID do banco
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// ID da moeda
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o desconto diminui o total da nota
        /// </summary>
        public string IND_DESCONTO_NOTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o acrescimo aumenta o total da nota
        /// </summary>
        public string IND_ACRESCIMO_NOTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o desconto diminui a base de ICMS / ICMS subst. trib.
        /// </summary>
        public string IND_DESCONTO_BASE_ICMS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o acrescimo aumenta a base de ICMS / ICMS subst. trib.
        /// </summary>
        public string IND_ACRESCIMO_BASE_ICMS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o desconto diminui a base de IPI
        /// </summary>
        public string IND_DESCONTO_BASE_IPI { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o acrescimo aumenta a base de IPI
        /// </summary>
        public string IND_ACRESCIMO_BASE_IPI { get; set; }
        
        /// <summary>
        /// Diementz - valor pago pelo cliente ref. devolucao  - 07/01/2009 - AOK
        /// </summary>
        public int VLR_PAGO_NF_DEVOL { get; set; }
            [Required]
        /// <summary>
        /// Diementz - Indica se encontrou duplicara na devolução
        /// </summary>
        public string IND_DUP_DEVOL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Diementz - Tipo de venda nf devolucao
        /// </summary>
        public string TP_VENDA_DEVOL { get; set; }
        
        /// <summary>
        /// tipo da nota fiscal de entrada
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// ID da conta contabil
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica tipo da devolução P-parcial, T-total
        /// </summary>
        public string TP_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// id motivo da devolução
        /// </summary>
        public int DIE_MOTIVO_DEVOL_ID { get; set; }
        
        /// <summary>
        /// Id do vendedor da nf que esta sendo devolvida
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
        
        /// <summary>
        /// valor ref. devolucao por recolhimento, onde é abatido do total da NF ( devcli->vlpago)
        /// </summary>
        public int VALORPAGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_REDUCAO_ICMS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXCLUI_TODOS_ITENS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXCLUI_ITENS_INATIVOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROTOCOLO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// Para  a soma dos totais do PIS/COFINS lançados nas obrigaçõe
        /// </summary>
        public int VLR_TOTAL_PISCOFINS { get; set; }
            [Required]
    [StringLength(45)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_ACESSO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROTOCOLO_AUTORIZACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_AUTORIZACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CONSULTA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS_CONSULTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INCLUSAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string INCLUIDA { get; set; }
            [Required]
        /// <summary>
        /// Percentual total de desconto
        /// </summary>
        public int PER_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Valor total de desconto
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Percentual total de acrescimo
        /// </summary>
        public int PER_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// Valor total de acrescimo
        /// </summary>
        public int VLR_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado dos produtos
        /// </summary>
        public int VLR_TOTAL_PRODUTOS { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado dos produtos
        /// </summary>
        public int VLR_TOTAL_PRODUTOS_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado da nota fiscal de entrada
        /// </summary>
        public int VLR_TOTAL_NOTA { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado da nota fiscal de entrada
        /// </summary>
        public int VLR_TOTAL_NOTA_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total faturado da nota fiscal de entrada
        /// </summary>
        public int VLR_TOTAL_FATURADO { get; set; }
            [Required]
        /// <summary>
        /// Valor da cotac?o da moeda
        /// </summary>
        public int VLR_COTACAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da nota fiscal de entrada
        /// </summary>
        public int DIE_NFE_IMPORTADA_ID { get; set; }
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
        /// <summary>
        /// Numero da nota fiscal de entrada
        /// </summary>
        public int NUMERO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Serie da nota fiscal de entrada
        /// </summary>
        public string SERIE { get; set; }
            [Required]
        /// <summary>
        /// Data de emiss?o da nota fiscal de entrada
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Data de entrada da nota fiscal de entrada
        /// </summary>
        public string DT_ENTRADA { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado da base de calculo do ICMS
        /// </summary>
        public int VLR_BASE_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado da base de calculo do ICMS
        /// </summary>
        public int VLR_BASE_ICMS_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo de outros do ICMS
        /// </summary>
        public int VLR_BASE_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado da base de calculo do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_BASE_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado da base de calculo do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_BASE_ICMS_SUBST_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo isenta do ICMS
        /// </summary>
        public int VLR_BASE_ISENTO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado do ICMS
        /// </summary>
        public int VLR_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado do ICMS
        /// </summary>
        public int VLR_ICMS_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total de outros do ICMS
        /// </summary>
        public int VLR_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_ICMS_SUBST_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado da base de calculo do IPI
        /// </summary>
        public int VLR_BASE_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado da base de calculo do IPI
        /// </summary>
        public int VLR_BASE_IPI_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo de outros do IPI
        /// </summary>
        public int VLR_BASE_OUTROS_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo isenta do IPI
        /// </summary>
        public int VLR_BASE_ISENTO_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado do IPI
        /// </summary>
        public int VLR_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado do IPI
        /// </summary>
        public int VLR_IPI_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor total de outros do IPI
        /// </summary>
        public int VLR_OUTROS_IPI { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do IR
        /// </summary>
        public int ALQ_IR { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo do IR
        /// </summary>
        public int VLR_BASE_IR { get; set; }
            [Required]
        /// <summary>
        /// Valor total do IR
        /// </summary>
        public int VLR_IR { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do INSS
        /// </summary>
        public int ALQ_INSS { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo do INSS
        /// </summary>
        public int VLR_BASE_INSS { get; set; }
            [Required]
        /// <summary>
        /// Valor total do INSS
        /// </summary>
        public int VLR_INSS { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do ISSQN
        /// </summary>
        public int ALQ_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// Valor total da base de calculo do ISSQN
        /// </summary>
        public int VLR_BASE_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// Valor total do ISSQN
        /// </summary>
        public int VLR_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// Valor total do frete
        /// </summary>
        public int VLR_FRETE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo do frete: C - CIF / F - FOB / R - Retira / A - A Combinar
        /// </summary>
        public string TP_FRETE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Placa do veiculo do frete
        /// </summary>
        public string PLACA_VEICULO { get; set; }
            [Required]
        /// <summary>
        /// Valor total do frete de redespacho
        /// </summary>
        public int VLR_FRETE_RDP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Tipo do frete de redespacho: C - CIF / F - FOB / R - Retira / A - A Combinar
        /// </summary>
        public string TP_FRETE_RDP { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Placa do veiculo do frete de redespacho
        /// </summary>
        public string PLACA_VEICULO_RDP { get; set; }
            [Required]
        /// <summary>
        /// Quantidade total de volumes
        /// </summary>
        public int QTD_VOLUMES { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Descric?o (marca) dos volumes
        /// </summary>
        public string DES_VOLUMES { get; set; }
        
        /// <summary>
        /// Numero dos volumes
        /// </summary>
        public int NRO_VOLUMES { get; set; }
            [Required]
        /// <summary>
        /// Peso bruto total dos volumes
        /// </summary>
        public int PESO_BRUTO { get; set; }
            [Required]
        /// <summary>
        /// Peso liquido total dos volumes
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
            [Required]
        /// <summary>
        /// Valor total do seguro
        /// </summary>
        public int VLR_SEGURO { get; set; }
            [Required]
        /// <summary>
        /// Valor de despesas financeiras
        /// </summary>
        public int VLR_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
        /// <summary>
        /// Valor total de outras despesas acessorias
        /// </summary>
        public int VLR_OUTRAS_DESPESAS { get; set; }

    }
}
