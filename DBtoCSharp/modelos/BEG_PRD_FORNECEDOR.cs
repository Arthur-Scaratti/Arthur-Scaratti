
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_FORNECEDOR
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD_LOTE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_FORNECEDOR_ID { get; set; }
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
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PADRAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD_COMPRA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BUD_PRD_FORNEC_MARCA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor C_PRODUTO is\n    select A.BEG_PRD_MARCA_ID\n      from BEG_PRODUTO A\n     where A.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n\n  cursor C_MARCA_PADRAO is\n    select A.BEG_PRD_MARCA_ID\n      from BEG_PRD_FORNEC_MARCA A\n     where A.BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID\n       and A.PADRAO = 'Y';\n  V_MARCA        number;\n  V_MARCA_PADRAO number;\nbegin\n\n  open C_PRODUTO;\n  fetch C_PRODUTO\n    into V_MARCA;\n  close C_PRODUTO;\n\n  if V_MARCA is null then\n    open C_MARCA_PADRAO;\n    fetch C_MARCA_PADRAO\n      into V_MARCA_PADRAO;\n    if C_MARCA_PADRAO%found then\n      update BEG_PRODUTO\n         set BEG_PRD_MARCA_ID = V_MARCA_PADRAO\n       where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n    \n    end if;\n  end if;\n\nend BEG_TRG_BUD_PRD_FORNEC_MARCA;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BUD_PRD_FORNECEDOR { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  VN_DUMMY number;\n\nbegin\n  if NVL(:new.BEG_VW_FORNECEDOR_ID, 0) <> NVL(:old.BEG_VW_FORNECEDOR_ID, 0) then\n    if BEG_FNC_RETORNA_PARAM_GERAL('Compras',\n                                   'Produto',\n                                   'CONSISTE_PRODUTO_FORNECEDOR') = 'Y' then\n      select count(1)\n        into VN_DUMMY\n        from BEG_CPR_NFE_ITEM NFE_IT,\n             BEG_CPR_NFE      NFE\n       where NFE_IT.BEG_CPR_NFE_ID = NFE.BEG_CPR_NFE_ID\n         and NFE.BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID\n         and NFE_IT.BEG_PRODUTO_ID =\n             NVL(:new.BEG_PRODUTO_ID, :old.BEG_PRODUTO_ID);\n    \n      if VN_DUMMY > 0 then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Operac?o n?o permitida, produto possui ordem de compra!');\n      end if;\n    \n      select count(1)\n        into VN_DUMMY\n        from BEG_CPR_ORDEM_ITEM ORD_IT,\n             BEG_CPR_ORDEM      ORD\n       where ORD_IT.BEG_CPR_ORDEM_ID = ORD.BEG_CPR_ORDEM_ID\n         and ORD.BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID\n         and ORD_IT.BEG_PRODUTO_ID =\n             NVL(:new.BEG_PRODUTO_ID, :old.BEG_PRODUTO_ID);\n    \n      if VN_DUMMY > 0 then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Operac?o n?o permitida, produto possui ordem de compra!');\n      end if;\n    \n    end if;\n  end if;\n\nend BEG_TRG_BUD_PRD_FORNECEDOR;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AIUD_PRD_FORNECEDOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  VN_DUMMY number;\n  VN_CAPA  number;\n\n  VC_DIE_COD_ESTRUTURADO BEG_PRODUTO.DIE_COD_ESTRUTURADO%type;\n\nbegin\n  -- Se esta inserindo ou atualizando, cria a lista (se n?o existir) e inclui o produto\n  if not BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_PRECO then\n  \n    select DIE_COD_ESTRUTURADO\n      into VC_DIE_COD_ESTRUTURADO\n      from BEG_PRODUTO\n     where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n  \n    BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_FORN := true;\n  \n    if INSERTING\n       or\n       (UPDATING and :new.BEG_VW_FORNECEDOR_ID <> :old.BEG_VW_FORNECEDOR_ID) then\n    \n      -- Verifica se existe capa de lista para o novo fornecedor\n      select count(1)\n        into VN_CAPA\n        from BEG_SUP_FORNECEDOR\n       where BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID;\n    \n      -- Verifica se existe lista para o novo fornecedor\n      select count(1)\n        into VN_DUMMY\n        from BEG_SUP_LISTA_FORNECEDOR\n       where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n         and BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID;\n    \n      -- Se trocou o fornecedor insere caso n?o exista e troca em todos os precos\n      if UPDATING then\n      \n        if VN_DUMMY = 0 then\n          -- Se não existe capa, cria uma\n          if VN_CAPA = 0 then\n            insert into BEG_SUP_FORNECEDOR\n              (BEG_SUP_FORNECEDOR_ID,\n               AD_CLIENT_ID,\n               AD_ORG_ID,\n               CREATEDBY,\n               UPDATEDBY,\n               BEG_VW_FORNECEDOR_ID)\n            values\n              (BEG_FNC_AD_SEQUENCE('BEG_SUP_FORNECEDOR'), -- beg_sup_fornecedor_id\n               :new.AD_CLIENT_ID, -- ad_client_id\n               :new.AD_ORG_ID, -- ad_org_id\n               :new.UPDATEDBY, -- createdby\n               :new.UPDATEDBY, -- updatedby\n               :new.BEG_VW_FORNECEDOR_ID); -- beg_vw_fornecedor_id\n          end if;\n        \n          update BEG_SUP_LISTA_FORNECEDOR\n             set BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID\n           where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n             and BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID;\n        \n          VN_DUMMY := sql%rowcount;\n        else\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Ja existe lista de fornecedores para este produto!');\n          /*delete from BEG_SUP_LISTA_FORNECEDOR\n          where BEG_PRODUTO_ID = :old.BEG_PRODUTO_ID\n            and BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID;\n          VN_DUMMY := sql%rowcount;*/\n        end if;\n      \n      end if;\n    \n      if VN_DUMMY = 0 then\n        -- Se não existe capa, cria uma\n        if VN_CAPA = 0 then\n          insert into BEG_SUP_FORNECEDOR\n            (BEG_SUP_FORNECEDOR_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             CREATEDBY,\n             UPDATEDBY,\n             BEG_VW_FORNECEDOR_ID)\n          values\n            (BEG_FNC_AD_SEQUENCE('BEG_SUP_FORNECEDOR'), -- beg_sup_fornecedor_id\n             :new.AD_CLIENT_ID, -- ad_client_id\n             :new.AD_ORG_ID, -- ad_org_id\n             :new.UPDATEDBY, -- createdby\n             :new.UPDATEDBY, -- updatedby\n             :new.BEG_VW_FORNECEDOR_ID); -- beg_vw_fornecedor_id\n        end if;\n      \n        insert into BEG_SUP_LISTA_FORNECEDOR LST\n          (LST.BEG_SUP_LISTA_FORNECEDOR_ID,\n           LST.AD_CLIENT_ID,\n           LST.AD_ORG_ID,\n           LST.CREATEDBY,\n           LST.UPDATEDBY,\n           LST.BEG_PRODUTO_ID,\n           LST.BEG_PRD_SKU_ID,\n           LST.BEG_VW_FORNECEDOR_ID,\n           LST.REFERENCIA,\n           LST.DIE_COD_ESTRUTURADO)\n          select BEG_FNC_AD_SEQUENCE('BEG_SUP_LISTA_FORNECEDOR'), -- beg_sup_lista_fornecedor_id\n                 :new.AD_CLIENT_ID, -- ad_client_id\n                 :new.AD_ORG_ID, -- ad_org_id\n                 :new.UPDATEDBY, -- createdby\n                 :new.UPDATEDBY, -- updatedby\n                 :new.BEG_PRODUTO_ID, -- beg_produto_id\n                 SKU.BEG_PRD_SKU_ID, -- beg_prd_sku_id\n                 :new.BEG_VW_FORNECEDOR_ID, -- beg_vw_fornecedor_id\n                 :new.REFERENCIA, -- referencia\n                 VC_DIE_COD_ESTRUTURADO -- die_cod_estruturado\n            from BEG_PRD_SKU SKU\n           where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n      \n      end if;\n    \n    end if;\n  \n    if NVL(:new.REFERENCIA, '^') <> NVL(:old.REFERENCIA, '^') then\n      update BEG_SUP_LISTA_FORNECEDOR\n         set REFERENCIA = :new.REFERENCIA\n       where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n         and BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID;\n    end if;\n  \n    BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_FORN := false;\n  \n  end if;\n\n  -- Se esta excluindo ou atualizando exclui o anterior\n  if DELETING then\n    -- Exclui o preco\n    delete from BEG_SUP_LISTA_FORNECEDOR\n     where BEG_PRODUTO_ID = :old.BEG_PRODUTO_ID\n       and BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID;\n  end if;\n\nend BEG_TRG_AIUD_PRD_FORNECEDOR;\n"}`;
    
    }
}
