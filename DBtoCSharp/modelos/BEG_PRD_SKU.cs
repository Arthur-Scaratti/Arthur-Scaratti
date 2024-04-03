
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_SKU
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do SKU
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
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
        /// Codigo do SKU
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Quantidade de unidades do SKU
        /// </summary>
        public int QUANTIDADE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica SKU de venda
        /// </summary>
        public string IND_COMERCIAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica SKU de compra (fornecedor)
        /// </summary>
        public string IND_SUPRIMENTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica SKU padr?o para venda
        /// </summary>
        public string PADRAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica SKU da marca propria
        /// </summary>
        public string IND_MARCA_PROPRIA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica SKU composto por outros SKUs
        /// </summary>
        public string IND_COMPOSTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica SKU de insumo para composic?o / montagem de SKUs
        /// </summary>
        public string IND_INSUMO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Sendo SKU de insumo, indica que pode ser vendido
        /// </summary>
        public string IND_VENDA_INSUMO { get; set; }
            [Required]
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID da unidade de medida
        /// </summary>
        public int BEG_PRD_UNIDADE_ID { get; set; }
        
        /// <summary>
        /// ID da cor
        /// </summary>
        public int BEG_PRD_COR_ID { get; set; }
        
        /// <summary>
        /// ID das informac?es da ONU
        /// </summary>
        public int BEG_PRD_ONU_ID { get; set; }
        
        /// <summary>
        /// ID da voltagem
        /// </summary>
        public int BEG_PRD_VOLTAGEM_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AI_PRD_SKU { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  vn_margem_padrao   beg_prd_sku_detalhe.beg_ven_com_margem_produto_id%Type;\n  vn_situacao_padrao beg_prd_sku_detalhe.beg_prd_situacao_id%Type;\n\nbegin\n  -- Se disparou emfunção da geração do protuso, simplesmente retorna\n  if BEG_PCK_PRD_Produtos.vb_prd_gerador then\n    return;\n  end if;\n\n  -- Busca margem do grupo\n  begin\n    select g.beg_ven_com_margem_produto_id\n      into vn_margem_padrao\n      from die_prd_subgrupo g\n         , beg_produto   p\n     where g.die_prd_grupo_id = p.die_prd_subgrupo_id\n       and p.beg_produto_id   = :new.beg_produto_id;\n\n  exception\n    when no_data_found then\n      vn_margem_padrao := BEG_FNC_Retorna_Parametro( :new.ad_client_id\n                                                   , :new.ad_org_id\n                                                   , 'Produto'\n                                                   , 'Geral'\n                                                   , 'MARGEM_PADRAO' );\n\n  end;\n\n  vn_situacao_padrao := BEG_FNC_Retorna_Parametro( :new.ad_client_id\n                                                 , :new.ad_org_id\n                                                 , 'Produto'\n                                                 , 'Geral'\n                                                 , 'SITUACAO_PADRAO' );\n\n  insert into beg_prd_sku_detalhe\n         ( beg_prd_sku_detalhe_id\n         , ad_client_id\n         , ad_org_id\n         , createdby\n         , updatedby\n         , posicao_fisica\n         , beg_produto_id\n         , beg_prd_sku_id\n         , beg_prd_situacao_id\n         , beg_ven_com_margem_produto_id )\n  values ( BEG_FNC_AD_Sequence( 'BEG_PRD_SKU_DETALHE' ) -- beg_prd_sku_detalhe_id\n         , :new.ad_client_id\n         , :new.ad_org_id\n         , :new.updatedby -- createdby\n         , :new.updatedby\n         , '1' -- posicao_fisica\n         , :new.beg_produto_id\n         , :new.beg_prd_sku_id\n         , vn_situacao_padrao -- beg_prd_situacao_id\n         , vn_margem_padrao ); -- beg_ven_com_margem_produto_id\n\nend BEG_TRG_AI_PRD_SKU;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_PRD_SKU { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida campos do SKU.\n  Modulo.......: PRD - Produtos\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  31/08/2006  Tiago Gabriel  Criac?o.\n  ---------------------------------------------------------------------------------------------------*/\n  if :new.IND_INSUMO = 'Y'\n     and :new.IND_COMPOSTO = 'Y' then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Produto n?o pode ser insumo e composto ao mesmo tempo!');\n  end if;\n\n  if :new.IND_INSUMO = 'N' then\n    :new.IND_VENDA_INSUMO := 'N';\n  end if;\n\nend BEG_TRG_BIU_PRD_SKU;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AID_PRD_SKU { get; set; } = `{"triggering_event":"INSERT OR DELETE","trigger_body":"declare\n  VN_DUMMY                number;\n  VN_BEG_VW_FORNECEDOR_ID BEG_SUP_LISTA_FORNECEDOR.BEG_VW_FORNECEDOR_ID%type;\n\nbegin\n  -- Se disparou emfunção da geração do protuso, simplesmente retorna\n  if BEG_PCK_PRD_PRODUTOS.VB_PRD_GERADOR then\n    return;\n  end if;\n\n  -- Se esta inserindo ou atualizando, inclui o custo do produto / sku\n  select BEG_VW_FORNECEDOR_ID\n    into VN_BEG_VW_FORNECEDOR_ID\n    from BEG_PRD_FORNECEDOR\n   where BEG_PRODUTO_ID = NVL(:new.BEG_PRODUTO_ID, :old.BEG_PRODUTO_ID)\n     and padrao = 'Y';\n\n  if INSERTING then\n    select count(1)\n      into VN_DUMMY\n      from BEG_SUP_LISTA_FORNECEDOR\n     where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n       and BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID\n       and BEG_VW_FORNECEDOR_ID = VN_BEG_VW_FORNECEDOR_ID;\n  \n    if VN_DUMMY = 0 then\n    \n      BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_SKU := true;\n    \n      insert into BEG_SUP_LISTA_FORNECEDOR\n        (BEG_SUP_LISTA_FORNECEDOR_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         CREATEDBY,\n         UPDATEDBY,\n         BEG_PRODUTO_ID,\n         BEG_PRD_SKU_ID,\n         BEG_VW_FORNECEDOR_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_SUP_LISTA_FORNECEDOR'), -- beg_sup_lista_fornecedor_id\n         :new.AD_CLIENT_ID, -- ad_client_id\n         :new.AD_ORG_ID, -- ad_org_id\n         :new.UPDATEDBY, -- createdby\n         :new.UPDATEDBY, -- updatedby\n         :new.BEG_PRODUTO_ID, -- beg_produto_id\n         :new.BEG_PRD_SKU_ID, -- beg_prd_sku_id\n         VN_BEG_VW_FORNECEDOR_ID); -- beg_vw_fornecedor_id\n    \n      BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_SKU := false;\n    \n    end if;\n  end if;\n\n  -- Se esta excluindo ou atualizando exclui o anterior\n  if DELETING then\n  \n    -- Exclui o preco\n    delete from BEG_SUP_LISTA_FORNECEDOR\n     where BEG_PRODUTO_ID = :old.BEG_PRODUTO_ID\n       and BEG_PRD_SKU_ID = :old.BEG_PRD_SKU_ID\n       and BEG_VW_FORNECEDOR_ID = VN_BEG_VW_FORNECEDOR_ID;\n  \n  end if;\n\nexception\n  when NO_DATA_FOUND then\n    null;\n  \nend BEG_TRG_AID_PRD_SKU;\n"}`;
    
    }
}
