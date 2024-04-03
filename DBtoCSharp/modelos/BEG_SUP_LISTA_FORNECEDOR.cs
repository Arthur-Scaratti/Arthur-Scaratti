
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_SUP_LISTA_FORNECEDOR
    {
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_MESES_GARANTIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PER_DIF_ICMS { get; set; }
            [Required]
        /// <summary>
        /// aliquota icms para calculo da st
        /// </summary>
        public int PERC_ICMS_CALC_ST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COEFICIENTE { get; set; }
        
        /// <summary>
        /// Percentual de redução de icms
        /// </summary>
        public int PERC_REDUCAO_ICMS { get; set; }
        
        /// <summary>
        /// indicador de monofasico nao calcula ST 
        /// </summary>
        public string IND_MONOFASICO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string DES_REFERENCIA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PADRAO { get; set; }
        
        /// <summary>
        /// Tempo de reposicao da mercadoria apos emissao ordem de compra
        /// </summary>
        public int TEMPO_REPOSICAO { get; set; }
        
        /// <summary>
        /// numero de dias para o estoque de seguranca
        /// </summary>
        public int DIAS_EST_SEGURANCA { get; set; }
            [Required]
        /// <summary>
        /// Percentual Pis
        /// </summary>
        public int PER_PIS { get; set; }
            [Required]
        /// <summary>
        /// Percentual Cofins
        /// </summary>
        public int PER_COFINS { get; set; }
            [Required]
        /// <summary>
        /// Valor de venda praticado pela concorrencia
        /// </summary>
        public int VLR_CONCORRENCIA1 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CONCORRENCIA2 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MARGEM_BRUTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MONTAGEM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MARGEM_ATU { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MARGEM_SUG_AV { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MARGEM_SUG_AP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MEDIO_CONCORRENCIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SUGERIDO_PRAZO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_MAX_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_NEGOCIADO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PER_FRETE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do preco de compra
        /// </summary>
        public int BEG_SUP_LISTA_FORNECEDOR_ID { get; set; }
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
        /// Valor do bruto de compra
        /// </summary>
        public int VLR_BRUTO { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do ICMS
        /// </summary>
        public int ALQ_ICMS { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do ICMS da substituic?o tributaria
        /// </summary>
        public int ALQ_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de calculo do IPI
        /// </summary>
        public int ALQ_IPI { get; set; }
            [Required]
        /// <summary>
        /// Valor do ICMS da substituic?o tributaria
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// Percentual de desconto
        /// </summary>
        public int PER_DESCONTO { get; set; }
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
        /// Observac?o de outras despesas
        /// </summary>
        public string OBS_OUTRAS_DESPESAS { get; set; }
            [Required]
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do SKU
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Referencia do produto junto do fornecedor
        /// </summary>
        public string REFERENCIA { get; set; }
        
        /// <summary>
        /// Data de referencia dos valores
        /// </summary>
        public string DT_REFERENCIA { get; set; }
        
        /// <summary>
        /// Data de inicio da vigencia do preco novo
        /// </summary>
        public string DT_INICIO { get; set; }
            [Required]
        /// <summary>
        /// Valor sugerido de acordo com o custo na data de referencia
        /// </summary>
        public int VLR_SUGERIDO { get; set; }
            [Required]
        /// <summary>
        /// Preco vigente na data de referencia
        /// </summary>
        public int VLR_VIGENTE { get; set; }
            [Required]
        /// <summary>
        /// Preco novo a ser gerado na tabela
        /// </summary>
        public int VLR_PRECO { get; set; }
            [Required]
        /// <summary>
        /// Percentual de variac?o do preco vigente para o preco sugerido
        /// </summary>
        public int PER_VARIACAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o preco vigente e de uma promoc?o
        /// </summary>
        public string IND_PROMOCAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que deve gerar o preco novo
        /// </summary>
        public string IND_PRECO_NOVO { get; set; }
        
        /// <summary>
        /// Data da ultima transferencia de precos
        /// </summary>
        public string DT_TRANSFERENCIA { get; set; }
        
        /// <summary>
        /// ID da promoc?o
        /// </summary>
        public int BEG_PRD_PROMOCAO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUIDO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FINAL { get; set; }
        
        /// <summary>
        /// ID do conjunto
        /// </summary>
        public int BEG_PRD_CONJUNTO_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AUD_SUP_LISTA_FORNEC { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger usada somente com a finalidade de fazer o Log da BEG_SUP_FORNECEDOR\n   Modulo.......: FIS - Fiscal\n   Analista.....:\n   Alteracoes:\n   Data        Desenvolvedor  Alteracao\n   26/02/2015  Magdiel Lopes Criação\n  --------------------------------------------------------------------------------------------------- */\n  cursor cr_col is\n    select t.ad_table_id\n         , c.ad_column_id\n         , Upper( c.columnname ) columnname\n      from ad_table  t\n         , ad_column c\n     where t.ad_table_id = c.ad_table_id\n       and t.tablename   = 'BEG_SUP_LISTA_FORNECEDOR'\n       and Upper( c.columnname ) not in ( 'CREATED', 'CREATEDBY', 'UPDATED', 'UPDATEDBY' );\n\n  vc_oldvalue ad_changelog.oldvalue%Type;\n  vc_newvalue ad_changelog.newvalue%Type;\n\nbegin\n  -- Insere os registros na tabela de log\n  insert into BEG_SUP_LISTA_FORNECEDOR_LOG\n  values\n    ('OLD', -- IND_REGISTRO\n   :OLD.beg_sup_lista_fornecedor_id,\n   :OLD.ad_client_id,\n   :OLD.ad_org_id,\n   :OLD.isactive,\n   :OLD.created,\n   :OLD.createdby,\n   :OLD.updated,\n   :OLD.updatedby,\n   :OLD.vlr_bruto,\n   :OLD.alq_icms,\n   :OLD.alq_icms_subst,\n   :OLD.alq_ipi,\n   :OLD.vlr_icms_subst,\n   :OLD.per_desconto,\n   :OLD.per_despesas_financeiras,\n   :OLD.per_outras_despesas,\n   :OLD.obs_outras_despesas,\n   :OLD.beg_produto_id,\n   :OLD.beg_prd_sku_id,\n   :OLD.beg_vw_fornecedor_id,\n   :OLD.referencia,\n   :OLD.dt_referencia,\n   :OLD.dt_inicio,\n   :OLD.vlr_sugerido,\n   :OLD.vlr_vigente,\n   :OLD.vlr_preco,\n   :OLD.per_variacao,\n   :OLD.ind_promocao,\n   :OLD.ind_preco_novo,\n   :OLD.dt_transferencia,\n   :OLD.beg_prd_promocao_id,\n   :OLD.vlr_liquido,\n   :OLD.per_dif_icms,\n   :OLD.vlr_final,\n   :OLD.per_frete,\n   :OLD.vlr_frete,\n   :OLD.vlr_negociado,\n   :OLD.die_cod_estruturado,\n   :OLD.nro_meses_garantia,\n   :OLD.beg_prd_conjunto_id,\n   :OLD.perc_reducao_icms,\n   :old.ind_monofasico,\n   :OLD.Tempo_Reposicao,\n   :OLD.DIAS_EST_SEGURANCA,\n   :OLD.Per_Pis,\n   :OLD.per_cofins,\n   :OLD.VLR_CONCORRENCIA1,\n   :OLD.VLR_CONCORRENCIA2,\n   :OLD.VLR_MEDIO_CONCORRENCIA,\n   :OLD.VLR_SUGERIDO_PRAZO,\n   :OLD.PERC_MAX_DESCONTO,\n   :OLD.PERC_ICMS_CALC_ST,\n   :OLD.COEFICIENTE,\n   :OLD.COMISSAO,\n   :OLD.MARGEM_BRUTA,\n   :OLD.MONTAGEM\n   );\n\n\n\n\n\n  if updating then\n    insert into BEG_SUP_LISTA_FORNECEDOR_LOG\n    values\n      ('NEW', -- IND_REGISTRO\n   :NEW.beg_sup_lista_fornecedor_id,\n   :NEW.ad_client_id,\n   :NEW.ad_org_id,\n   :NEW.isactive,\n   :NEW.created,\n   :NEW.createdby,\n   :NEW.updated,\n   :NEW.updatedby,\n   :NEW.vlr_bruto,\n   :NEW.alq_icms,\n   :NEW.alq_icms_subst,\n   :NEW.alq_ipi,\n   :NEW.vlr_icms_subst,\n   :NEW.per_desconto,\n   :NEW.per_despesas_financeiras,\n   :NEW.per_outras_despesas,\n   :NEW.obs_outras_despesas,\n   :NEW.beg_produto_id,\n   :NEW.beg_prd_sku_id,\n   :NEW.beg_vw_fornecedor_id,\n   :NEW.referencia,\n   :NEW.dt_referencia,\n   :NEW.dt_inicio,\n   :NEW.vlr_sugerido,\n   :NEW.vlr_vigente,\n   :NEW.vlr_preco,\n   :NEW.per_variacao,\n   :NEW.ind_promocao,\n   :NEW.ind_preco_novo,\n   :NEW.dt_transferencia,\n   :NEW.beg_prd_promocao_id,\n   :NEW.vlr_liquido,\n   :NEW.per_dif_icms,\n   :NEW.vlr_final,\n   :NEW.per_frete,\n   :NEW.vlr_frete,\n   :NEW.vlr_negociado,\n   :NEW.die_cod_estruturado,\n   :NEW.nro_meses_garantia,\n   :NEW.beg_prd_conjunto_id,\n   :NEW.perc_reducao_icms,\n   :new.ind_monofasico,\n   :NEW.Tempo_Reposicao,\n   :NEW.Dias_Est_Seguranca,\n   :NEW.Per_Pis,\n   :new.per_cofins,\n   :NEW.VLR_CONCORRENCIA1,\n   :NEW.VLR_CONCORRENCIA2,\n   :NEW.VLR_MEDIO_CONCORRENCIA,\n   :NEW.VLR_SUGERIDO_PRAZO,\n   :NEW.PERC_MAX_DESCONTO,\n   :NEW.PERC_ICMS_CALC_ST,\n   :NEW.COEFICIENTE,\n   :NEW.COMISSAO,\n   :NEW.MARGEM_BRUTA,\n   :NEW.MONTAGEM\n   );\n\n  end if;\n\n\n  for r_col in cr_col loop\n    if deleting                     or\n       Updating( r_col.columnname ) then\n      -- Busca valores old e new para a coluna\n      execute immediate 'select ' || r_col.columnname || ' from BEG_SUP_LISTA_FORNECEDOR_LOG where ind_registro = ''OLD'''\n         into vc_oldvalue;\n\n      if deleting then\n        vc_newvalue := null;\n      else\n        execute immediate 'select ' || r_col.columnname || ' from BEG_SUP_LISTA_FORNECEDOR_LOG where ind_registro = ''NEW'''\n           into vc_newvalue;\n      end if;\n\n      if Nvl( vc_oldvalue, '^' ) <> Nvl( vc_newvalue, '^' ) then\n\n        insert into ad_changelog\n               ( ad_changelog_id\n               , ad_session_id\n               , ad_table_id\n               , ad_column_id\n               , ad_client_id\n               , ad_org_id\n               , createdby\n               , updatedby\n               , record_id\n               , oldvalue\n               , newvalue )\n        values ( beg_fnc_ad_sequence( 'AD_ChangeLog' ) -- ad_changelog_id\n               , beg_pck_ad_dictionary.vn_ad_session_id -- ad_session_id\n               , r_col.ad_table_id -- ad_table_id\n               , r_col.ad_column_id -- ad_column_id\n               , beg_pck_ad_dictionary.vn_ad_client_id -- ad_client_id\n               , beg_pck_ad_dictionary.vn_ad_org_id -- ad_org_id\n               , beg_pck_ad_dictionary.vn_ad_user_id -- createdby\n               , beg_pck_ad_dictionary.vn_ad_user_id -- updatedby\n               , Nvl( :new.BEG_SUP_LISTA_FORNECEDOR_ID, :old.BEG_SUP_LISTA_FORNECEDOR_ID ) -- record_id\n               , vc_oldvalue\n               , vc_newvalue );\n\n      end if;\n    end if;\n  end loop;\n\n  delete from BEG_SUP_LISTA_FORNECEDOR_LOG;\n\nend BEG_SUP_LISTA_FORNECEDOR;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_SUP_LISTA_FORN { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  VC_MSG_ERRO         varchar2(1000);\n  VN_DUMMY            number;\n  VN_BEG_PRODUTO_ID   BEG_PRODUTO.BEG_PRODUTO_ID%type;\n  VN_BEG_CEL_PLANO_ID BEG_PRODUTO.BEG_CEL_PLANO_ID%type;\n  VN_TOTAL_ICMS_PROP  number(18,4);\n  vn_total_icms_st  numBer(18,4);\n  V_ALIQ_ICMS_ST    NUMBER(18,4);\n\n  RC_FRN BEG_SUP_FORNECEDOR%rowtype;\n  RC_PRD BEG_SUP_LISTA_FORNECEDOR%rowtype;\n  CURSOR busca_mva IS\n    SELECT n.mva\n    FROM   beg_prd_contabil p,\n           beg_prd_ncm n\n    WHERE  p.beg_produto_id = :new.beg_produto_id\n    AND    n.beg_prd_ncm_id = p.beg_prd_ncm_id;\n  --\n  v_mva   busca_mva%rowtype;\n  --\n  CURSOR busca_uf_forn IS\n    SELECT p.beg_vw_uf_id\n    FROM   beg_pessoa p\n    WHERE  p.beg_pessoa_id = :new.beg_vw_fornecedor_id;\n  --\n  v_uf      busca_uf_forn%rowtype;\n  --\n  CURSOR busca_aliqs IS\n    SELECT u.aliq_interna,\n           u.aliq_interest,\n           p.beg_vw_uf_id uf_forn,\n           pf.beg_vw_uf_id uf_fil\n    FROM   beg_pessoa p,\n           beg_uf u,\n           beg_dado_filial d,\n           beg_pessoa pf\n    WHERE  p.beg_pessoa_id = :NEW.BEG_VW_FORNECEDOR_ID\n    and    u.beg_uf_id = p.beg_vw_uf_id\n    AND    d.ad_org_id = :NEW.ad_org_id\n    AND    pf.beg_pessoa_id = d.beg_pessoa_id;\n  --\n  v_aliqs      busca_aliqs%rowtype;\n  --\nbegin\n  -- Se não está processando do vínculo com fornecedor, valida os campos\n  if not BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_FORN\n     and not BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_SKU then\n\n    if UPDATING\n       and :new.BEG_PRODUTO_ID <> :old.BEG_PRODUTO_ID then\n      begin\n        select BEG_PRD_SKU_ID\n          into :new.BEG_PRD_SKU_ID\n          from BEG_PRD_SKU\n         where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n           and PADRAO = 'Y';\n\n      exception\n        when NO_DATA_FOUND then\n          VC_MSG_ERRO := 'SKU padrão não encontrado.';\n          goto FIM;\n\n        when TOO_MANY_ROWS then\n          VC_MSG_ERRO := 'SKU padrão duplicado.';\n          goto FIM;\n\n      end;\n\n    end if;\n    if inserting or updating then\n\n\n    IF :NEW.PER_FRETE > 0 THEN\n\n      :NEW.VLR_FRETE := (:NEW.VLR_BRUTO * (1+(nvl(:NEW.alq_ipi,0)/100)))* (nvl(:NEW.PER_FRETE,0)/100) ;\n\n    END IF;\n\n    IF :NEW.ALQ_ICMS > 0 THEN\n\n       :NEW.PERC_ICMS_CALC_ST := :NEW.ALQ_ICMS;\n\n    END IF;\n\n      OPEN busca_aliqs;\n      fetch busca_aliqs INTO v_aliqs;\n      CLOSE busca_aliqs;\n      open  busca_mva;\n      fetch busca_mva into v_mva;\n      close busca_mva;\n      open  busca_uf_forn;\n      fetch busca_uf_forn into v_uf;\n      close busca_uf_forn;\n      V_ALIQ_ICMS_ST := BEG_FNC_FIS_MVAAJ_RS(v_uf.beg_vw_uf_id,v_mva.mva,:new.PERC_ICMS_CALC_ST);\n      if V_ALIQ_ICMS_ST > 0 and nvl(:NEW.IND_MONOFASICO,'N') = 'N'  then\n        VN_TOTAL_ICMS_PROP := :new.vlr_bruto;\n        VN_TOTAL_ICMS_PROP := VN_TOTAL_ICMS_PROP * (nvl(:NEW.PERC_ICMS_CALC_ST,0) / 100);\n        vn_total_icms_st   := :new.vlr_bruto;\n        vn_total_icms_st   := vn_total_icms_st * (1+(nvl(:NEW.alq_ipi,0)/100));\n        vn_total_icms_st   := vn_total_icms_st * (1+ (nvl(V_ALIQ_ICMS_ST,0) / 100));\n        vn_total_icms_st   := vn_total_icms_st * (nvl(/*v_aliqs.aliq_interna*/17.5,0) /100);\n  --RAISE_APPLICATION_ERROR(-20501,'ICMS' ||:NEW.BEG_VW_FORNECEDOR_ID||' ' );\n        vn_total_icms_st   := vn_total_icms_st - vn_total_icms_prop;\n        :NEW.VLR_ICMS_SUBST := vn_total_icms_st;\n\n        if  (:NEW.VLR_BRUTO + (nvl(:NEW.VLR_BRUTO,0) * NVL(:new.alq_ipi,0)/100)) = 0 then\n          :new.alq_icms_subst := NVL(vn_total_icms_st,0)* 100/1;\n        else\n         :new.alq_icms_subst := NVL(vn_total_icms_st,0)* 100/(:NEW.VLR_BRUTO + (NVL(:NEW.VLR_BRUTO,0) * NVL(:new.alq_ipi,0)/100));\n\n        end if;\n      ELSE\n      :new.alq_icms_subst := 0;\n      :new.VLR_ICMS_SUBST := 0;\n      end if;\n    end if;\n\n    if INSERTING then\n      if :new.BEG_PRD_SKU_ID is null then\n        begin\n          select BEG_PRD_SKU_ID\n            into :new.BEG_PRD_SKU_ID\n            from BEG_PRD_SKU\n           where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n             and PADRAO = 'Y';\n\n        exception\n          when NO_DATA_FOUND then\n            VC_MSG_ERRO := 'SKU não informado e padrão não encontrado!';\n            goto FIM;\n\n          when TOO_MANY_ROWS then\n            VC_MSG_ERRO := 'SKU padrão duplicado!';\n            goto FIM;\n\n        end;\n\n      else\n\n        begin\n          select BEG_PRODUTO_ID\n            into VN_BEG_PRODUTO_ID\n            from BEG_PRD_SKU\n           where BEG_PRD_SKU_ID = :new.BEG_PRD_SKU_ID;\n\n        exception\n          when NO_DATA_FOUND then\n            VC_MSG_ERRO := 'SKU não encontrado.';\n            goto FIM;\n\n          when TOO_MANY_ROWS then\n            VC_MSG_ERRO := 'SKU duplicado.';\n            goto FIM;\n\n        end;\n\n        if :new.BEG_PRODUTO_ID <> VN_BEG_PRODUTO_ID then\n          VC_MSG_ERRO := 'SKU informado não pertence ao produto.';\n          goto FIM;\n        end if;\n      end if;\n\n    end if;\n\n    -- Atualiza o vínculo de produto com fornecedor caso não exista\n    BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_PRECO := true;\n\n    if INSERTING\n       or (UPDATING and :new.BEG_PRODUTO_ID <> :old.BEG_PRODUTO_ID) then\n\n      -- Verifica se existe lista para o novo fornecedor\n      select count(1)\n        into VN_DUMMY\n        from BEG_PRD_FORNECEDOR\n       where BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID\n         and BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n\n      -- Se trocou o fornecedor insere caso não exista e troca em todos os preços\n      if UPDATING then\n\n        if VN_DUMMY = 0 then\n          update BEG_PRD_FORNECEDOR\n             set BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n           where BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID\n             and BEG_PRODUTO_ID = :old.BEG_PRODUTO_ID;\n        end if;\n\n        VN_DUMMY := sql%rowcount;\n\n      end if;\n\n      if VN_DUMMY = 0 then\n\n        insert into BEG_PRD_FORNECEDOR PRD_FRN\n          (PRD_FRN.BEG_PRD_FORNECEDOR_ID,\n           PRD_FRN.AD_CLIENT_ID,\n           PRD_FRN.AD_ORG_ID,\n           PRD_FRN.CREATEDBY,\n           PRD_FRN.UPDATEDBY,\n           PRD_FRN.BEG_VW_FORNECEDOR_ID,\n           PRD_FRN.BEG_PRODUTO_ID)\n          select BEG_FNC_AD_SEQUENCE('BEG_PRD_FORNECEDOR'), --beg_prd_fornecedor_id\n                 :new.AD_CLIENT_ID, -- ad_client_id\n                 :new.AD_ORG_ID, -- ad_org_id\n                 :new.UPDATEDBY, -- createdby\n                 :new.UPDATEDBY, -- updatedby\n                 :new.BEG_VW_FORNECEDOR_ID, -- beg_vw_fornecedor_id\n                 :new.BEG_PRODUTO_ID -- beg_produto_id\n            from DUAL\n           where not exists\n           (select 1\n                    from BEG_PRD_FORNECEDOR PRD\n                   where PRD.BEG_VW_FORNECEDOR_ID =\n                         :new.BEG_VW_FORNECEDOR_ID\n                     and PRD.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID);\n\n      end if;\n\n    end if;\n\n    if NVL(:new.REFERENCIA, '^') <> NVL(:old.REFERENCIA, '^') then\n      update BEG_PRD_FORNECEDOR\n         set REFERENCIA = :new.REFERENCIA\n       where BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID\n         and BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n    end if;\n\n    BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_PRECO := false;\n\n  end if;\n\n  if not BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_LISTA then\n    -- Calcula e inicializa os valores\n    select F.*\n      into RC_FRN\n      from BEG_SUP_FORNECEDOR F\n     where F.AD_ORG_ID =\n           (select max(FF.AD_ORG_ID)\n              from BEG_SUP_FORNECEDOR FF,\n                   BEG_GER_FILIAL     FL\n             where FF.AD_CLIENT_ID = FL.AD_CLIENT_ID\n               and FF.BEG_VW_FORNECEDOR_ID = F.BEG_VW_FORNECEDOR_ID\n               and FF.AD_ORG_ID in (FL.AD_ORG_ID_GERAL, :new.AD_ORG_ID))\n       and F.BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID;\n\n    RC_PRD.AD_ORG_ID                := :new.AD_ORG_ID;\n    RC_PRD.VLR_BRUTO                := :new.VLR_BRUTO;\n    RC_PRD.PER_DESCONTO             := :new.PER_DESCONTO;\n    RC_PRD.PER_DESPESAS_FINANCEIRAS := :new.PER_DESPESAS_FINANCEIRAS;\n    RC_PRD.PER_OUTRAS_DESPESAS      := :new.PER_OUTRAS_DESPESAS;\n    RC_PRD.ALQ_IPI                  := :new.ALQ_IPI;\n    RC_PRD.ALQ_ICMS_SUBST           := :NEW.ALQ_ICMS_SUBST;\n    RC_PRD.VLR_ICMS_SUBST           := :new.VLR_ICMS_SUBST;\n    RC_PRD.PER_FRETE                := :new.PER_FRETE;\n    RC_PRD.VLR_FRETE                := :new.VLR_FRETE;\n    RC_PRD.PER_DIF_ICMS             := :new.PER_DIF_ICMS;\n    RC_PRD.BEG_PRODUTO_ID           := :new.BEG_PRODUTO_ID;\n    RC_PRD.BEG_PRD_SKU_ID           := :new.BEG_PRD_SKU_ID;\n    RC_PRD.VLR_NEGOCIADO            := :new.VLR_NEGOCIADO;\n    RC_PRD.PER_PIS                  := :new.PER_PIS;\n    RC_PRD.PER_COFINS               := :new.PER_COFINS;\n    RC_PRD.ALQ_ICMS                 := :NEW.ALQ_ICMS;\n\n    --\n    --\n    BEG_PRC_SUP_CALCULA(RC_FRN, RC_PRD);\n\n    :new.VLR_SUGERIDO := RC_PRD.VLR_SUGERIDO;\n    :new.VLR_LIQUIDO  := RC_PRD.VLR_LIQUIDO;\n    :new.VLR_FINAL    := RC_PRD.VLR_FINAL;\n    :NEW.VLR_SUGERIDO_PRAZO := RC_PRD.VLR_SUGERIDO_PRAZO;\n    :NEW.PERC_MAX_DESCONTO  := RC_PRD.PERC_MAX_DESCONTO;\n    :NEW.COEFICIENTE := RC_PRD.COEFICIENTE;\n    :NEW.COMISSAO := RC_PRD.COMISSAO;\n    :NEW.MARGEM_BRUTA := RC_PRD.MARGEM_BRUTA;\n    :NEW.MONTAGEM := RC_PRD.MONTAGEM;\n\n\n  end if;\n\n  -- Busca plano padrão para habilitação\n  select BEG_CEL_PLANO_ID\n    into VN_BEG_CEL_PLANO_ID\n    from BEG_PRODUTO\n   where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n\n  :new.DT_REFERENCIA := TRUNC(sysdate);\n\n  :new.VLR_VIGENTE := BEG_FNC_PRD_PRECO(0,\n                                        :new.BEG_PRODUTO_ID,\n                                        :new.BEG_PRD_SKU_ID,\n                                        VN_BEG_CEL_PLANO_ID,\n                                        'C');\n\n  :new.IND_PROMOCAO := BEG_FNC_PRD_PROMOCAO(:new.AD_ORG_ID,\n                                            :new.BEG_PRODUTO_ID,\n                                            :new.BEG_PRD_SKU_ID,\n                                            VN_BEG_CEL_PLANO_ID);\n\n  :new.PER_VARIACAO := BEG_FNC_GER_VARIACAO(:new.VLR_SUGERIDO,\n                                            :new.VLR_VIGENTE);\n\n\n\n  :NEW.VLR_MARGEM_ATU := ROUND((((:new.VLR_VIGENTE - ((:new.VLR_VIGENTE*(:NEW.PER_PIS+:NEW.ALQ_ICMS))/100))-beg_fnc_cst_valor(1000016,:NEW.BEG_PRODUTO_ID,:NEW.BEG_PRD_SKU_ID))/CASE WHEN :NEW.VLR_VIGENTE= 0 THEN 1 ELSE :NEW.VLR_VIGENTE END )*100,2);\n  :NEW.VLR_MARGEM_SUG_AV := ROUND((((:new.Vlr_Sugerido - ((:new.Vlr_Sugerido*(:NEW.PER_PIS+:NEW.ALQ_ICMS))/100))-:NEW.VLR_FINAL)/CASE WHEN :NEW.Vlr_Sugerido= 0 THEN 1 ELSE :NEW.Vlr_Sugerido END)*100,2);\n  :NEW.VLR_MARGEM_SUG_AP := ROUND((((:new.Vlr_Sugerido_Prazo - ((:new.Vlr_Sugerido_Prazo*(:NEW.PER_PIS+:NEW.ALQ_ICMS))/100))-:NEW.VLR_FINAL)/CASE WHEN :NEW.Vlr_Sugerido_Prazo= 0 THEN 1 ELSE :NEW.Vlr_Sugerido_Prazo END)*100,2);\n\n\n  if NVL(:new.IND_PRECO_NOVO, 'N') = 'Y' then\n\n    if :new.PER_VARIACAO = 0\n       and BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_LISTA then\n      :new.VLR_PRECO := 0;\n    else\n      if NVL(:new.VLR_PRECO, 0) = 0 then\n        :new.VLR_PRECO := NVL(:new.VLR_SUGERIDO, 0);\n      end if;\n    end if;\n\n  else\n    :new.VLR_PRECO := 0;\n  end if;\n\n  if NVL(:new.VLR_PRECO, 0) > 0 then\n    if NVL(:new.VLR_PRECO, 0) = :new.VLR_VIGENTE then\n      if BEG_PCK_SUP_SUPRIMENTOS.VB_PROC_LISTA then\n        :new.VLR_PRECO           := 0;\n        :new.DT_INICIO           := null;\n        :new.IND_PRECO_NOVO      := 'N';\n        :new.BEG_PRD_PROMOCAO_ID := null;\n      else\n        VC_MSG_ERRO := 'Preço novo igual ao preço vigente!';\n      end if;\n      goto FIM;\n    end if;\n\n    if :new.DT_INICIO is null then\n      if TO_CHAR(:new.DT_INICIO, 'D') = '7' then\n        :new.DT_INICIO := TRUNC(sysdate);\n      else\n        :new.DT_INICIO := TRUNC(sysdate +\n                                (7 - TO_NUMBER(TO_CHAR(sysdate, 'D'))));\n      end if;\n    else\n      :new.DT_INICIO := TRUNC(:new.DT_INICIO);\n    end if;\n\n    --:new.DT_INICIO := TRUNC(NVL(:new.DT_INICIO, NEXT_DAY(sysdate, 'SAT')));\n\n   /* if :new.DT_INICIO = TRUNC(sysdate) then\n      VC_MSG_ERRO := 'Data de início deve ser maior que o dia de hoje!';\n      goto FIM;\n    end if;*/\n\n    if :new.BEG_PRD_PROMOCAO_ID is not null then\n      select count(1)\n        into VN_DUMMY\n        from BEG_PRD_PROMOCAO\n       where TRUNC(sysdate) between DT_INICIO and\n             NVL(DT_FIM, TRUNC(sysdate))\n         and ISACTIVE = 'Y'\n         and BEG_PRD_PROMOCAO_ID = :new.BEG_PRD_PROMOCAO_ID;\n\n      if VN_DUMMY = 0 then\n        VC_MSG_ERRO := 'Promoção inativa ou fora de validade!';\n        goto FIM;\n      end if;\n    end if;\n\n  else\n    :new.DT_INICIO           := null;\n    :new.IND_PRECO_NOVO      := 'N';\n    :new.BEG_PRD_PROMOCAO_ID := null;\n  end if;\n  :new.VLR_SUGERIDO := NVL(:new.VLR_SUGERIDO, 0);\n  :new.PER_DIF_ICMS := NVL(:new.PER_DIF_ICMS, 0);\n\n\n  if :new.vlr_concorrencia1 > 0 and :new.vlr_concorrencia2 > 0 then\n\n   :new.vlr_medio_concorrencia := round((:new.vlr_concorrencia1+ :new.vlr_concorrencia2)/2,2);\n\n  end if;\n\n\n  --Atualizando codigo estruturado do produto\n  select DIE_COD_ESTRUTURADO\n    into :new.DIE_COD_ESTRUTURADO\n    from BEG_PRODUTO A\n   where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend BEG_TRG_BIU_SUP_LISTA_FORN;\n"}`;
    
    }
}
