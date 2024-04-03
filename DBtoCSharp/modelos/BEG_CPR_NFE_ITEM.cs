
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_NFE_ITEM
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_COFINS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_PRE_NFS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_PRE_NFS_ITEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_ACRE_TMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_DESC_TMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VBCSTRET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VICMSSUBSTITUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VICMSSTRET { get; set; }
            [StringLength(14)]
        /// <summary>
        /// Nr do GETIN
        /// </summary>
        public string EAN { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CEST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_REDUCAO_VLR_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ST_OC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_ORDEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ITEM_ORDEM_COMPRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPR_ORDEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_MVAST { get; set; }
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
        public int NRO_ADICAO_DI { get; set; }
            [Required]
        /// <summary>
        /// Valor sugerido na entrada da nota fiscal
        /// </summary>
        public int VLR_SUGERIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESP_ACES_IMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_IMPOSTO_IMPORTACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// Valor calculado na nota fiscal de entrada como base para sugest?o
        /// </summary>
        public int VLR_APURADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_UF_ID { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL_DESEMBARACO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_DESEMBARACO_ADUANA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_REGISTRO_DI { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_ACDRAWBACK { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOC_IMPORTACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_IPI_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_PIS_ID { get; set; }
        
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
        /// 
        /// </summary>
        public int CST_PIS { get; set; }
        
        /// <summary>
        /// ID da formula do calculo do custo
        /// </summary>
        public int BEG_CST_CALCULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_CALCULO_PIS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do item da nota fiscal de entrada
        /// </summary>
        public int BEG_CPR_NFE_ITEM_ID { get; set; }
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
        /// Sequencial do iten na nota
        /// </summary>
        public int SEQUENCIA { get; set; }
            [Required]
        /// <summary>
        /// Quantidade do item
        /// </summary>
        public int QTD { get; set; }
            [StringLength(120)]
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
        public int BEG_CPR_NFE_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do SKU do produto
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }

        [NotMapped]
        public string Trigger_BKN_TRG_BIU_COMISSAO_ITEM_NFE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  pragma autonomous_transaction;\n  --\n  cursor C_VALIDA_COMISSAO is\n    select *\n      from BKN_COMISSAO_ITEM I\n     where I.BEG_CPR_NFE_ITEM_ID = :new.BEG_CPR_NFE_ITEM_ID;\n  --\n  R_VALIDA_COMISSAO C_VALIDA_COMISSAO%rowtype;\n  --\n  cursor C_COMISSAO is\n    select ROUND((NVL(I.QTD, 0) * NVL(I.VLR_UNITARIO, 0)) -\n                 NVL(I.VLR_DESCONTO, 0) + NVL(I.VLR_ACRESCIMO, 0),\n                 2) VLR_TOT_ITEM,\n           I.BEG_CPR_NFE_ITEM_ID,\n           ROUND(NVL(I.QTD, 0) * NVL(I.VLR_UNITARIO, 0) -\n                 NVL(I.VLR_DESCONTO, 0),\n                 2) VLR_LIQUIDO,\n           NVL(I.VLR_ACRESCIMO, 0) VL_CUSTO_FINANCEIRO,\n           G.DIE_PRD_GRUPO_ID,\n           G.PERC_COMISSAO,\n           N.BEG_CPR_NFE_ID,\n           N.NUMERO,\n           N.AD_CLIENT_ID,\n           N.AD_ORG_ID,\n           N.DIE_GER_VENDEDOR_ID,\n           N.DT_EMISSAO,\n           N.BEG_EST_TP_ESPECIE_ID,\n           E.SIGLA\n      from BEG_CPR_NFE        N,\n           BEG_CPR_NFE_ITEM   I,\n           BEG_PRODUTO        P,\n           DIE_PRD_GRUPO      G,\n           BEG_EST_TP_ESPECIE E\n     where N.BEG_CPR_NFE_ID = I.BEG_CPR_NFE_ID\n       and I.BEG_PRODUTO_ID = P.BEG_PRODUTO_ID\n       and P.DIE_PRD_GRUPO_ID = G.DIE_PRD_GRUPO_ID\n       and N.BEG_EST_TP_ESPECIE_ID = E.BEG_EST_TP_ESPECIE_ID\n       and N.DIE_GER_VENDEDOR_ID is not null\n       and E.SIGLA = 'DV'\n       and I.BEG_CPR_NFE_ITEM_ID = :new.BEG_CPR_NFE_ITEM_ID;\n  --\n  R_COMISSAO C_COMISSAO%rowtype;\n  --\n  VN_AVISTA       number(17, 4);\n  VN_PRAZO        number(17, 4);\n  VN_VLR_COMISSAO number(17, 4);\n  --\nbegin\n  --\n  IF NOT DELETING THEN\n  open C_COMISSAO;\n  fetch C_COMISSAO\n    into R_COMISSAO;\n  if C_COMISSAO%found then\n    --\n    VN_AVISTA := R_COMISSAO.VLR_LIQUIDO;\n    --\n    VN_VLR_COMISSAO := NVL(VN_VLR_COMISSAO, 0) +\n                       ((NVL(R_COMISSAO.VLR_TOT_ITEM, 0) *\n                        R_COMISSAO.PERC_COMISSAO) / 100);\n    --\n    open C_VALIDA_COMISSAO;\n    fetch C_VALIDA_COMISSAO\n      into R_VALIDA_COMISSAO;\n    if C_VALIDA_COMISSAO%found then\n      update BKN_COMISSAO_ITEM NFS\n         set NFS.VLR_ITEM         = R_COMISSAO.VLR_TOT_ITEM,\n             NFS.VLR_COMISSAO     = NVL(VN_VLR_COMISSAO, 0),\n             NFS.VLR_AVISTA       = NVL(VN_AVISTA, 0),\n             NFS.VLR_PRAZO        = NVL(VN_PRAZO, 0),\n             NFS.DIE_PRD_GRUPO_ID = R_COMISSAO.DIE_PRD_GRUPO_ID\n       where NFS.BEG_CPR_NFE_ITEM_ID = :new.BEG_CPR_NFE_ITEM_ID;\n    else\n      --\n      VN_AVISTA := R_COMISSAO.VLR_LIQUIDO;\n      --\n      VN_VLR_COMISSAO := NVL(VN_VLR_COMISSAO, 0) +\n                         ((NVL(R_COMISSAO.VLR_TOT_ITEM, 0) *\n                          R_COMISSAO.PERC_COMISSAO) / 100);\n      --\n      insert into BKN_COMISSAO_ITEM\n        (BKN_COMISSAO_ITEM_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         value,\n         DIE_GER_VENDEDOR_ID,\n         BEG_CPR_NFE_ID,\n         BEG_CPR_NFE_ITEM_ID,\n         DIE_PRD_GRUPO_ID,\n         VLR_ITEM,\n         VLR_COMISSAO,\n         PERC_COMISSAO,\n         VLR_AVISTA,\n         VLR_PRAZO,\n         VLR_TX_FINANCEIRA)\n      values\n        (BEG_FNC_AD_SEQUENCE('BKN_COMISSAO_ITEM'),\n         R_COMISSAO.AD_CLIENT_ID,\n         R_COMISSAO.AD_ORG_ID,\n         'Y',\n         sysdate,\n         1000000,\n         sysdate,\n         1000000,\n         R_COMISSAO.NUMERO,\n         R_COMISSAO.DIE_GER_VENDEDOR_ID,\n         :new.BEG_CPR_NFE_ID,\n         :new.BEG_CPR_NFE_ITEM_ID,\n         R_COMISSAO.DIE_PRD_GRUPO_ID,\n         R_COMISSAO.VLR_TOT_ITEM,\n         ROUND(VN_VLR_COMISSAO, 2),\n         R_COMISSAO.PERC_COMISSAO,\n         NVL(VN_AVISTA, 0),\n         NVL(VN_PRAZO, 0),\n         R_COMISSAO.VL_CUSTO_FINANCEIRO -- VALOR TAXA FINANCEIRA\n         );\n      --\n    end if;\n    close C_VALIDA_COMISSAO;\n    --\n  end if;\n  close C_COMISSAO;\n  --\n  ELSE\n    --\n    DELETE FROM bkn_comissao_item WHERE BEG_CPR_NFE_ITEM_ID = :OLD.BEG_CPR_NFE_ITEM_ID;\n    --\n  END IF;\n\n  commit;\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_SKU_00003 { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  if not BEG_FNC_VALIDA_SKU(:new.BEG_PRODUTO_ID, :new.BEG_PRD_SKU_ID) then\n    RAISE_APPLICATION_ERROR(-20001, ' SKU INVÁLIDO PARA O PRODUTO ! ! ! ');\n  end if;\nend;\n\n\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_CPR_NFE_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  VC_MSG_ERRO varchar2(200);\n  --VN_DUMMY                   number;\n  VN_AUX_ALQ  number(18, 4);\n  VN_AUX_BASE number(18, 4);\n  VN_AUX_CALC number(18, 4);\n \n  --  VN_AUX_VLR_ICMS            number(18, 4);\n  VN_VLR_RATEADO          number(18, 4);\n  VC_DOCSTATUS            BEG_CPR_NFE.DOCSTATUS%type;\n  VN_BEG_VW_FORNECEDOR_ID BEG_CPR_NFE.BEG_VW_FORNECEDOR_ID%type;\n  VN_DIE_PRD_GRUPO_ID     DIE_PRD_GRUPO.DIE_PRD_GRUPO_ID%type; \n  VC_IND_GERADA_XML       VARCHAR2(1);\n  VC_CONTRATO_ID          NUMBER(10);\n  --VN_BEG_EST_ALMOXARIFADO_ID BEG_EST_ALMOXARIFADO.BEG_EST_ALMOXARIFADO_ID%type;\n  VN_BEG_CPR_ORDEM_ITEM_ID BEG_CPR_ORDEM_ITEM.BEG_CPR_ORDEM_ITEM_ID%type;\n  VN_QTD_SALDO             BEG_CPR_ORDEM_ITEM.QTD_SALDO%type;\n  VC_VALUE_PRODUTO         BEG_PRODUTO.value%type;\n  VC_DESC_DETALHADA        BEG_PRODUTO.DESC_DETALHADA%type;\n  V_VALOR_BASE_ICMS        BEG_CPR_NFE.VLR_BASE_ICMS%type;\n  VLR_TEMP                 number;\n  --vn_teste                   number(10);\n  VC_IND_FATURAMENTO     BEG_CPR_NFE.IND_EMITIDA_FATURAMENTO%type; -- aok - 22/11/2013\n  VC_IND_CARGA_SIAD      BEG_CPR_NFE.IND_CARGA_SIAD%type; -- aok - 22/11/2013\n  VC_IND_ICMS_TOTAL_NOTA BEG_CPR_NFE.IND_ICMS_TOTAL_NOTA%type; -- aok - 22/11/2013\n  V_COUNT NUMBER;\n  \n  --\nbegin\n  -- Verifica se o item esta inativo\n  if :new.ISACTIVE = 'N' then\n    goto FIM;\n  end if;\n  --\n  if BEG_PCK_CPR_COMPRAS.VB_PROC_ACERTO_ESPECIAL then\n    goto FIM;\n  end if;\n  --\n  ---  CASO NF TIPO ESPECIE CIAP VAI PARA O FINAL \n    select P.DIE_PRD_GRUPO_ID\n      into VN_DIE_PRD_GRUPO_ID\n      from BEG_PRODUTO P \n     where P.BEG_PRODUTO_ID = NVL(:new.BEG_PRODUTO_ID, :old.BEG_PRODUTO_ID);\n   \n  IF VN_DIE_PRD_GRUPO_ID = 1000009 THEN\n    goto FIM;\n  END IF;\n  \n  -- Valida o status da nota (capa)\n  if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE then\n\n    select DOCSTATUS,\n           BEG_VW_FORNECEDOR_ID,\n           IND_EMITIDA_FATURAMENTO, -- aok - 22/11/2013\n           IND_ICMS_TOTAL_NOTA, -- aok - 22/11/2013\n           IND_CARGA_SIAD, -- aok - 22/11/2013\n           IND_GERADA_XML,\n           DIE_FIN_CONTRATOS_ID\n      into VC_DOCSTATUS,\n           VN_BEG_VW_FORNECEDOR_ID,\n           VC_IND_FATURAMENTO, -- aok - 22/11/2013\n           VC_IND_ICMS_TOTAL_NOTA, -- aok - 22/11/2013\n           VC_IND_CARGA_SIAD, -- aok - 22/11/2013\n           VC_IND_GERADA_XML,\n           VC_CONTRATO_ID\n      from BEG_CPR_NFE \n     where BEG_CPR_NFE_ID = NVL(:new.BEG_CPR_NFE_ID, :old.BEG_CPR_NFE_ID);\n\n    if VC_DOCSTATUS <> 'WC'\n       and VC_DOCSTATUS <> 'CA' then\n       IF :NEW.BEG_VW_CFOP_ENT_ID <> :OLD.BEG_VW_CFOP_ENT_ID THEN\n          VC_MSG_ERRO := NULL;\n          GOTO FIM;\n       ELSE\n         VC_MSG_ERRO := 'Somente e possivel alterar notas ainda n?o processadas!';\n         goto FIM;\n       END IF;\n    end if;\n\n  else\n    --\n    VC_IND_FATURAMENTO     := BEG_PCK_CPR_COMPRAS.VC_IND_FATURAMENTO; -- aok - 22/11/2013\n    VC_IND_CARGA_SIAD      := BEG_PCK_CPR_COMPRAS.VC_IND_CARGA_SIAD; -- aok - 22/11/2013\n    VC_IND_ICMS_TOTAL_NOTA := BEG_PCK_CPR_COMPRAS.VC_IND_ICMS_TOTAL_NOTA; -- aok - 22/11/2013\n    --\n  end if;\n  --\n/*  IF NVL(VC_IND_GERADA_XML,'N') = 'Y' THEN\n    goto FIM;\n  END IF;*/\n  --\n  -- Se esta deletando, remove os historicos do item e atualiza os valores na nota\n  if DELETING then\n\n    SELECT COUNT(1)\n      INTO V_COUNT\n      FROM BEG_EST_MOVTO_ESTOQUE E\n     WHERE E.BEG_EST_MOVTO_ESTOQUE_ID = :OLD.BEG_EST_MOVTO_ESTOQUE_ID;\n     \n     IF NVL(V_COUNT,0) > 0 THEN\n       \n       VC_MSG_ERRO := 'Movimento de Estoque ainda não excluido!!'; \n     \n     END IF;   \n\n\n    -- Atualiza ordens vinculadas\n    update BEG_CPR_ORDEM_ITEM ORD_IT\n       set ORD_IT.QTD_ATENDIDA = ORD_IT.QTD_ATENDIDA - :old.QTD\n     where ORD_IT.BEG_CPR_ORDEM_ITEM_ID =\n           (select HIST_IT.BEG_CPR_ORDEM_ITEM_ID\n              from BEG_CPR_HISTORICO_ITEM HIST_IT\n             where HIST_IT.BEG_CPR_NFE_ITEM_ID = :old.BEG_CPR_NFE_ITEM_ID);\n\n    -- Historico da movimntac?o pela ordem de compra\n    delete from BEG_CPR_HISTORICO_ITEM\n     where BEG_CPR_NFE_ITEM_ID = :old.BEG_CPR_NFE_ITEM_ID;\n\n    -- Liberação de Inspeção 14/10/2011 - EBER - Inclusao do codigo de deletação BEG_INS_LIBERACAO_ITEM\n    delete BEG_INS_LIBERACAO_ITEM\n     where BEG_INS_NFE_ITEM_ID in\n           (select BEG_INS_NFE_ITEM_ID\n              from BEG_INS_NFE_ITEM\n             where BEG_CPR_NFE_ITEM_ID = :old.BEG_CPR_NFE_ITEM_ID);\n\n    -- Inspeção 14/10/2011 - EBER - Inclusao do codigo de deletação BEG_INS_NFE_ITEM\n    delete BEG_INS_NFE_ITEM\n     where BEG_CPR_NFE_ITEM_ID = :old.BEG_CPR_NFE_ITEM_ID;\n\n    -- Custo do Produto 14/10/2011 - EBER - Inclusao do codigo de deletação BEG_CST_PRODUTO\n    delete BEG_CST_PRODUTO\n     where BEG_CPR_NFE_ITEM_ID = :old.BEG_CPR_NFE_ITEM_ID;\n\n    if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE then\n\n      BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT := true;\n\n      update BEG_CPR_NFE C\n         set VLR_BASE_ICMS_CALC       = ROUND(VLR_BASE_ICMS_CALC -\n                                              :old.VLR_BASE_ICMS_CALC,\n                                              2),\n             VLR_BASE_OUTROS_ICMS     = VLR_BASE_OUTROS_ICMS -\n                                        :old.VLR_BASE_OUTROS_ICMS,\n             VLR_BASE_ICMS_SUBST_CALC = ROUND(VLR_BASE_ICMS_SUBST_CALC -\n                                              :old.VLR_BASE_ICMS_SUBST_CALC,\n                                              2),\n             VLR_BASE_ISENTO_ICMS     = VLR_BASE_ISENTO_ICMS -\n                                        :old.VLR_BASE_ISENTO_ICMS,\n             VLR_ICMS_CALC            = ROUND(VLR_ICMS_CALC -\n                                              :old.VLR_ICMS_CALC,\n                                              2),\n             VLR_OUTROS_ICMS          = VLR_OUTROS_ICMS -\n                                        :old.VLR_OUTROS_ICMS,\n             VLR_ICMS_SUBST_CALC      = ROUND(VLR_ICMS_SUBST_CALC -\n                                              :old.VLR_ICMS_SUBST_CALC,\n                                              2),\n             VLR_BASE_IPI_CALC        = ROUND(VLR_BASE_IPI_CALC -\n                                              :old.VLR_BASE_IPI_CALC,\n                                              2),\n             VLR_BASE_OUTROS_IPI      = VLR_BASE_OUTROS_IPI -\n                                        :old.VLR_BASE_OUTROS_IPI,\n             VLR_BASE_ISENTO_IPI      = VLR_BASE_ISENTO_IPI -\n                                        :old.VLR_BASE_ISENTO_IPI,\n             VLR_IPI_CALC             = ROUND(VLR_IPI_CALC -\n                                              :old.VLR_IPI_CALC,\n                                              2),\n             VLR_OUTROS_IPI           = VLR_OUTROS_IPI - :old.VLR_OUTROS_IPI,\n             VLR_BASE_ISSQN           = VLR_BASE_ISSQN - :old.VLR_BASE_ISSQN,\n             VLR_ISSQN                = VLR_ISSQN - :old.VLR_ISSQN,\n             ALQ_ISSQN                = ALQ_ISSQN - :old.ALQ_ISSQN,\n             QTD_VOLUMES              = QTD_VOLUMES - :old.QTD_VOLUMES,\n             PESO_BRUTO               = PESO_BRUTO - :old.PESO_BRUTO,\n             PESO_LIQUIDO             = PESO_LIQUIDO - :old.PESO_LIQUIDO,\n             VLR_SEGURO               = VLR_SEGURO - :old.VLR_SEGURO,\n             VLR_TOTAL_PRODUTOS_CALC  = ROUND(VLR_TOTAL_PRODUTOS_CALC -\n                                              :old.VLR_TOTAL_CALC,\n                                              2),\n             VLR_TOTAL_NOTA_CALC      = ROUND(VLR_TOTAL_NOTA_CALC -\n                                              (:old.VLR_TOTAL_CALC +\n                                              :old.VLR_DESPESAS_FINANCEIRAS +\n                                              :old.VLR_OUTRAS_DESPESAS +\n                                              DECODE(:old.IND_FRETE_NOTA,\n                                                      'Y',\n                                                      (:old.VLR_FRETE +\n                                                      :old.VLR_FRETE_RDP),\n                                                      0)),\n                                              2)\n       where BEG_CPR_NFE_ID = :old.BEG_CPR_NFE_ID;\n\n      BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT := false;\n\n    end if;\n\n    goto FIM;\n\n  end if;\n  \n  IF NVL(VC_IND_GERADA_XML,'N') = 'Y' OR VC_CONTRATO_ID IS NOT NULL THEN\n    goto FIM;\n  END IF;  \n\n  -- Se trocou o produto, valida novamente\n  if NVL(:new.BEG_PRODUTO_ID, 0) <> NVL(:old.BEG_PRODUTO_ID, 0)\n     or NVL(:new.BEG_PRD_SKU_ID, 0) <> NVL(:old.BEG_PRD_SKU_ID, 0) then\n    -- Valida produto vs. fornecedor\n    /*    if BEG_FNC_RETORNA_PARAM_GERAL('Compras',\n                                   'Produto',\n                                   'CONSISTE_PRODUTO_FORNECEDOR') = 'Y' then\n\n      VN_DUMMY := 0;\n      for R_FRN in (select BEG_VW_FORNECEDOR_ID\n                      from BEG_VW_SUP_FORNECEDOR\n                     where BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID)\n      loop\n        if R_FRN.BEG_VW_FORNECEDOR_ID = VN_BEG_VW_FORNECEDOR_ID then\n          VN_DUMMY := 0;\n          exit;\n        else\n          VN_DUMMY := VN_DUMMY + 1;\n        end if;\n      end loop;\n\n      if VN_DUMMY > 0 then\n        VC_MSG_ERRO := 'Produto n?o pertence ao fornecedor da nota!';\n        goto FIM;\n      end if;\n    end if;*/\n\n    begin\n      select value,\n             DESC_DETALHADA\n        into VC_VALUE_PRODUTO,\n             VC_DESC_DETALHADA\n        from BEG_PRODUTO\n       where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n\n    exception\n      when NO_DATA_FOUND then\n        VC_MSG_ERRO := 'Produto n?o encontrado!';\n        goto FIM;\n\n    end;\n\n    -- Atualiza campos n?o digitados\n    begin\n      --   select NVL(:NEW.DES_ITEM_FORNECEDOR, PRD.DESC_RESUMIDA),  -- aok - 14/12/2010\n      select SUBSTR(NVL(:new.DES_ITEM_FORNECEDOR, PRD.DESC_RESUMIDA), 1, 50), -- aok - 14/12/2010\n             NVL(:new.BEG_PRD_SKU_ID, SKU.BEG_PRD_SKU_ID),\n             NVL(:new.BEG_FIS_ORIGEM_MERC_ID,\n                 PRD_CTB.BEG_FIS_ORIGEM_MERC_ID),\n             NVL(:new.BEG_PRD_NCM_ID, PRD_CTB.BEG_PRD_NCM_ID)\n        into :new.DES_ITEM_FORNECEDOR,\n             :new.BEG_PRD_SKU_ID,\n             :new.BEG_FIS_ORIGEM_MERC_ID,\n             :new.BEG_PRD_NCM_ID\n        from BEG_PRODUTO      PRD,\n             BEG_PRD_SKU      SKU,\n             BEG_PRD_CONTABIL PRD_CTB\n       where PRD.BEG_PRODUTO_ID = SKU.BEG_PRODUTO_ID\n         and PRD.BEG_PRODUTO_ID = PRD_CTB.BEG_PRODUTO_ID\n         and PRD.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n         and SKU.PADRAO = 'Y';\n\n    exception\n      when NO_DATA_FOUND then\n        VC_MSG_ERRO := 'Produto <' || VC_VALUE_PRODUTO || ' - ' ||\n                       VC_DESC_DETALHADA ||\n                       '> sem SKU padr?o ou informac?o contabil!';\n        goto FIM;\n\n      when TOO_MANY_ROWS then\n        VC_MSG_ERRO := 'Produto <' || VC_VALUE_PRODUTO || ' - ' ||\n                       VC_DESC_DETALHADA ||\n                       '> com SKU padr?o ou informac?o contabil duplicadas!';\n        goto FIM;\n\n    end;\n\n    -- Verifica se restaram campos obrigatorios em branco\n    if NVL(:new.BEG_PRD_SKU_ID, 0) = 0 then\n      VC_MSG_ERRO := 'SKU deve ser informado!';\n      goto FIM;\n    end if;\n\n    -- Inicializa os valores de impostos\n    if NVL(VC_IND_FATURAMENTO, 'N') = 'N'\n       and NVL(VC_IND_CARGA_SIAD, 'N') = 'N' -- aok - 22/11/2013\n     then\n      begin\n        select DECODE(NVL(:new.ALQ_ICMS, 0), 0, P.ALQ_ICMS, :new.ALQ_ICMS),\n               DECODE(NVL(:new.ALQ_ICMS_SUBST, 0),\n                      0,\n                      P.ALQ_ICMS_SUBST,\n                      :new.ALQ_ICMS_SUBST),\n               DECODE(NVL(:new.VLR_ICMS_SUBST_CALC, 0),\n                      0,\n                      P.VLR_ICMS_SUBST,\n                      :new.VLR_ICMS_SUBST_CALC),\n               DECODE(NVL(:new.ALQ_IPI, 0), 0, P.ALQ_IPI, :new.ALQ_IPI),\n               DECODE(NVL(:new.VLR_UNITARIO, 0),\n                      0,\n                      P.VLR_LIQUIDO,\n                      :new.VLR_UNITARIO),\n               DECODE(NVL(:new.PERC_REDUCAO_ICMS, 0), -- aok - 05/11/2010\n                      0,\n                      NVL(P.PERC_REDUCAO_ICMS, 0),\n                      :new.PERC_REDUCAO_ICMS)\n          into :new.ALQ_ICMS,\n               :new.ALQ_ICMS_SUBST,\n               :new.VLR_ICMS_SUBST_CALC,\n               :new.ALQ_IPI,\n               :new.VLR_UNITARIO,\n               :new.PERC_REDUCAO_ICMS -- aok - 05/11/2010\n          from BEG_VW_SUP_PRODUTO P\n         where P.AD_ORG_ID =\n               (select max(AD_ORG_ID)\n                  from BEG_VW_SUP_PRODUTO PP,\n                       BEG_GER_FILIAL     F\n                 where PP.AD_CLIENT_ID = F.AD_CLIENT_ID\n                   and PP.BEG_PRD_SKU_ID = P.BEG_PRD_SKU_ID\n                   and PP.AD_ORG_ID in (F.AD_ORG_ID_GERAL, :new.AD_ORG_ID))\n           and P.ISACTIVE_PRD = 'Y'\n           and P.ISACTIVE_FRN = 'Y'\n           and P.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n           and P.BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID\n           and P.BEG_VW_FORNECEDOR_ID = VN_BEG_VW_FORNECEDOR_ID;\n\n      exception\n        when NO_DATA_FOUND then\n          null;\n\n      end;\n    end if; -- aok - 22/11/2013\n  end if;\n\n  -- Quantidade\n  if NVL(:new.QTD, 0) <= 0 then\n    VC_MSG_ERRO := 'Quantidade zerada ou negativa!';\n    goto FIM;\n  end if;\n\n  -- Valida o CFOP informado\n  if NVL(:new.BEG_VW_CFOP_SAI_ID, 0) <> NVL(:old.BEG_VW_CFOP_SAI_ID, 0)\n     or NVL(:new.BEG_VW_CFOP_ENT_ID, 0) <> NVL(:old.BEG_VW_CFOP_ENT_ID, 0) then\n    if NVL(:new.BEG_VW_CFOP_SAI_ID, 0) > 0\n       or NVL(:new.BEG_VW_CFOP_ENT_ID, 0) > 0 then\n      begin\n        select NVL(:new.BEG_VW_CFOP_SAI_ID, BEG_VW_CFOP_SAI_ID),\n               NVL(:new.BEG_VW_CFOP_ENT_ID, BEG_VW_CFOP_ENT_ID)\n          into :new.BEG_VW_CFOP_SAI_ID,\n               :new.BEG_VW_CFOP_ENT_ID\n          from BEG_CFOP_ENT_SAI\n         where BEG_VW_CFOP_ENT_ID =\n               NVL(:new.BEG_VW_CFOP_ENT_ID, BEG_VW_CFOP_ENT_ID)\n           and BEG_VW_CFOP_SAI_ID =\n               NVL(:new.BEG_VW_CFOP_SAI_ID, BEG_VW_CFOP_SAI_ID)\n             and ind_padrao = 'Y'\n           and ISACTIVE = 'Y';\n\n      exception\n        when TOO_MANY_ROWS then\n          VC_MSG_ERRO := 'CFOPs com relacao duplicada item!';\n          goto FIM;\n\n        when NO_DATA_FOUND then\n          VC_MSG_ERRO := 'CFOPs sem relacao cadastrada!';\n          goto FIM;\n\n      end;\n    elsif NVL(:new.BEG_VW_CFOP_SAI_ID, 0) = 0\n          and NVL(:new.BEG_VW_CFOP_ENT_ID, 0) = 0 then\n      VC_MSG_ERRO := 'Pelo menos um CFOP deve ser informado para o item!';\n      goto FIM;\n    end if;\n  end if;\n\n  -- Se existe historico do item, valida a quantidade\n  if NVL(:old.QTD, 0) <> NVL(:new.QTD, 0) then\n    begin\n      select ORD_IT.BEG_CPR_ORDEM_ITEM_ID,\n             ORD_IT.QTD_SALDO\n        into VN_BEG_CPR_ORDEM_ITEM_ID,\n             VN_QTD_SALDO\n        from BEG_CPR_ORDEM_ITEM     ORD_IT,\n             BEG_CPR_HISTORICO_ITEM HIST_IT\n       where ORD_IT.BEG_CPR_ORDEM_ITEM_ID = HIST_IT.BEG_CPR_ORDEM_ITEM_ID\n         and HIST_IT.BEG_CPR_NFE_ITEM_ID = :new.BEG_CPR_NFE_ITEM_ID;\n\n      if :new.QTD > VN_QTD_SALDO + NVL(:old.QTD, 0) then\n        VC_MSG_ERRO := 'Quantidade maior que o saldo do item na ordem (' ||\n                       TO_CHAR(VN_QTD_SALDO) || ')!';\n        goto FIM;\n      end if;\n\n      update BEG_CPR_ORDEM_ITEM\n         set QTD_ATENDIDA = QTD_ATENDIDA - NVL(:old.QTD, 0) + :new.QTD\n       where BEG_CPR_ORDEM_ITEM_ID = VN_BEG_CPR_ORDEM_ITEM_ID;\n\n    exception\n      when NO_DATA_FOUND then\n        null;\n\n    end;\n  end if;\n\n /* -- Valor unitario\n  if NVL(:new.VLR_UNITARIO, 0) <= 0 then\n    VC_MSG_ERRO := 'Valor unitario zerado ou negativo!';\n    goto FIM;\n  end if;*/\n\n  if NVL(:new.BEG_FIS_ORIGEM_MERC_ID, 0) = 0 then\n    VC_MSG_ERRO := 'Origem da mercadoria deve ser informada!';\n    goto FIM;\n  end if;\n\n  :new.VLR_TOTAL_CALC := ROUND(:new.QTD * :new.VLR_UNITARIO, 2);\n\n  -- Desconto\n  if (NVL(:old.VLR_UNITARIO, 0) <> NVL(:new.VLR_UNITARIO, 0) or\n     NVL(:old.PER_DESCONTO, 0) <> NVL(:new.PER_DESCONTO, 0) or\n     NVL(:old.VLR_DESCONTO, 0) <> NVL(:new.VLR_DESCONTO, 0))\n     and (NVL(:new.PER_DESCONTO, 0) > 0 or NVL(:new.VLR_DESCONTO, 0) > 0) then\n\n    if NVL(:new.VLR_TOTAL, 0) = 0\n       and NVL(:new.VLR_TOTAL_CALC, 0) = 0 then\n\n      if NVL(:new.VLR_DESCONTO, 0) > 0 then\n        :new.PER_DESCONTO := 0;\n      end if;\n\n    else\n\n      if :new.VLR_TOTAL = 0 then\n        VN_AUX_BASE := :new.VLR_TOTAL_CALC;\n      else\n        VN_AUX_BASE := :new.VLR_TOTAL;\n      end if;\n\n      if NVL(:old.PER_DESCONTO, 0) <> NVL(:new.PER_DESCONTO, 0)\n         or NVL(:new.VLR_DESCONTO, 0) = 0 then\n        VN_AUX_ALQ  := :new.PER_DESCONTO;\n        VN_AUX_CALC := 0;\n      else\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :new.VLR_DESCONTO;\n      end if;\n\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n      -- VN_AUX_VLR_ICMS);\n\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do desconto!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do desconto!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de desconto diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.PER_DESCONTO := VN_AUX_ALQ;\n        :new.VLR_DESCONTO := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  -- Acrescimo\n  if (NVL(:old.VLR_TOTAL, 0) <> NVL(:new.VLR_TOTAL, 0) or\n     NVL(:old.VLR_TOTAL_CALC, 0) <> NVL(:new.VLR_TOTAL_CALC, 0) or\n     NVL(:old.PER_ACRESCIMO, 0) <> NVL(:new.PER_ACRESCIMO, 0) or\n     NVL(:old.VLR_ACRESCIMO, 0) <> NVL(:new.VLR_ACRESCIMO, 0))\n     and (NVL(:new.PER_ACRESCIMO, 0) > 0 or NVL(:new.VLR_ACRESCIMO, 0) > 0) then\n\n    if NVL(:new.VLR_TOTAL, 0) = 0\n       and NVL(:new.VLR_TOTAL_CALC, 0) = 0 then\n\n      if NVL(:new.VLR_ACRESCIMO, 0) > 0 then\n        :new.PER_ACRESCIMO := 0;\n      end if;\n\n    else\n\n      if :new.VLR_TOTAL = 0 then\n        VN_AUX_BASE := :new.VLR_TOTAL_CALC;\n      else\n        VN_AUX_BASE := :new.VLR_TOTAL;\n      end if;\n\n      if NVL(:old.PER_ACRESCIMO, 0) <> NVL(:new.PER_ACRESCIMO, 0)\n         or NVL(:new.VLR_ACRESCIMO, 0) = 0 then\n        VN_AUX_ALQ  := :new.PER_ACRESCIMO;\n        VN_AUX_CALC := 0;\n      else\n        VN_AUX_ALQ  := 0;\n        VN_AUX_CALC := :new.VLR_ACRESCIMO;\n      end if;\n\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(VN_AUX_ALQ,\n                                             VN_AUX_BASE,\n                                             VN_AUX_CALC);\n      -- VN_AUX_VLR_ICMS);\n\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do acrescimo!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do acrescimo!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de acrescimo diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.PER_ACRESCIMO := VN_AUX_ALQ;\n        :new.VLR_ACRESCIMO := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if;\n\n  if NVL(:new.VLR_FRETE, 0) = 0\n     and NVL(:new.VLR_FRETE_RDP, 0) = 0 then\n    :new.IND_FRETE_NOTA := 'N';\n  end if;\n\n  if NVL(:new.VLR_DESCONTO, 0) = 0 then\n    :new.IND_DESCONTO_ITEM      := 'N';\n    :new.IND_DESCONTO_BASE_ICMS := 'N';\n    :new.IND_DESCONTO_BASE_IPI  := 'N';\n  end if;\n\n  if NVL(:new.VLR_BASE_ICMS_CALC, 0) = 0\n     and NVL(:new.VLR_BASE_ICMS_SUBST_CALC, 0) = 0 then\n    :new.IND_DESCONTO_BASE_ICMS := 'N';\n  end if;\n\n  if NVL(:new.VLR_ACRESCIMO, 0) = 0 then\n    :new.IND_ACRESCIMO_ITEM      := 'N';\n    :new.IND_ACRESCIMO_BASE_ICMS := 'N';\n    :new.IND_ACRESCIMO_BASE_IPI  := 'N';\n  end if;\n\n  if NVL(:new.VLR_BASE_IPI_CALC, 0) = 0 then\n    :new.IND_ACRESCIMO_BASE_IPI := 'N';\n  end if;\n\n  if :new.IND_ACRESCIMO_ITEM = 'Y' then\n    :new.VLR_TOTAL_CALC := :new.VLR_TOTAL_CALC + :new.VLR_ACRESCIMO;\n  end if;\n\n  if :new.IND_DESCONTO_ITEM = 'Y' then\n    :new.VLR_TOTAL_CALC := :new.VLR_TOTAL_CALC - :new.VLR_DESCONTO;\n  end if;\n\n  if :new.IND_FRETE_NOTA = 'Y'\n     or (:new.VLR_FRETE > 0 and VC_IND_CARGA_SIAD = 'Y') then\n    :new.VLR_TOTAL_CALC := ROUND(:new.VLR_TOTAL_CALC +\n                                 NVL(:new.VLR_FRETE, 0) +\n                                 NVL(:new.VLR_FRETE_RDP, 0),\n                                 2);\n  end if;\n\n  -- ICMS\n  if NVL(:new.ALQ_ICMS, 0) = 0 then\n    :new.VLR_BASE_ICMS_CALC := 0;\n    :new.VLR_ICMS_CALC      := 0;\n  else\n    -- Se digitou nova base ou novo valor, verifica pelos digitados\n    /* Solicitado para n?o fazer mais validac?o.\n    if NVL(:new.VLR_BASE_ICMS, 0) > 0\n       or NVL(:new.VLR_ICMS, 0) > 0 then\n\n      VN_AUX_CALC := NVL(:new.VLR_ICMS, 0);\n\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_ICMS,\n                                             :new.VLR_BASE_ICMS,\n                                             VN_AUX_CALC);\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do ICMS digitado!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do ICMS digitado!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de ICMS digitado diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.VLR_ICMS := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n\n    end if;\n    */\n\n    VN_VLR_RATEADO := 0;\n\n    if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS, 0) > 0 then\n      -- CALCULA O RATEIO DO FRETE\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE, 0) > 0 then\n        VN_VLR_RATEADO := VN_VLR_RATEADO +\n                          BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE;\n      end if;\n      -- CALCULA O RATEIO DO ACRESCIMO\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE, 0) > 0 then\n        VN_VLR_RATEADO := VN_VLR_RATEADO +\n                          BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE;\n      end if;\n      -- CALCULA O RATEIO DO DESCONTO\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE, 0) > 0 then\n        VN_VLR_RATEADO := VN_VLR_RATEADO -\n                          BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE;\n      end if;\n    end if;\n    -- aok - 22/11/2013 --------------------------------------------------------\n    -- if vc_ind_carga_siad = 'Y' and :new.vlr_base_icms > 0 and\n    --   :new.vlr_base_icms_calc = 0\n    --   then\n    --   :new.PERC_REDUCAO_ICMS := (:new.vlr_total_calc - :new.vlr_base_icms) / :new.vlr_total_calc * 100;\n    -- end if;\n    ----------------------------------------------------------------------------\n    -- Se houver Percentual de Reducao na Base de ICMS, desconta este percentual da Base\n    --\n    if NVL(:new.PERC_REDUCAO_ICMS, 0) > 0 then\n      --\n      V_VALOR_BASE_ICMS         := :new.VLR_TOTAL_CALC -\n                                   ((:new.VLR_TOTAL_CALC *\n                                   :new.PERC_REDUCAO_ICMS) / 100);\n      :new.VLR_BASE_OUTROS_ICMS := :new.VLR_TOTAL_CALC - V_VALOR_BASE_ICMS; -- aok - 05/11/2010\n      :new.ALQ_OUTROS_ICMS      := :new.ALQ_ICMS; -- aok - 05/11/2010\n      --\n    else\n      --\n      V_VALOR_BASE_ICMS := :new.VLR_TOTAL_CALC;\n      --\n    end if;\n    --\n    if VN_VLR_RATEADO = 0 then\n      :new.VLR_BASE_ICMS_CALC := V_VALOR_BASE_ICMS;\n    else\n      --VLR_TEMP := BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS;\n      --if VN_VLR_RATEADO > 0 then\n      :new.VLR_BASE_ICMS_CALC := ROUND((VN_VLR_RATEADO /\n                                       BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS *\n                                       V_VALOR_BASE_ICMS) +\n                                       V_VALOR_BASE_ICMS,\n                                       2);\n    end if;\n\n    if :new.IND_ACRESCIMO_BASE_ICMS = 'Y' then\n      :new.VLR_BASE_ICMS_CALC := :new.VLR_BASE_ICMS_CALC +\n                                 NVL(:new.VLR_ACRESCIMO, 0);\n    end if;\n\n    if :new.IND_DESCONTO_BASE_ICMS = 'Y' then\n      :new.VLR_BASE_ICMS_CALC := :new.VLR_BASE_ICMS_CALC -\n                                 NVL(:new.VLR_DESCONTO, 0);\n    end if;\n    --\n    if VC_IND_CARGA_SIAD = 'Y' -- aok - 22/11/2013\n     then\n      :new.VLR_BASE_ICMS_CALC := :new.VLR_BASE_ICMS;\n      :new.VLR_ICMS_CALC      := :new.VLR_ICMS;\n    elsif nvl(:new.ALQ_ICMS,0) > 0\n      and nvl(:new.VLR_BASE_ICMS_CALC,0) > 0\n      and nvl(:new.VLR_ICMS,0) > 0 then\n      null;\n    else\n      -- VN_AUX_VLR_ICMS := :new.VLR_BASE_ICMS_CALC; -- aok - 12/11/2013\n      -- VN_AUX_VLR_ICMS := 0;  -- aok - 12/11/2013\n      VN_AUX_CALC := :new.VLR_ICMS; --VN_AUX_CALC := 0;\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_ICMS,\n                                             :new.VLR_BASE_ICMS_CALC,\n                                             VN_AUX_CALC);\n      -- VN_AUX_VLR_ICMS);\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do ICMS!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do ICMS!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de ICMS(' || VN_AUX_CALC || --VN_AUX_VLR_ICMS\n                       ') diferente do valor informado(' || :new.VLR_ICMS ||\n                       ')! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.VLR_ICMS_CALC := ROUND(VN_AUX_CALC, 2);\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if; -- aok - 22/11/2013\n  end if;\n\n  -- Outros ICMS\n  VN_AUX_CALC := 0; --NVL(:NEW.VLR_OUTROS_ICMS, 0); -- aok - 05/11/2010\n  BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_OUTROS_ICMS,\n                                         :new.VLR_BASE_OUTROS_ICMS,\n                                         VN_AUX_CALC);\n  -- VN_AUX_VLR_ICMS);\n  if VN_AUX_CALC = -1 then\n    VC_MSG_ERRO := 'Valores negativos no calculo de outros ICMS!';\n  elsif VN_AUX_CALC = -2 then\n    VC_MSG_ERRO := 'Impossivel apurar valor de outros ICMS!';\n  elsif VN_AUX_CALC = -3 then\n    VC_MSG_ERRO := 'Valor apurado de outros ICMS diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n  else\n    if NVL(:new.VLR_OUTROS_ICMS, 0) = 0\n       or :new.VLR_OUTROS_ICMS <> VN_AUX_CALC -- aok - 08/11/2010\n     then\n      :new.VLR_OUTROS_ICMS := VN_AUX_CALC;\n    end if;\n  end if;\n  if VC_MSG_ERRO is not null then\n    goto FIM;\n  end if;\n\n  -- ICMS substituic?o\n  if NVL(:new.ALQ_ICMS_SUBST, 0) = 0 then\n    :new.VLR_BASE_ICMS_SUBST_CALC := 0;\n    :new.VLR_ICMS_SUBST_CALC      := 0;\n  else\n    -- Se digitou nova base ou novo valor, verifica pelos digitados\n    /* Solicitado para n?o fazer mais validac?o.\n    if NVL(:new.VLR_BASE_ICMS_SUBST, 0) > 0\n       or NVL(:new.VLR_ICMS_SUBST, 0) > 0 then\n\n      VN_AUX_CALC := NVL(:new.VLR_ICMS_SUBST, 0);\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_ICMS_SUBST,\n                                             :new.VLR_BASE_ICMS_SUBST,\n                                             VN_AUX_CALC);\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do ICMS da substituic?o digitada!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do ICMS da substituic?o digitada!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de ICMS da substituic?o digitada diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.VLR_ICMS_SUBST := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n\n    end if;\n    */\n\n    VN_VLR_RATEADO := 0;\n\n    if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS, 0) > 0 then\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE, 0) > 0 then\n        VN_VLR_RATEADO := VN_VLR_RATEADO +\n                          BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE;\n      end if;\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE, 0) > 0 then\n        VN_VLR_RATEADO := VN_VLR_RATEADO +\n                          BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_ICMS_NFE;\n      end if;\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE, 0) > 0 then\n        VN_VLR_RATEADO := VN_VLR_RATEADO -\n                          BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_ICMS_NFE;\n      end if;\n    end if;\n\n    if VN_VLR_RATEADO = 0 then\n      :new.VLR_BASE_ICMS_SUBST_CALC := :new.VLR_TOTAL_CALC;\n    else\n      :new.VLR_BASE_ICMS_SUBST_CALC := ROUND((VN_VLR_RATEADO /\n                                             BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS *\n                                             :new.VLR_TOTAL_CALC) +\n                                             :new.VLR_TOTAL_CALC,\n                                             2);\n    end if;\n\n    if :new.IND_ACRESCIMO_BASE_ICMS = 'Y' then\n      :new.VLR_BASE_ICMS_SUBST_CALC := :new.VLR_BASE_ICMS_SUBST_CALC +\n                                       NVL(:new.VLR_ACRESCIMO, 0);\n    end if;\n\n    if :new.IND_DESCONTO_BASE_ICMS = 'Y' then\n      :new.VLR_BASE_ICMS_SUBST_CALC := :new.VLR_BASE_ICMS_SUBST_CALC -\n                                       NVL(:new.VLR_DESCONTO, 0);\n    end if;\n\n    VN_AUX_CALC := :new.VLR_ICMS_SUBST; --VN_AUX_CALC := 0;\n    BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_ICMS_SUBST,\n                                           :new.VLR_BASE_ICMS_SUBST_CALC,\n                                           VN_AUX_CALC);\n    --VN_AUX_VLR_ICMS);\n    if VN_AUX_CALC = -1 then\n      VC_MSG_ERRO := 'Valores negativos no calculo do ICMS da substituic?o!';\n    elsif VN_AUX_CALC = -2 then\n      VC_MSG_ERRO := 'Impossivel apurar valor do ICMS da substituic?o!';\n    elsif VN_AUX_CALC = -3 then\n      VC_MSG_ERRO := 'Valor apurado de ICMS da substituic?o diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n    else\n      :new.VLR_ICMS_SUBST_CALC := ROUND(VN_AUX_CALC, 2);\n    end if;\n    if VC_MSG_ERRO is not null then\n      goto FIM;\n    end if;\n  end if;\n\n  -- Isento de ICMS\n  if NVL(:new.VLR_BASE_ISENTO_ICMS, 0) < 0 then\n    VC_MSG_ERRO := 'Valor da base isenta de ICMS negativo!';\n    goto FIM;\n  end if;\n\n  -- IPI\n  if NVL(:new.ALQ_IPI, 0) = 0 then\n    :new.VLR_BASE_IPI_CALC := 0;\n    :new.VLR_IPI_CALC      := 0;\n  else\n    -- Se digitou nova base ou novo valor, verifica pelos digitados\n    /* Solicitado para n?o fazer mais validac?o.\n    if NVL(:new.VLR_BASE_IPI, 0) > 0\n       or NVL(:new.VLR_IPI, 0) > 0 then\n\n      VN_AUX_CALC := NVL(:new.VLR_IPI, 0);\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_IPI,\n                                             :new.VLR_BASE_IPI,\n                                             VN_AUX_CALC);\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do IPI digitado!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do IPI digitado!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de IPI digitado diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.VLR_IPI := VN_AUX_CALC;\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n\n    end if;\n    */\n\n    VN_VLR_RATEADO := 0;\n\n    if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS, 0) > 0 then\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE, 0) > 0 then\n        VN_VLR_RATEADO := VN_VLR_RATEADO +\n                          BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE;\n      end if;\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_IPI_NFE, 0) > 0 then\n        VN_VLR_RATEADO := VN_VLR_RATEADO +\n                          BEG_PCK_CPR_COMPRAS.VN_VLR_ACRESCIMO_IPI_NFE;\n      end if;\n      if NVL(BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE, 0) > 0 then\n        VN_VLR_RATEADO := VN_VLR_RATEADO -\n                          BEG_PCK_CPR_COMPRAS.VN_VLR_DESCONTO_IPI_NFE;\n      end if;\n    end if;\n\n    if VN_VLR_RATEADO = 0 then\n      :new.VLR_BASE_IPI_CALC := :new.VLR_TOTAL_CALC;\n    else\n      --if VN_VLR_RATEADO > 0 then\n      :new.VLR_BASE_IPI_CALC := ROUND((BEG_PCK_CPR_COMPRAS.VN_VLR_FRETE_NFE /\n                                      BEG_PCK_CPR_COMPRAS.VN_VLR_TOTAL_PRODUTOS *\n                                      :new.VLR_TOTAL_CALC) +\n                                      :new.VLR_TOTAL_CALC,\n                                      2);\n    end if;\n\n    if :new.IND_ACRESCIMO_BASE_IPI = 'Y' then\n      :new.VLR_BASE_IPI_CALC := :new.VLR_BASE_IPI_CALC +\n                                NVL(:new.VLR_ACRESCIMO, 0);\n    end if;\n\n    if :new.IND_DESCONTO_BASE_IPI = 'Y' then\n      :new.VLR_BASE_IPI_CALC := :new.VLR_BASE_IPI_CALC -\n                                NVL(:new.VLR_DESCONTO, 0);\n    end if;\n    -- aok - 22/11/2013 --------------------------------------------------------\n    if VC_IND_CARGA_SIAD = 'Y' then\n      :new.VLR_IPI_CALC      := :new.VLR_IPI;\n      :new.VLR_BASE_IPI_CALC := :new.VLR_BASE_IPI;\n    else\n      ----------------------------------------------------------------------------\n      VN_AUX_CALC := :new.VLR_IPI; --VN_AUX_CALC := 0;\n      BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_IPI,\n                                             :new.VLR_BASE_IPI_CALC,\n                                             VN_AUX_CALC);\n      --  VN_AUX_VLR_ICMS);\n      if VN_AUX_CALC = -1 then\n        VC_MSG_ERRO := 'Valores negativos no calculo do IPI!';\n      elsif VN_AUX_CALC = -2 then\n        VC_MSG_ERRO := 'Impossivel apurar valor do IPI!';\n      elsif VN_AUX_CALC = -3 then\n        VC_MSG_ERRO := 'Valor apurado de IPI(' || VN_AUX_CALC || --VN_AUX_VLR_ICMS ||\n                       ') diferente do valor informado(' ||\n                       :new.VLR_IPI_CALC ||\n                       ')! Para calculo automatico deixe o valor zerado.';\n      else\n        :new.VLR_IPI_CALC := ROUND(VN_AUX_CALC, 2);\n      end if;\n      if VC_MSG_ERRO is not null then\n        goto FIM;\n      end if;\n    end if;\n  end if; -- aok - 22/11/2013\n\n  -- Outros IPI\n  VN_AUX_CALC := :new.VLR_OUTROS_IPI;\n  BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_OUTROS_IPI,\n                                         :new.VLR_BASE_OUTROS_IPI,\n                                         VN_AUX_CALC);\n  --   VN_AUX_VLR_ICMS);\n  if VN_AUX_CALC = -1 then\n    VC_MSG_ERRO := 'Valores negativos no calculo de outros IPI!';\n  elsif VN_AUX_CALC = -2 then\n    VC_MSG_ERRO := 'Impossivel apurar valor de outros IPI!';\n  elsif VN_AUX_CALC = -3 then\n    VC_MSG_ERRO := 'Valor apurado de outros IPI diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n  else\n    if NVL(:new.VLR_OUTROS_IPI, 0) = 0 then\n      :new.VLR_OUTROS_IPI := VN_AUX_CALC;\n    end if;\n  end if;\n  if VC_MSG_ERRO is not null then\n    goto FIM;\n  end if;\n\n  -- Isento de IPI\n  if NVL(:new.VLR_BASE_ISENTO_IPI, 0) < 0 then\n    VC_MSG_ERRO := 'Valor da base isenta de IPI negativo!';\n    goto FIM;\n  end if;\n\n  -- ISSQN\n  VN_AUX_CALC := :new.VLR_ISSQN;\n  BEG_PCK_CPR_COMPRAS.PRC_VALIDA_VALORES(:new.ALQ_ISSQN,\n                                         :new.VLR_BASE_ISSQN,\n                                         VN_AUX_CALC);\n  --  VN_AUX_VLR_ICMS);\n  if VN_AUX_CALC = -1 then\n    VC_MSG_ERRO := 'Valores negativos no calculo do ISSQN!';\n  elsif VN_AUX_CALC = -2 then\n    VC_MSG_ERRO := 'Impossivel apurar valor do ISSQN!';\n  elsif VN_AUX_CALC = -3 then\n    VC_MSG_ERRO := 'Valor apurado de ISSQN diferente do valor informado! Para calculo automatico deixe o valor zerado.';\n  else\n    if NVL(:new.VLR_ISSQN, 0) = 0 then\n      :new.VLR_ISSQN := VN_AUX_CALC;\n    end if;\n  end if;\n  if VC_MSG_ERRO is not null then\n    goto FIM;\n  end if;\n\n  -- Valida o almoxarifado informado. Se for zero, n?o posui inspec?o. Neste caso deve ter sido informado no item\n  /*  VN_BEG_EST_ALMOXARIFADO_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:NEW.AD_CLIENT_ID,\n                                                                      :NEW.AD_ORG_ID,\n                                                                      'Estoque',\n                                                                        'Faturamento',\n                                                                        'ALMOXARIFADO_FATURAMENTO'));\n\n    if NVL(VN_BEG_EST_ALMOXARIFADO_ID, 0) = 0 then\n      if NVL(:NEW.BEG_EST_ALMOXARIFADO_ID, 0) = 0 then\n        VC_MSG_ERRO := 'N?o existe almoxarifado de inspec?o parametrizado e item n?o possui almoxarifado informado!';\n        goto FIM;\n      end if;\n    else\n      if :NEW.BEG_EST_ALMOXARIFADO_ID is not null then\n        VC_MSG_ERRO := 'Existe almoxarifado de inspec?o parametrizado e item possui almoxarifado informado!';\n        goto FIM;\n      end if;\n    end if;\n  */\n  -- Atualiza os campos da nota\n  if not BEG_PCK_CPR_COMPRAS.VB_PROC_NFE then\n\n    BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT := true;\n\n    update BEG_CPR_NFE\n       set VLR_BASE_ICMS_CALC       = ROUND(VLR_BASE_ICMS_CALC -\n                                            NVL(:old.VLR_BASE_ICMS_CALC, 0) +\n                                            NVL(:new.VLR_BASE_ICMS_CALC, 0),\n                                            2),\n           VLR_BASE_OUTROS_ICMS     = VLR_BASE_OUTROS_ICMS -\n                                      NVL(:old.VLR_BASE_OUTROS_ICMS, 0) +\n                                      NVL(:new.VLR_BASE_OUTROS_ICMS, 0),\n           VLR_BASE_ICMS_SUBST_CALC = ROUND(VLR_BASE_ICMS_SUBST_CALC -\n                                            NVL(:old.VLR_BASE_ICMS_SUBST_CALC,\n                                                0) + NVL(:new.VLR_BASE_ICMS_SUBST_CALC,\n                                                         0),\n                                            2),\n           VLR_BASE_ISENTO_ICMS     = VLR_BASE_ISENTO_ICMS -\n                                      NVL(:old.VLR_BASE_ISENTO_ICMS, 0) +\n                                      NVL(:new.VLR_BASE_ISENTO_ICMS, 0),\n           VLR_ICMS_CALC            = ROUND(VLR_ICMS_CALC -\n                                            NVL(:old.VLR_ICMS_CALC, 0) +\n                                            NVL(:new.VLR_ICMS_CALC, 0),\n                                            2),\n           VLR_OUTROS_ICMS          = VLR_OUTROS_ICMS -\n                                      NVL(:old.VLR_OUTROS_ICMS, 0) +\n                                      NVL(:new.VLR_OUTROS_ICMS, 0),\n           VLR_ICMS_SUBST_CALC      = ROUND(VLR_ICMS_SUBST_CALC -\n                                            NVL(:old.VLR_ICMS_SUBST_CALC, 0) +\n                                            NVL(:new.VLR_ICMS_SUBST_CALC, 0),\n                                            2),\n           VLR_ICMS_SUBST           = case when NVL(:old.VLR_TOTAL_CALC, 0) <> NVL(:new.VLR_TOTAL_CALC, 0) and IND_NFE_ORDEM = 'Y' then 0 else VLR_ICMS_SUBST end,\n           VLR_BASE_IPI_CALC        = ROUND(VLR_BASE_IPI_CALC -\n                                            NVL(:old.VLR_BASE_IPI_CALC, 0) +\n                                            NVL(:new.VLR_BASE_IPI_CALC, 0),\n                                            2),\n           VLR_BASE_OUTROS_IPI      = VLR_BASE_OUTROS_IPI -\n                                      NVL(:old.VLR_BASE_OUTROS_IPI, 0) +\n                                      NVL(:new.VLR_BASE_OUTROS_IPI, 0),\n           VLR_BASE_ISENTO_IPI      = VLR_BASE_ISENTO_IPI -\n                                      NVL(:old.VLR_BASE_ISENTO_IPI, 0) +\n                                      NVL(:new.VLR_BASE_ISENTO_IPI, 0),\n           VLR_IPI_CALC             = ROUND(VLR_IPI_CALC -\n                                            NVL(:old.VLR_IPI_CALC, 0) +\n                                            NVL(:new.VLR_IPI_CALC, 0),\n                                            2),\n           VLR_IPI                  = case when NVL(:old.VLR_TOTAL_CALC, 0) <> NVL(:new.VLR_TOTAL_CALC, 0) and IND_NFE_ORDEM = 'Y' then 0 else VLR_IPI end,\n           VLR_OUTROS_IPI           = VLR_OUTROS_IPI -\n                                      NVL(:old.VLR_OUTROS_IPI, 0) +\n                                      NVL(:new.VLR_OUTROS_IPI, 0),\n           VLR_BASE_ISSQN           = VLR_BASE_ISSQN -\n                                      NVL(:old.VLR_BASE_ISSQN, 0) +\n                                      NVL(:new.VLR_BASE_ISSQN, 0),\n           VLR_ISSQN                = VLR_ISSQN - NVL(:old.VLR_ISSQN, 0) +\n                                      NVL(:new.VLR_ISSQN, 0),\n           ALQ_ISSQN                = ALQ_ISSQN - NVL(:old.ALQ_ISSQN,0) + NVL(:NEW.ALQ_ISSQN,0),\n           QTD_VOLUMES              = QTD_VOLUMES - NVL(:old.QTD_VOLUMES, 0) +\n                                      NVL(:new.QTD_VOLUMES, 0),\n           PESO_BRUTO               = PESO_BRUTO - NVL(:old.PESO_BRUTO, 0) +\n                                      NVL(:new.PESO_BRUTO, 0),\n           PESO_LIQUIDO             = PESO_LIQUIDO -\n                                      NVL(:old.PESO_LIQUIDO, 0) +\n                                      NVL(:new.PESO_LIQUIDO, 0),\n           VLR_SEGURO               = VLR_SEGURO - NVL(:old.VLR_SEGURO, 0) +\n                                      NVL(:new.VLR_SEGURO, 0),\n           VLR_DESCONTO             = VLR_DESCONTO  - NVL(:OLD.VLR_DESCONTO,0) + NVL(:NEW.VLR_DESCONTO,0),\n           VLR_TOTAL_PRODUTOS_CALC  = ROUND(VLR_TOTAL_PRODUTOS_CALC -\n                                            NVL(:old.VLR_TOTAL_CALC, 0) +\n                                            NVL(:new.VLR_TOTAL_CALC, 0),\n                                            2),\n           VLR_TOTAL_NOTA_CALC      = ROUND(VLR_TOTAL_NOTA_CALC -\n                                            (NVL(:old.VLR_TOTAL_CALC, 0) + -- Total dos itens\n                                            NVL(:old.VLR_DESPESAS_FINANCEIRAS,\n                                                 0) + -- Despesas financeiras do item\n                                            NVL(:old.VLR_OUTRAS_DESPESAS, 0) + -- Outras despesas do item\n                                            DECODE(NVL(:old.IND_FRETE_NOTA,\n                                                        'N'),\n                                                    'Y',\n                                                    (NVL(:old.VLR_FRETE, 0) +\n                                                    NVL(:old.VLR_FRETE_RDP,\n                                                         0)),\n                                                    0) - NVL(:OLD.VLR_DESCONTO,0)) + -- Frete dos itens (na nota)\n                                            (NVL(:new.VLR_TOTAL_CALC, 0) + -- Total dos itens\n                                            NVL(:new.VLR_DESPESAS_FINANCEIRAS,\n                                                 0) + -- Despesas financeiras do item\n                                            NVL(:new.VLR_OUTRAS_DESPESAS, 0) + -- Outras despesas do item\n                                            DECODE(NVL(:new.IND_FRETE_NOTA,\n                                                        'N'),\n                                                    'Y',\n                                                    (NVL(:new.VLR_FRETE, 0) +\n                                                    NVL(:new.VLR_FRETE_RDP,\n                                                         0)),\n                                                    0) + NVL(:OLD.VLR_DESCONTO,0)), -- Frete dos itens (na nota)\n                                            2)\n     where BEG_CPR_NFE_ID = :new.BEG_CPR_NFE_ID;\n\n    BEG_PCK_CPR_COMPRAS.VB_PROC_NFE_IT := false;\n  end if;\n  -- AOK - 18/10/2010 -- Tratamento dos codigos de tributaÁ¿o de icms\n  if INSERTING AND :NEW.BEG_FIS_TRIB_ICMS_ID IS NULL then\n    :new.BEG_FIS_TRIB_ICMS_ID := 1000000; -- 00 - Tributa integralmente\n    --  elsif UPDATING then\n    --    if :NEW.BEG_FIS_TRIB_ICMS_ID = :OLD.BEG_FIS_TRIB_ICMS_ID then\n    --      :NEW.BEG_FIS_TRIB_ICMS_ID := BEG_FNC_GERA_COD_SIT_TRIB(2,\n    --                                                             NVL(:NEW.VLR_BASE_ICMS_CALC,\n    --                                                                 0),\n    --                                                             NVL(:NEW.VLR_BASE_OUTROS_ICMS,\n    --                                                                0),\n    --                                                            NVL(:NEW.VLR_BASE_ISENTO_ICMS,\n    --                                                               0),\n    --                                                           NVL(:NEW.VLR_BASE_ICMS_SUBST_CALC,\n    --                                                              0));\n    -- end if;\n  end if;\n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend BEG_TRG_BIUD_CPR_NFE_ITEM;\n"}`;
    
    }
}
