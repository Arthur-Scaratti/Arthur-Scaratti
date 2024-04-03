
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_SUP_FORNECEDOR
    {
        
        /// <summary>
        /// Tempo de reposicao da mercadoria apos emissao ordem de compra
        /// </summary>
        public int TEMPO_REPOSICAO { get; set; }
        
        /// <summary>
        /// tempo entre ordens de compra
        /// </summary>
        public int PERIODO_COMPRA { get; set; }
        
        /// <summary>
        /// numero de dias para o estoque de seguranca
        /// </summary>
        public int DIAS_EST_SEGURANCA { get; set; }
        
        /// <summary>
        /// data ultima compra
        /// </summary>
        public string DT_COMPRA { get; set; }
        
        /// <summary>
        /// data prevista proxima compra
        /// </summary>
        public string DT_PROX_COMPRA { get; set; }
        
        /// <summary>
        /// Percentual maximo desconto sobre o preco venda
        /// </summary>
        public int PER_MAX_DESCONTO_VENDA { get; set; }
        
        /// <summary>
        /// numero maximo parcela na venda
        /// </summary>
        public int NRO_MAX_PARCELA_VENDA { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto 7
        /// </summary>
        public int PER_DESCONTO7 { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto 8
        /// </summary>
        public int PER_DESCONTO8 { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto 9
        /// </summary>
        public int PER_DESCONTO9 { get; set; }
            [Required]
        /// <summary>
        /// Valor do frete
        /// </summary>
        public int VLR_FRETE { get; set; }
            [Required]
        /// <summary>
        /// Percentual de diferença de ICMS
        /// </summary>
        public int PER_DIF_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto 6
        /// </summary>
        public int PER_DESCONTO6 { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID dos dados de suprimento de fornecedores
        /// </summary>
        public int BEG_SUP_FORNECEDOR_ID { get; set; }
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
        /// Percentual de desconto 1
        /// </summary>
        public int PER_DESCONTO1 { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto 2
        /// </summary>
        public int PER_DESCONTO2 { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto 3
        /// </summary>
        public int PER_DESCONTO3 { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto 4
        /// </summary>
        public int PER_DESCONTO4 { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto 5
        /// </summary>
        public int PER_DESCONTO5 { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto no vencimento
        /// </summary>
        public int PER_DESCONTO_VCTO { get; set; }
            [Required]
        /// <summary>
        /// Percentual de frete
        /// </summary>
        public int PER_FRETE { get; set; }
            [Required]
        /// <summary>
        /// Percentual de despesas financeiras
        /// </summary>
        public int PER_DESPESAS_FINANCEIRAS { get; set; }
            [Required]
        /// <summary>
        /// Percentual de outras despesas
        /// </summary>
        public int PER_OUTRAS_DESPESAS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observação de outras despesas
        /// </summary>
        public string OBS_OUTRAS_DESPESAS { get; set; }
            [StringLength(200)]
        /// <summary>
        /// Observação inicializada na Ordem de Compra e Nota Fisca de Entrada
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// ID do fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// ID da forma de pagamento
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID da condição de pagamento
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// ID da transportadora
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
        
        /// <summary>
        /// ID do comprador
        /// </summary>
        public int BEG_CPR_COMPRADOR_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo do frete: C - CIF / F - FOB / R - Retira / A - A Combinar
        /// </summary>
        public string TP_FRETE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Botão auxiliar para o Compiere: Copia produtos de um fornecedor para outra filial ou para outro fornecedor
        /// </summary>
        public string BTN_COPIA_PRODUTOS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Botão auxiliar para o Compiere: Gera registros de preco novo para os produtos de um fornecedor para uma filial
        /// </summary>
        public string BTN_GERA_PRECO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_SUP_FORNECEDOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\nBEGIN\n  IF :NEW.DT_COMPRA IS NOT NULL THEN\n    :NEW.DT_PROX_COMPRA := (:NEW.DT_COMPRA + :NEW.PERIODO_COMPRA);\n  END IF;\n\n\n  IF :NEW.TP_FRETE = 'F' AND :NEW.BEG_VW_TRANSPORTADORA_ID IS NULL THEN \n    RAISE_APPLICATION_ERROR(-20001,'Para este tipo de frete favor informar transportadora padrao');\n  END IF;\n\nEND DIE_TRG_BIU_SUP_FORNECEDOR;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AUD_SUP_FORNECEDOR { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger usada somente com a finalidade de fazer o Log da BEG_SUP_FORNECEDOR\n   Modulo.......: FIS - Fiscal\n   Analista.....:\n   Alteracoes:\n   Data        Desenvolvedor  Alteracao\n   26/02/2015  Magdiel Lopes Criação\n  --------------------------------------------------------------------------------------------------- */\n  cursor cr_col is\n    select t.ad_table_id\n         , c.ad_column_id\n         , Upper( c.columnname ) columnname\n      from ad_table  t\n         , ad_column c\n     where t.ad_table_id = c.ad_table_id\n       and t.tablename   = 'BEG_SUP_FORNECEDOR'\n       and Upper( c.columnname ) not in ( 'CREATED', 'CREATEDBY', 'UPDATED', 'UPDATEDBY' );\n\n  vc_oldvalue ad_changelog.oldvalue%Type;\n  vc_newvalue ad_changelog.newvalue%Type;\n\nbegin\n  -- Insere os registros na tabela de log\n  insert into BEG_SUP_FORNECEDOR_LOG\n  values\n    ('OLD', -- IND_REGISTRO\n   :OLD.beg_sup_fornecedor_id,\n   :OLD.ad_client_id,\n   :OLD.ad_org_id,\n   :OLD.isactive,\n   :OLD.created,\n   :OLD.createdby,\n   :OLD.updated,\n   :OLD.updatedby,\n   :OLD.per_desconto1,\n   :OLD.per_desconto2,\n   :OLD.per_desconto3,\n   :OLD.per_desconto4,\n   :OLD.per_desconto5,\n   :OLD.per_desconto_vcto,\n   :OLD.per_frete,\n   :OLD.per_despesas_financeiras,\n   :OLD.per_outras_despesas,\n   :OLD.obs_outras_despesas,\n   :OLD.obs,\n   :OLD.beg_vw_fornecedor_id,\n   :OLD.beg_ven_forma_pagamento_id,\n   :OLD.beg_condicao_pagamento_id,\n   :OLD.beg_vw_transportadora_id,\n   :OLD.beg_cpr_comprador_id,\n   :OLD.tp_frete,\n   :OLD.btn_copia_produtos,\n   :OLD.btn_gera_preco,\n   :OLD.per_desconto6,\n   :OLD.per_desconto7,\n   :OLD.per_desconto8,\n   :OLD.per_desconto9,\n   :OLD.vlr_frete,\n   :OLD.per_dif_icms,\n   :OLD.per_max_desconto_venda,\n   :OLD.nro_max_parcela_venda,\n   :OLD.Tempo_Reposicao,\n   :OLD.PERIODO_COMPRA,\n   :OLD.DIAS_EST_SEGURANCA,\n   :OLD.DT_COMPRA,\n   :OLD.DT_PROX_COMPRA\n   \n   );\n\n\n\n\n\n  if updating then\n    insert into BEG_SUP_FORNECEDOR_LOG\n    values\n      ('NEW', -- IND_REGISTRO\n   :NEW.beg_sup_fornecedor_id,\n   :NEW.ad_client_id,\n   :NEW.ad_org_id,\n   :NEW.isactive,\n   :NEW.created,\n   :NEW.createdby,\n   :NEW.updated,\n   :NEW.updatedby,\n   :NEW.per_desconto1,\n   :NEW.per_desconto2,\n   :NEW.per_desconto3,\n   :NEW.per_desconto4,\n   :NEW.per_desconto5,\n   :NEW.per_desconto_vcto,\n   :NEW.per_frete,\n   :NEW.per_despesas_financeiras,\n   :NEW.per_outras_despesas,\n   :NEW.obs_outras_despesas,\n   :NEW.obs,\n   :NEW.beg_vw_fornecedor_id,\n   :NEW.beg_ven_forma_pagamento_id,\n   :NEW.beg_condicao_pagamento_id,\n   :NEW.beg_vw_transportadora_id,\n   :NEW.beg_cpr_comprador_id,\n   :NEW.tp_frete,\n   :NEW.btn_copia_produtos,\n   :NEW.btn_gera_preco,\n   :NEW.per_desconto6,\n   :NEW.per_desconto7,\n   :NEW.per_desconto8,\n   :NEW.per_desconto9,\n   :NEW.vlr_frete,\n   :NEW.per_dif_icms,\n   :NEW.per_max_desconto_venda,\n   :NEW.nro_max_parcela_venda,\n   :NEW.Tempo_Reposicao,\n   :NEW.PERIODO_COMPRA,\n   :NEW.DIAS_EST_SEGURANCA,\n   :NEW.DT_COMPRA,\n   :NEW.DT_PROX_COMPRA\n   );\n\n  end if;\n\n\n  for r_col in cr_col loop\n    if deleting                     or\n       Updating( r_col.columnname ) then\n      -- Busca valores old e new para a coluna\n      execute immediate 'select ' || r_col.columnname || ' from BEG_SUP_FORNECEDOR_LOG where ind_registro = ''OLD'''\n         into vc_oldvalue;\n\n      if deleting then\n        vc_newvalue := null;\n      else\n        execute immediate 'select ' || r_col.columnname || ' from BEG_SUP_FORNECEDOR_LOG where ind_registro = ''NEW'''\n           into vc_newvalue;\n      end if;\n\n      if Nvl( vc_oldvalue, '^' ) <> Nvl( vc_newvalue, '^' ) then\n\n        insert into ad_changelog\n               ( ad_changelog_id\n               , ad_session_id\n               , ad_table_id\n               , ad_column_id\n               , ad_client_id\n               , ad_org_id\n               , createdby\n               , updatedby\n               , record_id\n               , oldvalue\n               , newvalue )\n        values ( beg_fnc_ad_sequence( 'AD_ChangeLog' ) -- ad_changelog_id\n               , beg_pck_ad_dictionary.vn_ad_session_id -- ad_session_id\n               , r_col.ad_table_id -- ad_table_id\n               , r_col.ad_column_id -- ad_column_id\n               , beg_pck_ad_dictionary.vn_ad_client_id -- ad_client_id\n               , beg_pck_ad_dictionary.vn_ad_org_id -- ad_org_id\n               , beg_pck_ad_dictionary.vn_ad_user_id -- createdby\n               , beg_pck_ad_dictionary.vn_ad_user_id -- updatedby\n               , Nvl( :new.BEG_SUP_FORNECEDOR_ID, :old.BEG_SUP_FORNECEDOR_ID ) -- record_id\n               , vc_oldvalue\n               , vc_newvalue );\n\n      end if;\n    end if;\n  end loop;\n\n  delete from BEG_SUP_FORNECEDOR_LOG;\n\nend BEG_SUP_FORNECEDOR;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_SUP_FORNECEDOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /* --------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que exclui os produtos de uma lista quando a capa for excluída.\n   Módulo.......: SUP - Suprimentos\n   Analista.....: Tiago Gabriel\n   Alterações:\n   Data        Desenvolvedor  Alteração\n   08/12/2006  Tiago Gabriel  Criação.\n   22/12/2006  Tiago Gabriel  Trigger passou a disparar em update para atualizar as listas.\n   16/01/2007  Tiago Gabriel  Passou a buscar dados do detalhe do SKU, filtrado por filial.\n   05/03/2007  Tiago Gabriel  Implementada utilização da função que calcula os valores da\n                              tabela de fornecedor.\n   14/03/2007  Tiago Gabriel  Adicionada inicialização para cálculo dos percentuais de\n                              desconto do fornecedor, frete e diferença de ICMS.\n  --------------------------------------------------------------------------------------- */\n  pragma autonomous_transaction;\n\n  VN_AD_ORG_ID AD_ORG.AD_ORG_ID%type;\n  VN_CNT_CAPA  number;\n  VN_CNT_LISTA number;\n\n  RC_FRN BEG_SUP_FORNECEDOR%rowtype;\n\nbegin\n  RC_FRN.PER_DESCONTO1            := :new.PER_DESCONTO1;\n  RC_FRN.PER_DESCONTO2            := :new.PER_DESCONTO2;\n  RC_FRN.PER_DESCONTO3            := :new.PER_DESCONTO3;\n  RC_FRN.PER_DESCONTO4            := :new.PER_DESCONTO4;\n  RC_FRN.PER_DESCONTO5            := :new.PER_DESCONTO5;\n  RC_FRN.PER_DESCONTO6            := :new.PER_DESCONTO6;\n  RC_FRN.PER_DESCONTO7            := :new.PER_DESCONTO7;\n  RC_FRN.PER_DESCONTO8            := :new.PER_DESCONTO8;\n  RC_FRN.PER_DESCONTO9            := :new.PER_DESCONTO9;\n  RC_FRN.PER_DESPESAS_FINANCEIRAS := :new.PER_DESPESAS_FINANCEIRAS;\n  RC_FRN.PER_OUTRAS_DESPESAS      := :new.PER_OUTRAS_DESPESAS;\n  RC_FRN.PER_FRETE                := :new.PER_FRETE;\n  RC_FRN.VLR_FRETE                := :new.VLR_FRETE;\n  RC_FRN.PER_DIF_ICMS             := :new.PER_DIF_ICMS;\n\n  select count(1)\n    into VN_CNT_CAPA\n    from BEG_SUP_FORNECEDOR\n   where AD_ORG_ID <> NVL(:new.AD_ORG_ID, :old.AD_ORG_ID)\n     and BEG_VW_FORNECEDOR_ID =\n         NVL(:new.BEG_VW_FORNECEDOR_ID, :old.BEG_VW_FORNECEDOR_ID);\n\n  select count(1)\n    into VN_CNT_LISTA\n    from (select distinct AD_ORG_ID\n            from BEG_SUP_LISTA_FORNECEDOR\n           where AD_ORG_ID <> NVL(:new.AD_ORG_ID, :old.AD_ORG_ID)\n             and BEG_VW_FORNECEDOR_ID =\n                 NVL(:new.BEG_VW_FORNECEDOR_ID, :old.BEG_VW_FORNECEDOR_ID));\n\n  select AD_ORG_ID_GERAL\n    into VN_AD_ORG_ID\n    from BEG_GER_FILIAL\n   where AD_CLIENT_ID = NVL(:new.AD_CLIENT_ID, :old.AD_CLIENT_ID);\n\n  BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_LISTA := true;\n\n  if :old.AD_ORG_ID = VN_AD_ORG_ID then\n    if VN_CNT_CAPA = 0 then\n      if DELETING then\n        delete from BEG_SUP_LISTA_FORNECEDOR\n         where BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID;\n      else\n      \n        -- Calcula e inicializa os valores\n        for R_PRD in (select L.*\n                        from BEG_SUP_LISTA_FORNECEDOR L\n                       where L.BEG_VW_FORNECEDOR_ID =\n                             :new.BEG_VW_FORNECEDOR_ID)\n        loop\n        \n          BEG_PRC_SUP_CALCULA(RC_FRN, R_PRD);\n        \n          update BEG_SUP_LISTA_FORNECEDOR\n             set IND_PRECO_NOVO = 'Y',\n                 VLR_SUGERIDO   = R_PRD.VLR_SUGERIDO,\n                 VLR_LIQUIDO    = R_PRD.VLR_LIQUIDO,\n                 VLR_FINAL      = R_PRD.VLR_FINAL\n           where BEG_SUP_LISTA_FORNECEDOR_ID =\n                 R_PRD.BEG_SUP_LISTA_FORNECEDOR_ID;\n        \n        end loop;\n      \n      end if;\n    else\n      if VN_CNT_LISTA = 0 then\n        if UPDATING then\n          delete from BEG_SUP_LISTA_FORNECEDOR\n           where BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID\n             and AD_ORG_ID <> :old.AD_ORG_ID;\n        else\n        \n          -- Calcula e inicializa os valores\n          for R_PRD in (select L.*\n                          from BEG_SUP_LISTA_FORNECEDOR L\n                         where L.AD_ORG_ID = :new.AD_ORG_ID\n                           and L.BEG_VW_FORNECEDOR_ID =\n                               :new.BEG_VW_FORNECEDOR_ID)\n          loop\n          \n            BEG_PRC_SUP_CALCULA(RC_FRN, R_PRD);\n          \n            update BEG_SUP_LISTA_FORNECEDOR\n               set IND_PRECO_NOVO = 'Y',\n                   VLR_SUGERIDO   = R_PRD.VLR_SUGERIDO,\n                   VLR_LIQUIDO    = R_PRD.VLR_LIQUIDO,\n                   VLR_FINAL      = R_PRD.VLR_FINAL\n             where BEG_SUP_LISTA_FORNECEDOR_ID =\n                   R_PRD.BEG_SUP_LISTA_FORNECEDOR_ID;\n          \n          end loop;\n        \n        end if;\n      else\n        if DELETING then\n          delete from BEG_SUP_LISTA_FORNECEDOR L\n           where L.BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID\n             and L.AD_ORG_ID = :old.AD_ORG_ID\n             and not exists\n           (select 1\n                    from BEG_SUP_FORNECEDOR F\n                   where F.AD_ORG_ID = L.AD_ORG_ID\n                     and F.BEG_VW_FORNECEDOR_ID = L.BEG_VW_FORNECEDOR_ID\n                     and F.AD_ORG_ID <> :old.AD_ORG_ID);\n        else\n        \n          -- Calcula e inicializa os valores\n          for R_PRD in (select L.*\n                          from BEG_SUP_LISTA_FORNECEDOR L\n                         where L.BEG_VW_FORNECEDOR_ID =\n                               :new.BEG_VW_FORNECEDOR_ID\n                           and not exists\n                         (select 1\n                                  from BEG_SUP_FORNECEDOR F\n                                 where F.AD_ORG_ID = L.AD_ORG_ID\n                                   and F.BEG_VW_FORNECEDOR_ID =\n                                       L.BEG_VW_FORNECEDOR_ID\n                                   and F.AD_ORG_ID <> :new.AD_ORG_ID))\n          loop\n          \n            BEG_PRC_SUP_CALCULA(RC_FRN, R_PRD);\n          \n            update BEG_SUP_LISTA_FORNECEDOR\n               set IND_PRECO_NOVO = 'Y',\n                   VLR_SUGERIDO   = R_PRD.VLR_SUGERIDO,\n                   VLR_LIQUIDO    = R_PRD.VLR_LIQUIDO,\n                   VLR_FINAL      = R_PRD.VLR_FINAL\n             where BEG_SUP_LISTA_FORNECEDOR_ID =\n                   R_PRD.BEG_SUP_LISTA_FORNECEDOR_ID;\n          \n          end loop;\n        \n        end if;\n      end if;\n    end if;\n  else\n    if VN_CNT_CAPA = 0 then\n      if DELETING then\n        delete from BEG_SUP_LISTA_FORNECEDOR\n         where BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID;\n      else\n      \n        -- Calcula e inicializa os valores\n        for R_PRD in (select L.*\n                        from BEG_SUP_LISTA_FORNECEDOR L\n                       where L.BEG_VW_FORNECEDOR_ID =\n                             :new.BEG_VW_FORNECEDOR_ID)\n        loop\n        \n          BEG_PRC_SUP_CALCULA(RC_FRN, R_PRD);\n        \n          update BEG_SUP_LISTA_FORNECEDOR\n             set IND_PRECO_NOVO = 'Y',\n                 VLR_SUGERIDO   = R_PRD.VLR_SUGERIDO,\n                 VLR_LIQUIDO    = R_PRD.VLR_LIQUIDO,\n                 VLR_FINAL      = R_PRD.VLR_FINAL\n           where BEG_SUP_LISTA_FORNECEDOR_ID =\n                 R_PRD.BEG_SUP_LISTA_FORNECEDOR_ID;\n        \n        end loop;\n      \n      end if;\n    else\n      if VN_CNT_LISTA = 0 then\n        if UPDATING then\n        \n          -- Calcula e inicializa os valores\n          for R_PRD in (select L.*\n                          from BEG_SUP_LISTA_FORNECEDOR L\n                         where L.BEG_VW_FORNECEDOR_ID =\n                               :new.BEG_VW_FORNECEDOR_ID)\n          loop\n          \n            BEG_PRC_SUP_CALCULA(RC_FRN, R_PRD);\n          \n            update BEG_SUP_LISTA_FORNECEDOR\n               set IND_PRECO_NOVO = 'Y',\n                   VLR_SUGERIDO   = R_PRD.VLR_SUGERIDO,\n                   VLR_LIQUIDO    = R_PRD.VLR_LIQUIDO,\n                   VLR_FINAL      = R_PRD.VLR_FINAL\n             where BEG_SUP_LISTA_FORNECEDOR_ID =\n                   R_PRD.BEG_SUP_LISTA_FORNECEDOR_ID;\n          \n          end loop;\n        \n        end if;\n      else\n        if DELETING then\n          delete from BEG_SUP_LISTA_FORNECEDOR\n           where BEG_VW_FORNECEDOR_ID = :old.BEG_VW_FORNECEDOR_ID\n             and AD_ORG_ID = :old.AD_ORG_ID;\n        else\n        \n          -- Calcula e inicializa os valores\n          for R_PRD in (select L.*\n                          from BEG_SUP_LISTA_FORNECEDOR L\n                         where L.AD_ORG_ID = :new.AD_ORG_ID\n                           and L.BEG_VW_FORNECEDOR_ID =\n                               :new.BEG_VW_FORNECEDOR_ID)\n          loop\n          \n            BEG_PRC_SUP_CALCULA(RC_FRN, R_PRD);\n          \n            update BEG_SUP_LISTA_FORNECEDOR\n               set IND_PRECO_NOVO = 'Y',\n                   VLR_SUGERIDO   = R_PRD.VLR_SUGERIDO,\n                   VLR_LIQUIDO    = R_PRD.VLR_LIQUIDO,\n                   VLR_FINAL      = R_PRD.VLR_FINAL\n             where BEG_SUP_LISTA_FORNECEDOR_ID =\n                   R_PRD.BEG_SUP_LISTA_FORNECEDOR_ID;\n          \n          end loop;\n        end if;\n      end if;\n    end if;\n  end if;\n\n  commit;\n\n  BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_LISTA := false;\n\nend BEG_TRG_BIUD_SUP_FORNECEDOR;\n"}`;
    
    }
}
