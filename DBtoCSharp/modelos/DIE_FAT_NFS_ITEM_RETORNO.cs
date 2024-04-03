
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_NFS_ITEM_RETORNO
    {
            [StringLength(20)]
        /// <summary>
        /// Nr do GTIN
        /// </summary>
        public string EAN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_DEVOLUCAO_ITEM_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Codigo do beneficio Fiscal da ST
        /// </summary>
        public string CBENEF { get; set; }
        
        /// <summary>
        /// Valor do ICMS da operacao
        /// </summary>
        public int VICMSOP { get; set; }
        
        /// <summary>
        /// Percentual de diferimento do ICMS
        /// </summary>
        public int PDIF { get; set; }
        
        /// <summary>
        /// Valor do ICMS diferido
        /// </summary>
        public int VICMSDIF { get; set; }
        
        /// <summary>
        /// Data de emiss?o
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Quantidade do item
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// Será usado para controlar a recarga de celular
        /// </summary>
        public int QTDE_ATENDIDA { get; set; }
        
        /// <summary>
        /// Valor do item
        /// </summary>
        public int VL_UNITARIO { get; set; }
        
        /// <summary>
        /// Custo do produto na data de venda
        /// </summary>
        public int VL_CUSTO_PRODUTO { get; set; }
        
        /// <summary>
        /// Custo financeiro
        /// </summary>
        public int VL_CUSTO_FINANCEIRO { get; set; }
        
        /// <summary>
        /// Valor de desconto proporcional do item
        /// </summary>
        public int VL_DESCONTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Descric?o tecnica do item. N?o necessariamente sera igual a do item
        /// </summary>
        public string DESC_TECNICA_ITEM { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Gera reserva do estroque (s;n)
        /// </summary>
        public string GERA_RESERVA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observac?o
        /// </summary>
        public string OBS_LINHA_NFS { get; set; }
        
        /// <summary>
        /// Percentual do icms
        /// </summary>
        public int PERC_ICMS { get; set; }
        
        /// <summary>
        /// Percentual de reduc?o
        /// </summary>
        public int PERC_REDUCAO { get; set; }
        
        /// <summary>
        /// Valor do icms do item
        /// </summary>
        public int VL_ICMS { get; set; }
        
        /// <summary>
        /// Valor de base de calculo do ICMS
        /// </summary>
        public int VL_BASE_CALCULO_ICMS { get; set; }
        
        /// <summary>
        /// Valor de base isenc?o ICMS
        /// </summary>
        public int VL_BASE_ISENTA_ICMS { get; set; }
        
        /// <summary>
        /// Valor de base outros icms
        /// </summary>
        public int VL_BASE_OUTRAS_ICMS { get; set; }
        
        /// <summary>
        /// Percentual de IPI
        /// </summary>
        public int PERC_IPI { get; set; }
        
        /// <summary>
        /// Valor do IPI
        /// </summary>
        public int VL_IPI { get; set; }
        
        /// <summary>
        /// Valor de base calculo IPI
        /// </summary>
        public int VL_BASE_CALCULO_IPI { get; set; }
        
        /// <summary>
        /// Valor de base isenta IPI
        /// </summary>
        public int VL_BASE_ISENTA_IPI { get; set; }
        
        /// <summary>
        /// Valor de base outras IPI
        /// </summary>
        public int VL_BASE_OUTRAS_IPI { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_NFS_ITEM_RETORNO_ID { get; set; }
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
        
        /// <summary>
        /// Numero da nota fiscal de saida
        /// </summary>
        public int NRO_NFS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Serie da nota fiscal de saida
        /// </summary>
        public string SERIE_NFS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PREDBCEFET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VBCEFET { get; set; }
        
        /// <summary>
        /// Valor do icms por subtituicao tributaria
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// Valor base da substituic?o tributaria
        /// </summary>
        public int VL_BASE_SUBST_TRIB { get; set; }
        
        /// <summary>
        /// Valor proporcional do frete para o item
        /// </summary>
        public int VL_FRETE_ITEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_ORIGEM_MERC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_PRE_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_NFS_RET_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_TRIB_ICMS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_MATRIZ_TRIBUTARIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_NCM_ID { get; set; }
        
        /// <summary>
        /// Aliquota do Cofins
        /// </summary>
        public int ALIQ_COFINS { get; set; }
        
        /// <summary>
        /// Aliquota icms subst
        /// </summary>
        public int ALIQ_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// Aliquota do Pis
        /// </summary>
        public int ALIQ_PIS { get; set; }
        
        /// <summary>
        /// Almoxarifado
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// CST COFINS
        /// </summary>
        public string CST_COFINS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// CST PIS
        /// </summary>
        public string CST_PIS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// CST IPI
        /// </summary>
        public string CST_IPI { get; set; }
        
        /// <summary>
        /// Peso Bruto
        /// </summary>
        public int PESO_BRUTO { get; set; }
        
        /// <summary>
        /// Peso Liquido
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
        
        /// <summary>
        /// Valor base calculo COFINS
        /// </summary>
        public int VL_BASE_CALCULO_COFINS { get; set; }
        
        /// <summary>
        /// Valor base calculo PIS
        /// </summary>
        public int VL_BASE_CALCULO_PIS { get; set; }
        
        /// <summary>
        /// Valor COFINS
        /// </summary>
        public int VL_COFINS { get; set; }
        
        /// <summary>
        /// Valor PIS
        /// </summary>
        public int VL_PIS { get; set; }
        
        /// <summary>
        /// Valor Bruto item
        /// </summary>
        public int VL_BRUTO_ITEM { get; set; }
        
        /// <summary>
        /// Valor ICMS Frete item
        /// </summary>
        public int VL_ICMS_FRETE { get; set; }
        
        /// <summary>
        /// % MVA Original
        /// </summary>
        public int PERC_MVAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_CTRL_NF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VBCUFDEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PFCPUDEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PICMSUFDEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PICMSINTER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PICMSINTERPART { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VFCPUFDEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VICMSUFDEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VICMSUFREMET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ITEPED_ID { get; set; }
            [Required]
        /// <summary>
        /// Numero sequencial do item 
        /// </summary>
        public int NR_ITEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MODALIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MODALIDADEST { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// nao usar este. Foi criado coluna EAN
        /// </summary>
        public string EAN13 { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_DETALHADA { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_ONU { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CEST { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPI { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string GENERO { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CFOP { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string UM_VENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_BRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_SEGURO_ITEM { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ORIGEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_SUBS_TRIB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ICMS_TRIB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RED_BASE_CALC_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_IPI { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SIT_TRIB_PIS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SIT_TRIB_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_VLR_BASE_CALCULO_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VN_VLR_BASE_CALC_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TRIB_APROX { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica o tipo de habilitacao: 1-Pré-pago, 2-Pós-pago
        /// </summary>
        public string PLANO_CEL { get; set; }
        
        /// <summary>
        /// Subgrupo de produtos a que pertence o item
        /// </summary>
        public int DIE_PRD_SUBGRUPO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PICMSEFET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VICMSEFET { get; set; }

    }
}
