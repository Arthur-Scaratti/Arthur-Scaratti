
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRODUTO
    {
        
        /// <summary>
        /// ID do plano.
        /// </summary>
        public int BEG_CEL_PLANO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Uso interno! Indica produto inserido como teste. Possibilita exclusão das tabelas reletivas a produtos (PRD). Não é listado no Compiere.
        /// </summary>
        public string IND_TESTE { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_TECNICA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_PROD_CAIXA_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica produto importado do sistema SIAD.
        /// </summary>
        public string IND_IMPORTADO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica controle de serial.
        /// </summary>
        public string IND_SERIAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica produto especial (código especial).
        /// </summary>
        public string IND_ESPECIAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica produto de encomenda.
        /// </summary>
        public string IND_ENCOMENDA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica produto com código reservado.
        /// </summary>
        public string IND_RESERVADO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica produto com código digitado manualmente.
        /// </summary>
        public string IND_MANUAL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
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
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se possui controle de voltagem.
        /// </summary>
        public string CONTROLA_VOLTAGEM { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Modelo.
        /// </summary>
        public string MODELO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se tem controle de cor.
        /// </summary>
        public string CONTROLA_COR { get; set; }
        
        /// <summary>
        /// ID da voltagem.
        /// </summary>
        public int BEG_PRD_VOLTAGEM_ID { get; set; }
            [Required]
        /// <summary>
        /// ID da unidade de medida.
        /// </summary>
        public int BEG_PRD_UNIDADE_ID { get; set; }
        
        /// <summary>
        /// ID da marca.
        /// </summary>
        public int BEG_PRD_MARCA_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do fabricante.
        /// </summary>
        public int BEG_PRD_FABRICANTE_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do tipo.
        /// </summary>
        public int BEG_PRD_TIPO_ID { get; set; }
        
        /// <summary>
        /// ID da cor.
        /// </summary>
        public int BEG_PRD_COR_ID { get; set; }
            [Required]
    [StringLength(55)]
        /// <summary>
        /// Descrição resumida.
        /// </summary>
        public string DESC_RESUMIDA { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Descrição detalhada.
        /// </summary>
        public string DESC_DETALHADA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Referência do produto.
        /// </summary>
        public string REFERENCIA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Nome do produto.
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Botão auxiliar para o Compiere. Faz a validação do cadastro do produto.
        /// </summary>
        public string BTN_VALIDA_PRODUTO { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// Código estruturado de produto DieMentz.
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }
        
        /// <summary>
        /// ID do produto pai no caso de cores e voltagens.
        /// </summary>
        public int DIE_VW_PRD_PAI_ID { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// Código de produto DieMentz.
        /// </summary>
        public string DIE_COD_PRODUTO { get; set; }
            [Required]
        /// <summary>
        /// Código do subgrupo DieMentz.
        /// </summary>
        public int DIE_PRD_SUBGRUPO_ID { get; set; }
            [Required]
        /// <summary>
        /// Código do grupo DieMentz.
        /// </summary>
        public int DIE_PRD_GRUPO_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AIUR_REPLICA_DESC { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n \n   V_OK VARCHAR2(200);\n \n  cursor busca_filhos is\n    SELECT *\n    FROM   beg_produto p\n    WHERE  p.die_vw_prd_pai_id = :NEW.beg_produto_id;\n  --\n  v_filhos    busca_filhos%rowtype;\n  \n   CURSOR C_PROD IS\n   SELECT *\n   FROM BEG_PRODUTO P\n   WHERE P.BEG_PRODUTO_ID = :NEW.beg_produto_id;\n   \n   R_PROD C_PROD%ROWTYPE;\n  \n  PRAGMA AUTONOMOUS_TRANSACTION;\nBEGIN\n  OPEN busca_filhos;\n  loop\n    fetch busca_filhos INTO v_filhos;\n    exit WHEN busca_filhos%notfound;\n    UPDATE beg_produto l\n       SET l.desc_tecnica = :NEW.desc_tecnica\n    where  l.beg_produto_id = v_filhos.beg_produto_id;\n  END loop;\n  COMMIT;\n  /*IF INSERTING THEN\n  \n   OPEN C_PROD;\n   FETCH C_PROD INTO R_PROD;\n   CLOSE C_PROD;\n      \n    SELECT BKN_PRC_INICIALIZA_ESTOQUE(R_PROD.DIE_COD_ESTRUTURADO,1000016) \n     INTO V_OK\n    FROM DUAL;\n  \n  \n  END IF;\n  commit;*/\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIU_BEG_PRODUTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  VC_IND_ACEITA_PLANO DIE_PRD_SUBGRUPO.IND_ACEITA_PLANO%type;\n  VC_DESC_UNIDADE     BEG_PRD_UNIDADE.DESCRICAO%type;\n\nbegin\n  -- Testa formato do código estruturado\n  if not REGEXP_LIKE(:new.DIE_COD_ESTRUTURADO, '^[[:upper:]]{1}[0-9]{6}$') and\n     not REGEXP_LIKE(:new.DIE_COD_ESTRUTURADO,\n                     '^[[:upper:]]{1}[0-9]{6}[[:upper:]]{2}$') then\n    RAISE_APPLICATION_ERROR(-20001, 'Código estruturado fora do padrão!');\n  end if;\n\n  ---valida tipo\n  if :NEW.BEG_PRD_TIPO_ID = 2000001 AND :NEW.DIE_PRD_GRUPO_ID <> 1000009 THEN\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Somente pode informar tipo servico quando o grupo for servico!');\n  end if;\n  -- Valida flags\n  if INSERTING or UPDATING('IND_ESPECIAL') or UPDATING('IND_ENCOMENDA') or\n     UPDATING('IND_RESERVADO') or UPDATING('IND_MANUAL') then\n\n    /* Tiago Gabriel em 10/09/2008\n    Validações adicionada.*/\n    if UPDATING('IND_RESERVADO') then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Impossível alterar marcação de Código Reservado!');\n    end if;\n\n    if UPDATING('IND_MANUAL') then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Impossível alterar marcação de Código Manual!');\n    end if;\n\n    if UPDATING('IND_ESPECIAL') and :new.IND_ESPECIAL = 'Y' then\n      :new.IND_ENCOMENDA := 'N';\n    elsif UPDATING('IND_ENCOMENDA') and :new.IND_ENCOMENDA = 'Y' then\n      :new.IND_ESPECIAL := 'N';\n    end if;\n\n    if :new.IND_ESPECIAL = 'Y' and :new.IND_ENCOMENDA = 'Y' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Produto não pode ser especial e encomenda ao mesmo tempo!');\n    end if;\n\n    if :new.IND_ESPECIAL = 'Y' or :new.IND_ENCOMENDA = 'Y' then\n      if BEG_$INP(BEG_PCK_PRD_PRODUTOS.CC_COD_ESPECIAL ||\n                  BEG_PCK_PRD_PRODUTOS.CC_CHR_SEPARADOR ||\n                  BEG_PCK_PRD_PRODUTOS.CC_COD_ENCOMENDA ||\n                  BEG_PCK_PRD_PRODUTOS.CC_CHR_SEPARADOR ||\n                  BEG_PCK_PRD_PRODUTOS.CC_COD_RESERVADO,\n                  :new.DIE_COD_PRODUTO,\n                  BEG_PCK_PRD_PRODUTOS.CC_CHR_SEPARADOR) = 0 then\n        :new.IND_MANUAL := 'Y';\n      end if;\n    end if;\n  end if;\n  -- valida codigos especiais\n  if :NEW.DIE_COD_PRODUTO in ('000','100','999') AND :NEW.IND_ESPECIAL = 'N' THEN\n     :NEW.IND_ESPECIAL := 'Y';\n  end if;\n\n  -- Validações se não está gerando produtos\n  if not BEG_PCK_PRD_PRODUTOS.VB_PRD_GERADOR then\n\n    -- Testa alteração dos campos componentes do código estruturado\n    if UPDATING('DIE_COD_PRODUTO') or UPDATING('DIE_COD_ESTRUTURADO') or\n       UPDATING('BEG_PRD_FABRICANTE_ID') then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Dados referente ao código estruturado não podem ser alterados!');\n    end if;\n\n    /*-- Testa a alteração da cor e voltagem\n    if UPDATING('BEG_PRD_COR_ID')  then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Cor não pode ser alterada em função do código estruturado!');\n    end if;*/\n\n   /* if UPDATING('CONTROLA_COR') then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Indicador de controle da cor não pode ser alterada em função do código estruturado!');\n    end if;*/\n\n    if UPDATING('BEG_PRD_VOLTAGEM_ID') then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Voltagem não pode ser alterada em função do código estruturado!');\n    end if;\n\n    if UPDATING('CONTROLA_VOLTAGEM') then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Indicador de controle da voltagem não pode ser alterada em função do código estruturado!');\n    end if;\n\n    if UPDATING('DIE_VW_PRD_PAI_ID') then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Produto pai não pode ser alterado em função do código estruturado!');\n    end if;\n\n  end if;\n\n  -- Valida o plano\n  if :new.BEG_CEL_PLANO_ID is not null then\n    select IND_ACEITA_PLANO\n      into VC_IND_ACEITA_PLANO\n      from DIE_PRD_SUBGRUPO\n     where DIE_PRD_SUBGRUPO_ID = :new.DIE_PRD_SUBGRUPO_ID;\n\n    if VC_IND_ACEITA_PLANO = 'N' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Subgrupo não permite cadastramento de plano de celular!');\n    end if;\n  end if;\n\n  -- Atualiza as datas\n  if INSERTING then\n    :new.CREATED := sysdate;\n  end if;\n  :new.UPDATED := sysdate;\n\n  -- Atualizando coluna nome\n  if UPDATING('DESC_RESUMIDA') or UPDATING('DESC_DETALHADA') or\n     UPDATING('NAME') or UPDATING('DESC_TECNICA') then\n\n    -- Código que estava originalmente na trigger BEG_TRG_BIU_PRODUTO_UPPER (ver comentário no início)\n    :new.DESC_RESUMIDA := UPPER(BEG_PCK_UTIL.CONVERTE_ACENTOS(:new.DESC_RESUMIDA));\n    if UPDATING('DESC_DETALHADA') then\n      :new.DESC_DETALHADA := UPPER(BEG_PCK_UTIL.CONVERTE_ACENTOS(:new.DESC_DETALHADA));\n      :new.name           := :new.DESC_DETALHADA;\n    end if;\n    --COMENTADO O BLOCO ABAIXO EM 02/09/2015 PARA UTILIZAR PARA O SITE.\n    /* if UPDATING('DESC_TECNICA') then\n      :new.DESC_TECNICA := UPPER(BEG_PCK_UTIL.CONVERTE_ACENTOS(:new.DESC_TECNICA));\n    end if;*/\n    if UPDATING('NAME') then\n      :new.name := UPPER(BEG_PCK_UTIL.CONVERTE_ACENTOS(:new.name));\n      --      :new.DESC_DETALHADA := :new.name;\n    end if;\n\n    -- Atualiza a descrição do produto COMERCIAL\n    --COMENTADO EM 02/09/2015 PARA NAO ALTERAR DESCRICAO ESPECÍFICA PARA O SITE\n    /* update BEG_PRD_COMERCIAL\n      set DESC_RESUMIDA  = DECODE(NVL(DESC_RESUMIDA, :old.DESC_RESUMIDA),\n                                  :old.DESC_RESUMIDA,\n                                  :new.DESC_RESUMIDA,\n                                  DESC_RESUMIDA),\n          DESC_DETALHADA = DECODE(NVL(DESC_DETALHADA, :old.DESC_DETALHADA),\n                                  :old.DESC_DETALHADA,\n                                  :new.DESC_DETALHADA,\n                                  DESC_DETALHADA)\n    where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;*/\n\n    -- Atualiza a descrição do produto SUPRIMENTO\n    update BEG_PRD_SUPRIMENTO\n       set DESC_RESUMIDA = DECODE(NVL(DESC_RESUMIDA, :old.DESC_RESUMIDA),\n                                  :old.DESC_RESUMIDA,\n                                  :new.DESC_RESUMIDA,\n                                  DESC_RESUMIDA),\n           name          = DECODE(NVL(name, :old.name),\n                                  :old.name,\n                                  :new.name,\n                                  name)\n     where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n  end if;\n\n  -- Código que estava originalmente na trigger BEG_TRG_BI_PRODUTO (ver comentário no início)\n  if INSERTING and not BEG_PCK_PRD_PRODUTOS.VB_PRD_GERADOR then\n    if :new.BEG_PRD_UNIDADE_ID is null then\n      :new.BEG_PRD_UNIDADE_ID := BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                                           :new.AD_ORG_ID,\n                                                           'Produto',\n                                                           'Geral',\n                                                           'UNIDADE_PADRAO');\n    end if;\n\n    insert into BEG_PRD_COMERCIAL\n      (BEG_PRD_COMERCIAL_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       CREATEDBY,\n       UPDATEDBY,\n       BEG_PRD_COMERCIAL_CLASS_ID,\n       BEG_PRODUTO_ID,\n       DESC_RESUMIDA,\n       DESC_DETALHADA)\n    values\n      (BEG_FNC_AD_SEQUENCE('BEG_PRD_COMERCIAL') -- beg_prd_comercial_id\n      ,\n       :new.AD_CLIENT_ID,\n       :new.AD_ORG_ID,\n       :new.UPDATEDBY -- createdby\n      ,\n       :new.UPDATEDBY,\n       TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                           :new.AD_ORG_ID,\n                                           'Produto',\n                                           'Geral',\n                                           'CLASS_COMERCIAL_PADRAO')) -- beg_prd_comercial_class_id\n      ,\n       :new.BEG_PRODUTO_ID,\n       :new.DESC_RESUMIDA,\n       :new.name); -- desc_detalhada\n\n    insert into BEG_PRD_SUPRIMENTO\n      (BEG_PRD_SUPRIMENTO_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       CREATEDBY,\n       UPDATEDBY,\n       name,\n       DESC_RESUMIDA,\n       BEG_PRD_UNIDADE_ID,\n       BEG_PRODUTO_ID,\n       BEG_PRD_SUPRIMENTO_CLASS_ID)\n    values\n      (BEG_FNC_AD_SEQUENCE('BEG_PRD_SUPRIMENTO') -- beg_prd_suprimento_id\n      ,\n       :new.AD_CLIENT_ID,\n       :new.AD_ORG_ID,\n       :new.UPDATEDBY -- createdby\n      ,\n       :new.UPDATEDBY,\n       :new.name,\n       :new.DESC_RESUMIDA,\n       :new.BEG_PRD_UNIDADE_ID,\n       :new.BEG_PRODUTO_ID,\n       TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                           :new.AD_ORG_ID,\n                                           'Produto',\n                                           'Geral',\n                                           'CLASS_SUPRIMENTO_PADRAO'))); -- beg_prd_suprimento_class_id\n\n    select DESCRICAO\n      into VC_DESC_UNIDADE\n      from BEG_PRD_UNIDADE\n     where BEG_PRD_UNIDADE_ID = :new.BEG_PRD_UNIDADE_ID;\n\n    insert into BEG_PRD_SKU\n      (BEG_PRD_SKU_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       CREATEDBY,\n       UPDATEDBY,\n       value,\n       PADRAO,\n       BEG_PRODUTO_ID,\n       BEG_PRD_UNIDADE_ID,\n       BEG_PRD_COR_ID,\n       BEG_PRD_VOLTAGEM_ID)\n    values\n      (BEG_FNC_AD_SEQUENCE('BEG_PRD_SKU') -- beg_prd_sku_id\n      ,\n       :new.AD_CLIENT_ID,\n       :new.AD_ORG_ID,\n       :new.UPDATEDBY -- createdby\n      ,\n       :new.UPDATEDBY,\n       VC_DESC_UNIDADE -- value\n      ,\n       'Y' -- padrao\n      ,\n       :new.BEG_PRODUTO_ID,\n       :new.BEG_PRD_UNIDADE_ID,\n       :new.BEG_PRD_COR_ID,\n       :new.BEG_PRD_VOLTAGEM_ID);\n\n  end if;\n\nend TRG_BIU_BEG_PRODUTO;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_LOG_BEG_PRODUTO { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  cursor cr_col is\n    select tc.ad_table_id\n         , cc.ad_column_id\n         , Upper( cc.columnname ) columnname\n         , cb.data_type\n      from ad_table         tc\n         , ad_column        cc\n         , user_tab_columns cb\n     where tc.ad_table_id         = cc.ad_table_id\n       and Upper( tc.tablename )  = cb.table_name\n       and Upper( cc.columnname ) = cb.column_name\n       and Upper( tc.tablename )  = 'BEG_PRODUTO'\n       and Upper( cc.columnname ) not in ( 'CREATED', 'CREATEDBY', 'UPDATED', 'UPDATEDBY', 'IND_TESTE' );\n\n  vc_cmd         VarChar2( 500 );\n  vc_oldvalue    ad_changelog.oldvalue%Type;\n  vc_newvalue    ad_changelog.newvalue%Type;\n\nbegin\n  -- Se disparou da geração de produtos, desconsidera\n  if BEG_PCK_PRD_Produtos.vb_prd_gerador then\n    return;\n  end if;\n\n  -- Insere os registros na tabela de log\n  insert into beg_produto_log\n  values ( 'OLD'\n         , :old.beg_produto_id,      :old.ad_client_id,       :old.ad_org_id,           :old.isactive\n         , :old.value,               :old.created,            :old.createdby,           :old.updated\n         , :old.updatedby,           :old.controla_voltagem,  :old.modelo,              :old.controla_cor\n         , :old.beg_prd_voltagem_id, :old.beg_prd_unidade_id, :old.beg_prd_marca_id,    :old.beg_prd_fabricante_id\n         , :old.beg_prd_tipo_id,     :old.beg_prd_cor_id,     :old.desc_resumida,       :old.desc_detalhada\n         , :old.referencia,          :old.name,               :old.btn_valida_produto,  :old.die_cod_produto\n         , :old.die_cod_estruturado, :old.die_prd_grupo_id,   :old.die_prd_subgrupo_id, :old.die_vw_prd_pai_id\n         , :old.beg_cel_plano_id,    :old.ind_importado,      :old.ind_serial,          :old.ind_especial\n         , :old.ind_encomenda,       :old.ind_reservado,      :old.ind_manual,           :old.desc_tecnica );\n\n  if updating then\n    insert into beg_produto_log\n    values ( 'NEW'\n           , :new.beg_produto_id,      :new.ad_client_id,       :new.ad_org_id,           :new.isactive\n           , :new.value,               :new.created,            :new.createdby,           :new.updated\n           , :new.updatedby,           :new.controla_voltagem,  :new.modelo,              :new.controla_cor\n           , :new.beg_prd_voltagem_id, :new.beg_prd_unidade_id, :new.beg_prd_marca_id,    :new.beg_prd_fabricante_id\n           , :new.beg_prd_tipo_id,     :new.beg_prd_cor_id,     :new.desc_resumida,       :new.desc_detalhada\n           , :new.referencia,          :new.name,               :new.btn_valida_produto,  :new.die_cod_produto\n           , :new.die_cod_estruturado, :new.die_prd_grupo_id,   :new.die_prd_subgrupo_id, :new.die_vw_prd_pai_id\n           , :new.beg_cel_plano_id,    :new.ind_importado,      :new.ind_serial,          :new.ind_especial\n           , :new.ind_encomenda,       :new.ind_reservado,      :new.ind_manual,           :new.desc_tecnica);\n  end if;\n\n  for r_col in cr_col loop\n    if deleting                     or\n       Updating( r_col.columnname ) then\n      -- Busca valores old e new para a coluna\n      vc_cmd := 'select ';\n      if r_col.data_type = 'NUMBER' then\n        vc_cmd := vc_cmd || 'To_Char( ' || r_col.columnname || ' )';\n      else\n        vc_cmd := vc_cmd || r_col.columnname;\n      end if;\n      vc_cmd := vc_cmd || ' from beg_produto_log where ind_registro = ''OLD''';\n      execute immediate vc_cmd\n         into vc_oldvalue;\n\n      if deleting then\n        vc_newvalue := 'EXCLUSÃO';\n      else\n        vc_cmd := 'select ';\n        if r_col.data_type = 'NUMBER' then\n          vc_cmd := vc_cmd || 'To_Char( ' || r_col.columnname || ' )';\n        else\n          vc_cmd := vc_cmd || r_col.columnname;\n        end if;\n        vc_cmd := vc_cmd || ' from beg_produto_log where ind_registro = ''NEW''';\n        execute immediate vc_cmd\n           into vc_newvalue;\n\n      end if;\n\n      if Nvl( vc_oldvalue, '^' ) <> Nvl( vc_newvalue, '^' ) or\n         vc_newvalue             =  'EXCLUSÃO'              then\n\n       if not UPDATING('DESC_TECNICA') then\n        insert into ad_changelog\n               ( ad_changelog_id\n               , ad_session_id\n               , ad_table_id\n               , ad_column_id\n               , ad_client_id\n               , ad_org_id\n               , createdby\n               , updatedby\n               , record_id\n               , oldvalue\n               , newvalue )\n        values ( BEG_FNC_AD_Sequence( 'AD_ChangeLog' ) -- ad_changelog_id\n               , beg_pck_ad_dictionary.vn_ad_session_id -- ad_session_id\n               , r_col.ad_table_id -- ad_table_id\n               , r_col.ad_column_id -- ad_column_id\n               , beg_pck_ad_dictionary.vn_ad_client_id -- ad_client_id\n               , beg_pck_ad_dictionary.vn_ad_org_id -- ad_org_id\n               , beg_pck_ad_dictionary.vn_ad_user_id -- createdby\n               , beg_pck_ad_dictionary.vn_ad_user_id -- updatedby\n               , Nvl( :new.beg_produto_id, :old.beg_produto_id ) -- record_id\n               , vc_oldvalue\n               , vc_newvalue );\n        end if;\n      end if;\n    end if;\n  end loop;\n\n  delete from beg_produto_log;\n\nend TRG_LOG_BEG_PRODUTO;\n"}`;
    
    }
}
