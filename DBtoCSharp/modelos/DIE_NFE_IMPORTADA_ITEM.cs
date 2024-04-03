
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NFE_IMPORTADA_ITEM
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int CST_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CLASSE_ENQ_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Sequencial do iten na nota
        /// </summary>
        public int SEQUENCIA { get; set; }
            [Required]
        /// <summary>
        /// Quantidade do item
        /// </summary>
        public int QTD { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Descric?o do item no fornecedor
        /// </summary>
        public string DES_ITEM_FORNECEDOR { get; set; }
            [Required]
        /// <summary>
        /// Valor unitario do item
        /// </summary>
        public int VLR_UNITARIO { get; set; }
            [Required]
        /// <summary>
        /// Valor total digitado do item
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [Required]
        /// <summary>
        /// Valor total calculado do item
        /// </summary>
        public int VLR_TOTAL_CALC { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do ICMS
        /// </summary>
        public int ALQ_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo de outros do ICMS
        /// </summary>
        public int ALQ_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do ICMS da substituic?o tributaria
        /// </summary>
        public int ALQ_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor digitado da base de calculo do ICMS
        /// </summary>
        public int VLR_BASE_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor calculado da base de calculo do ICMS
        /// </summary>
        public int VLR_BASE_ICMS_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor da base de calculo de outros do ICMS
        /// </summary>
        public int VLR_BASE_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor digitado da base de calculo do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_BASE_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor calculado da base de calculo do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_BASE_ICMS_SUBST_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor da base de calculo isenta do ICMS
        /// </summary>
        public int VLR_BASE_ISENTO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor digitado do ICMS
        /// </summary>
        public int VLR_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor calculado do ICMS
        /// </summary>
        public int VLR_ICMS_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor de outros do ICMS
        /// </summary>
        public int VLR_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Valor digitado do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Valor calculado do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_ICMS_SUBST_CALC { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do IPI
        /// </summary>
        public int ALQ_IPI { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo de outros do IPI
        /// </summary>
        public int ALQ_OUTROS_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor digitado da base de calculo do IPI
        /// </summary>
        public int VLR_BASE_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor calculado da base de calculo do IPI
        /// </summary>
        public int VLR_BASE_IPI_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor da base de calculo de outros do IPI
        /// </summary>
        public int VLR_BASE_OUTROS_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor da base de calculo isenta do IPI
        /// </summary>
        public int VLR_BASE_ISENTO_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor digitado do IPI
        /// </summary>
        public int VLR_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor calculado do IPI
        /// </summary>
        public int VLR_IPI_CALC { get; set; }
            [Required]
        /// <summary>
        /// Valor de outros do IPI
        /// </summary>
        public int VLR_OUTROS_IPI { get; set; }
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
        /// Valor do frete
        /// </summary>
        public int VLR_FRETE { get; set; }
            [Required]
        /// <summary>
        /// Valor do frete de redespacho
        /// </summary>
        public int VLR_FRETE_RDP { get; set; }
            [Required]
        /// <summary>
        /// Quantidade de volumes
        /// </summary>
        public int QTD_VOLUMES { get; set; }
            [Required]
        /// <summary>
        /// Peso bruto dos volumes
        /// </summary>
        public int PESO_BRUTO { get; set; }
            [Required]
        /// <summary>
        /// Peso liquido dos volumes
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
            [Required]
        /// <summary>
        /// Valor do seguro
        /// </summary>
        public int VLR_SEGURO { get; set; }
            [Required]
        /// <summary>
        /// Valor de despesas financeiras
        /// </summary>
        public int VLR_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
        /// <summary>
        /// Valor de outras despesas acessorias
        /// </summary>
        public int VLR_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto
        /// </summary>
        public int PER_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Valor de desconto
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// Percentual de acrescimo
        /// </summary>
        public int PER_ACRESCIMO { get; set; }
            [Required]
        /// <summary>
        /// Valor de acrescimo
        /// </summary>
        public int VLR_ACRESCIMO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica frete na nota
        /// </summary>
        public string IND_FRETE_NOTA { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Observac?o do item da nota fiscal de entrada
        /// </summary>
        public string OBS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observac?o de outras despesas do item da nota fiscal de entrada
        /// </summary>
        public string OBS_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// ID da nota fiscal de entrada
        /// </summary>
        public int DIE_NFE_IMPORTADA_ID { get; set; }
        
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// ID do SKU do produto
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// ID do CFOP (Codigo Fiscal de Operac?es e Prestac?es) de entrada do item
        /// </summary>
        public int BEG_VW_CFOP_ENT_ID { get; set; }
        
        /// <summary>
        /// ID do CFOP (Codigo Fiscal de Operac?es e Prestac?es) de saida do item
        /// </summary>
        public int BEG_VW_CFOP_SAI_ID { get; set; }
        
        /// <summary>
        /// ID da NCM (Nomenclatura Comum do Mercosul) do item (classificac?o fiscal)
        /// </summary>
        public int BEG_PRD_NCM_ID { get; set; }
        
        /// <summary>
        /// ID da situac?o tributaria do ICMS do item
        /// </summary>
        public int BEG_FIS_TRIB_ICMS_ID { get; set; }
        
        /// <summary>
        /// ID da origem da mercaddoria
        /// </summary>
        public int BEG_FIS_ORIGEM_MERC_ID { get; set; }
        
        /// <summary>
        /// ID do almoxarifado do produto
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o desconto diminui o total do item
        /// </summary>
        public string IND_DESCONTO_ITEM { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o acrescimo aumenta o total do item
        /// </summary>
        public string IND_ACRESCIMO_ITEM { get; set; }
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
        /// ID da formula do calculo do custo
        /// </summary>
        public int BEG_CST_CALCULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Valor calculado na nota fiscal de entrada como base para sugest?o
        /// </summary>
        public int VLR_APURADO { get; set; }
            [Required]
        /// <summary>
        /// Valor sugerido na entrada da nota fiscal
        /// </summary>
        public int VLR_SUGERIDO { get; set; }
            [Required]
        /// <summary>
        /// Preco de venda vigente na ocasi?o da entrada da mercadoria utilizado para calculo da variac?o
        /// </summary>
        public int VLR_VIGENTE { get; set; }
            [Required]
        /// <summary>
        /// Margem utilizada para sugest?o
        /// </summary>
        public int ALQ_MARGEM { get; set; }
            [Required]
        /// <summary>
        /// Percentual de variac?o do preco vigente para o preco sugerido
        /// </summary>
        public int PER_VARIACAO { get; set; }
        
        /// <summary>
        /// ID da nota fiscal de origem em caso de devolucoes
        /// </summary>
        public int BEG_VW_NF_ORIGEM_ID { get; set; }
        
        /// <summary>
        /// ID do item da nota fiscal de origem em caso de devolucoes
        /// </summary>
        public int BEG_VW_NF_ORIGEM_ITEM_ID { get; set; }
        
        /// <summary>
        /// ID do movimento do estoque
        /// </summary>
        public int BEG_EST_MOVTO_ESTOQUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CST_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CST_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CST_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_REDUCAO_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PISCOFINS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do item da nota fiscal de entrada
        /// </summary>
        public int DIE_NFE_IMPORTADA_ITEM_ID { get; set; }
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

    }
}
