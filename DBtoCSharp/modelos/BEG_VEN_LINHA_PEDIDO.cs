
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_LINHA_PEDIDO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ITEPED_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Tipo de Pedido: V-Venda, E-Estoque solicitado pela loja, D-Distribuicao pela matriz
        /// </summary>
        public string TP_PED { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indicativo para validar reserva para pedido de ressuprimento
        /// </summary>
        public string IND_RES_ESTOQUE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_LINHA_PEDIDO_ID { get; set; }
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
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_LINHA_PEDIDO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QUANTIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_UNITARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTREGA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_ORDEM_COMPRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PRD_PRECO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ALTERA_DESCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_FALTANTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_UNIT_SUGERIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_DISPONIVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERCENTUAL_COMISSAO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BI_LINHA_PEDIDO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n\n  v_id   number(11);\n  V_OK   char(2);\n  V_CLI  NUMBER(11);\n  V_QTDE NUMBER;\n\n  cursor BUSCA_SALDO is\n    select ES.qtd_disponivel, ES.CONTROLA_VOLTAGEM, ES.BEG_PRD_VOLTAGEM_ID\n      from BEG_VW_PRODUTO_GERAL ES\n     where ES.beg_produto_id = :NEW.BEG_VW_PRD_PRECO_ID\n       AND ES.ad_org_id = 1000016\n       AND ES.BEG_EST_ALMOXARIFADO_ID = 2000093;\n\n  ---\n  V_SALDO BUSCA_SALDO%ROWTYPE;\n  ----\n  cursor BUSCA_SALDO_LJ is\n    select sum((F.SALDO) + nvl(f.TRANSITO, 0)) saldo\n      from BEG_PRODUTO           A,\n           BEG_PRD_SKU           B,\n           BEG_PRD_UNIDADE       D,\n           DIE_PRD_SUBGRUPO      E,\n           BEG_DIE_DISTRIB       F,\n           BEG_DADO_FILIAL       G,\n           BEG_GER_TIPO_FILIAL   H,\n           BKN_VW_RESERVA_FILIAL RF\n     where B.BEG_PRODUTO_ID = A.BEG_PRODUTO_ID\n       and A.BEG_PRD_UNIDADE_ID = D.BEG_PRD_UNIDADE_ID\n       and A.DIE_PRD_SUBGRUPO_ID = E.DIE_PRD_SUBGRUPO_ID\n       and A.BEG_PRODUTO_ID = F.BEG_PRODUTO_ID(+)\n       and B.BEG_PRD_SKU_ID(+) = F.BEG_PRD_SKU_ID\n       and G.AD_ORG_ID(+) = F.AD_ORG_ID\n       and G.BEG_GER_TIPO_FILIAL_ID = H.BEG_GER_TIPO_FILIAL_ID\n       and a.beg_produto_id = :NEW.BEG_VW_PRD_PRECO_ID\n       AND RF.AD_ORG_ID(+) = F.ad_org_id\n       AND RF.BEG_VW_PRD_PRECO_ID(+) = F.BEG_PRODUTO_ID\n       AND RF.BEG_PRD_SKU_ID(+) = F.BEG_PRD_SKU_ID\n       and g.BEG_GER_TIPO_FILIAL_ID <> 1000004\n       and g.beg_pessoa_id = V_CLI\n    /* group by g.value, D.value, E.name, f.TRANSITO*/\n    ;\n\n  ---\n  V_SALLJ BUSCA_SALDO_LJ%ROWTYPE;\n\n  ---\n  CURSOR C1 IS\n    SELECT P.*\n      FROM BEG_VEN_PEDIDO P\n     WHERE P.BEG_VEN_PEDIDO_ID = :NEW.BEG_VEN_PEDIDO_ID;\n  --\n  R_C1 C1%ROWTYPE;\n\n  ---\n  CURSOR BUSCA_USU IS\n    SELECT U.IND_COMPRADOR, U.AD_ORG_ID\n      FROM BEG_APEX_USER U\n     WHERE U.AD_USER_ID = :NEW.CREATEDBY;\n\n  R_USU BUSCA_USU%ROWTYPE;\n  --\n  cursor BUSCA_MAX IS\n    select f.beg_filial_id,\n           df.beg_pessoa_id,\n           m.die_prd_subgrupo_id,\n           pR.beg_produto_id,\n           DECODE(pm.qtde_maxima, NULL, m.qtde_maxima, pm.qtde_maxima) QTD_MAXIMA,\n           DECODE(pm.qtde_minima, NULL, m.qtde_minima, pm.qtde_minima) QTD_Minima\n      from DIE_PADRAO_LOJA       l,\n           DIE_PADRAO_LJ_FILIAIS f,\n           DIE_PRD_SUB_MAXIMO    m,\n           DIE_PRD_PROD_MAXIMO   pm,\n           beg_dado_filial       df,\n           BEG_PRODUTO           PR\n     where l.die_padrao_loja_id = m.die_padrao_loja_id\n       AND PR.DIE_PRD_SUBGRUPO_ID = M.DIE_PRD_SUBGRUPO_ID\n       and l.die_padrao_loja_id = f.die_padrao_loja_id(+)\n       and PR.BEG_PRODUTO_ID = PM.BEG_PRODUTO_ID(+)\n       and f.isactive = 'Y'\n       and m.isactive = 'Y'\n       and f.beg_filial_id = df.ad_org_id\n       AND DF.BEG_PESSOA_ID = V_CLI\n       and pr.beg_produto_id = :NEW.BEG_VW_PRD_PRECO_ID;\n  R_MAX BUSCA_MAX%ROWTYPE;\n\n  cursor SALDO_PED IS\n\n    SELECT SUM(lp.quantidade) QUANTIDADE\n\n      FROM BEG_VEN_PEDIDO p, beg_ven_linha_pedido lp, beg_dado_filial df\n     WHERE lp.beg_ven_pedido_id = p.beg_ven_pedido_id\n       and p.isactive = 'Y'\n       and df.beg_pessoa_id = p.beg_vw_cliente_id\n       and lp.BEG_VEN_TIPO_PEDIDO_ID = 2000019\n          /*       and not exists\n          (select 1\n                   from beg_ven_pedido_conferido pc\n                  where pc.beg_ven_pedido_id = p.beg_ven_pedido_id)*/\n       and nvl(p.num_nf, 0) = 0\n       and p.isactive = 'Y'\n       and df.BEG_PESSOA_ID = V_CLI\n       and lp.beg_vw_prd_preco_id = V_ID;\n\n  R_PED SALDO_PED%ROWTYPE;\n\nbegin\n  --\n  if inserting then\n\n    IF :NEW.QUANTIDADE = 0 THEN\n      raise_application_error(-20001,\n                              'Quantidade deve ser maior que zero.');\n    END IF;\n\n    OPEN BUSCA_SALDO;\n    FETCH BUSCA_SALDO\n      INTO V_SALDO;\n    CLOSE BUSCA_SALDO;\n\n    OPEN C1;\n    FETCH C1\n      INTO R_C1;\n    CLOSE C1;\n\n    OPEN BUSCA_USU;\n    FETCH BUSCA_USU\n      INTO R_USU;\n    CLOSE BUSCA_USU;\n\n    IF :NEW.BEG_VEN_TIPO_PEDIDO_ID IS NULL THEN\n      :NEW.BEG_VEN_TIPO_PEDIDO_ID := R_C1.BEG_VEN_TIPO_PEDIDO_ID;\n    END IF;\n\n    IF :NEW.BEG_VEN_TIPO_PEDIDO_ID IN (2000003, 2000021) THEN\n      :NEW.TP_PED := 'V';\n    ELSIF :NEW.BEG_VEN_TIPO_PEDIDO_ID = 2000019 THEN\n      IF R_USU.AD_ORG_ID = 1000016 THEN\n        :NEW.TP_PED := 'D';\n      ELSE\n        :NEW.TP_PED := 'E';\n      END IF;\n    END IF;\n\n    V_CLI := R_C1.BEG_VW_CLIENTE_ID;\n\n    if R_C1.BEG_VEN_TIPO_PEDIDO_ID = 2000019 then\n\n      OPEN BUSCA_MAX;\n      FETCH BUSCA_MAX\n        INTO R_MAX;\n      CLOSE BUSCA_MAX;\n      IF R_MAX.QTD_MAXIMA IS NOT NULL THEN\n\n        OPEN BUSCA_SALDO_LJ;\n        FETCH BUSCA_SALDO_LJ\n          INTO V_SALLJ;\n        CLOSE BUSCA_SALDO_LJ;\n\n        V_ID := :NEW.BEG_VW_PRD_PRECO_ID;\n\n        OPEN SALDO_PED;\n        FETCH SALDO_PED\n          INTO R_PED;\n        CLOSE SALDO_PED;\n\n        V_QTDE := (nvl(V_SALLJ.SALDO, 0) + NVL(R_PED.QUANTIDADE, 0));\n\n        IF :NEW.QUANTIDADE + V_QTDE > R_MAX.QTD_MAXIMA AND R_C1.BEG_VEN_TIPO_PEDIDO_ID = 2000019 AND R_USU.IND_COMPRADOR = 'N' THEN\n          raise_application_error(-20001,\n                                  'Quantidade solicitada excede limite permitido por filial. Quantidade Permitida = ' ||\n                                  R_MAX.QTD_MAXIMA ||\n                                  ' Qtde em estoque mais estoque em transito = ' ||\n                                  nvl(V_SALLJ.SALDO, 0) ||\n                                  ' Quantidade ja solicitada = ' ||\n                                  NVL(R_PED.QUANTIDADE, 0));\n        END IF;\n\n      END IF;\n\n      IF V_SALDO.CONTROLA_VOLTAGEM = 'Y' AND V_SALDO.BEG_PRD_VOLTAGEM_ID = 2000000 THEN\n\n        IF (:NEW.QUANTIDADE > V_SALDO.QTD_DISPONIVEL or V_SALDO.QTD_DISPONIVEL < 5) AND R_C1.BEG_VEN_TIPO_PEDIDO_ID = 2000019 AND R_USU.IND_COMPRADOR = 'N' THEN\n          raise_application_error(-20001,\n                                  'Produto indisponivel para pedidos de ressuprimento ');\n        END IF;\n\n      ELSE\n\n        IF (:NEW.QUANTIDADE > V_SALDO.QTD_DISPONIVEL or V_SALDO.QTD_DISPONIVEL < 5) AND R_C1.BEG_VEN_TIPO_PEDIDO_ID = 2000019 AND R_USU.IND_COMPRADOR = 'N' THEN\n          raise_application_error(-20001,\n                                  'Produto indisponivel para pedidos de ressuprimento ');\n        END IF;\n\n      END IF;\n\n    end if;\n  end if;\n\nend DIE_TRG_BI_LINHA_PEDIDO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AUD_LOG_LINHA_PEDIDO { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que insere o log das Matriz Tributaria no Compiere.\n   Modulo.......: FIS - Fiscal\n   Analista.....: Aroldo de Oliveira Krul\n   Alteracoes:\n   Data        Desenvolvedor  Alteracao\n   01/06/2011  Aroldo O.Krul  Criação\n   26/03/2013  Aroldo O.Krul  Inserido beg_fis_cst_pis/cofins/ipi new/old\n  --------------------------------------------------------------------------------------------------- */\n  cursor CR_COL is\n    select T.AD_TABLE_ID,\n           C.AD_COLUMN_ID,\n           UPPER(C.COLUMNNAME) COLUMNNAME\n      from AD_TABLE  T,\n           AD_COLUMN C\n     where T.AD_TABLE_ID = C.AD_TABLE_ID\n       and T.TABLENAME = 'BEG_VEN_LINHA_PEDIDO'\n       and UPPER(C.COLUMNNAME) not in\n           ('CREATED', 'CREATEDBY', 'UPDATED', 'UPDATEDBY');\n\n  VC_OLDVALUE AD_CHANGELOG.OLDVALUE%type;\n  VC_NEWVALUE AD_CHANGELOG.NEWVALUE%type;\n\nbegin\n  -- Insere os registros na tabela de log\n  insert into BEG_VEN_LINHA_PEDIDO_LOG\n  values\n    ( 'OLD',\n      :OLD.BEG_VEN_LINHA_PEDIDO_ID,\n      :OLD.AD_CLIENT_ID,\n      :OLD.AD_ORG_ID,\n      :OLD.ISACTIVE,\n      :OLD.VALUE,\n      :OLD.CREATED,\n      :OLD.CREATEDBY,\n      :OLD.UPDATED,\n      :OLD.UPDATEDBY,\n      :OLD.DESC_LINHA_PEDIDO,\n      :OLD.QUANTIDADE,\n      :OLD.VL_UNITARIO,\n      :OLD.DT_ENTREGA,\n      :OLD.NRO_ORDEM_COMPRA,\n      :OLD.OBS,\n      :OLD.BEG_VEN_PEDIDO_ID,\n      :OLD.BEG_PRD_SKU_ID,\n      :OLD.BEG_VW_PRD_PRECO_ID,\n      :OLD.ALTERA_DESCRICAO,\n      :OLD.QTD_FALTANTE,\n      :OLD.VLR_UNIT_SUGERIDO,\n      :OLD.COMISSAO,\n      :OLD.QTD_DISPONIVEL,\n      :OLD.PERCENTUAL_COMISSAO,\n      :OLD.DIE_ITEPED_ID,\n      :OLD.BEG_VEN_TIPO_PEDIDO_ID,\n      :OLD.TP_PED);\n\n/*  if UPDATING then\n    insert into BEG_VEN_LINHA_PEDIDO_LOG\n    values\n      ('NEW',\n      :NEW.BEG_VEN_LINHA_PEDIDO_ID,\n      :NEW.AD_CLIENT_ID,\n      :NEW.AD_ORG_ID,\n      :NEW.ISACTIVE,\n      :NEW.VALUE,\n      :NEW.CREATED,\n      :NEW.CREATEDBY,\n      :NEW.UPDATED,\n      :NEW.UPDATEDBY,\n      :NEW.DESC_LINHA_PEDIDO,\n      :NEW.QUANTIDADE,\n      :NEW.VL_UNITARIO,\n      :NEW.DT_ENTREGA,\n      :NEW.NRO_ORDEM_COMPRA,\n      :NEW.OBS,\n      :NEW.BEG_VEN_PEDIDO_ID,\n      :NEW.BEG_PRD_SKU_ID,\n      :NEW.BEG_VW_PRD_PRECO_ID,\n      :NEW.ALTERA_DESCRICAO,\n      :NEW.QTD_FALTANTE,\n      :NEW.VLR_UNIT_SUGERIDO,\n      :NEW.COMISSAO,\n      :NEW.QTD_DISPONIVEL,\n      :NEW.PERCENTUAL_COMISSAO,\n      :NEW.DIE_ITEPED_ID);\n  end if;*/\n\n  /*for R_COL in CR_COL\n  loop\n    if DELETING\n       or UPDATING(R_COL.COLUMNNAME) then\n      -- Busca valores old e new para a coluna\n      execute immediate 'select ' || R_COL.COLUMNNAME ||\n                        ' from BEG_VEN_LINHA_PEDIDO_LOG where ind_registro = ''OLD'''\n        into VC_OLDVALUE;\n\n      if DELETING then\n        VC_NEWVALUE := null;\n      else\n        execute immediate 'select ' || R_COL.COLUMNNAME ||\n                          ' from BEG_VEN_LINHA_PEDIDO_LOG where ind_registro = ''NEW'''\n          into VC_NEWVALUE;\n      end if;\n\n      if NVL(VC_OLDVALUE, '^') <> NVL(VC_NEWVALUE, '^') then\n\n        insert into AD_CHANGELOG\n          (AD_CHANGELOG_ID,\n           AD_SESSION_ID,\n           AD_TABLE_ID,\n           AD_COLUMN_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           CREATEDBY,\n           UPDATEDBY,\n           RECORD_ID,\n           OLDVALUE,\n           NEWVALUE)\n        values\n          (BEG_FNC_AD_SEQUENCE('AD_ChangeLog') -- ad_changelog_id\n          ,\n           BEG_PCK_AD_DICTIONARY.VN_AD_SESSION_ID -- ad_session_id\n          ,\n           R_COL.AD_TABLE_ID -- ad_table_id\n          ,\n           R_COL.AD_COLUMN_ID -- ad_column_id\n          ,\n           BEG_PCK_AD_DICTIONARY.VN_AD_CLIENT_ID -- ad_client_id\n          ,\n           BEG_PCK_AD_DICTIONARY.VN_AD_ORG_ID -- ad_org_id\n          ,\n           BEG_PCK_AD_DICTIONARY.VN_AD_USER_ID -- createdby\n          ,\n           BEG_PCK_AD_DICTIONARY.VN_AD_USER_ID -- updatedby\n          ,\n           NVL(:NEW.BEG_VEN_LINHA_PEDIDO_ID,\n               :OLD.BEG_VEN_LINHA_PEDIDO_ID) -- record_id\n          ,\n           VC_OLDVALUE,\n           VC_NEWVALUE);\n\n      end if;\n    end if;\n  end loop;\n*/\n -- delete from BEG_VEN_LINHA_PEDIDO_LOG;\n\nend DIE_TRG_AUD_LOG_LINHA_PEDIDO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BU_LINHA_PEDIDO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  pragma autonomous_transaction;\n  v_id number(11);\n  V_OK char(2);\n \n  v_tpped number(11);\n  v_div   number(11);\n  --\n  CURSOR C_ITEM(P_BEG_VEN_PEDIDO_ID   NUMBER,\n                P_BEG_VW_PRD_PRECO_ID NUMBER,\n                P_BEG_PRD_SKU_ID      NUMBER) IS\n    SELECT LP.QUANTIDADE\n      FROM BEG_VEN_LINHA_PEDIDO LP\n     WHERE LP.BEG_VEN_PEDIDO_ID = P_BEG_VEN_PEDIDO_ID\n       AND LP.BEG_VW_PRD_PRECO_ID = P_BEG_VW_PRD_PRECO_ID\n       AND LP.BEG_PRD_SKU_ID = P_BEG_PRD_SKU_ID;\n\n  cursor busca_pedido is\n    select p.*, pe.email\n      from beg_ven_pedido p, BEG_VEN_LINHA_PEDIDO PC, beg_pessoa pe\n     where p.beg_ven_pedido_id = PC.BEG_VEN_PEDIDO_ID\n       AND pe.beg_pessoa_id = p.beg_vw_cliente_id\n       AND PC.BEG_VEN_LINHA_PEDIDO_ID = :new.beg_ven_linha_pedido_id;\n  ---\n  V_PEDIDO BUSCA_PEDIDO%ROWTYPE;\n\n  cursor busca_pedido2 is\n    select p.beg_ven_pedido_id\n      from beg_ven_pedido p\n     where p.beg_vw_cliente_id = V_PEDIDO.BEG_VW_CLIENTE_ID\n       --and p.dt_entrega = :new.dt_entrega\n       and p.beg_ven_tipo_pedido_id = v_tpped\n       and p.beg_ger_divisao_pedido_id = v_div\n       and p.IMPRESSO = 'N'\n       AND NVL(p.DOCSTATUS, 'IP') <> 'CO'\n       and not exists\n     (select 1\n              from beg_ven_pedido_conferido pc\n             where pc.beg_ven_pedido_id = p.beg_ven_pedido_id);\n  V_PEDIDO2 BUSCA_PEDIDO2%ROWTYPE;\n\n  ---\n\n  --\nbegin\n  --\n\n  IF :NEW.Dt_Entrega <> :OLD.DT_ENTREGA THEN\n\n    if :new.Dt_Entrega <= trunc(sysdate) then\n      RAISE_APPLICATION_ERROR(-20002,\n                              'Data do novo pedido tem que ser maior que data do dia.');\n    end if;\n    \n\n    OPEN BUSCA_PEDIDO;\n    FETCH BUSCA_PEDIDO\n      INTO V_PEDIDO;\n    CLOSE BUSCA_PEDIDO;\n\n    v_tpped :=V_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID;\n    v_div := V_PEDIDO.BEG_GER_DIVISAO_PEDIDO_ID;\n    \n    --------\n    OPEN BUSCA_PEDIDO2;\n    FETCH BUSCA_PEDIDO2\n      INTO V_PEDIDO2;\n    CLOSE BUSCA_PEDIDO2;\n    \n\n\n    IF V_PEDIDO2.beg_ven_pedido_id is not null THEN\n\n      :new.beg_ven_pedido_id := V_PEDIDO2.beg_ven_pedido_id;\n\n    ELSE\n      ----------\n\n      --\n      -- INSERE PEDIDO\n      --\n\n      v_id := beg_fnc_ad_sequence('BEG_VEN_PEDIDO');\n      insert into beg_ven_pedido\n        (beg_ven_pedido_id,\n         ad_client_id,\n         ad_org_id,\n         isactive,\n         value,\n         created,\n         createdby,\n         updated,\n         updatedby,\n         dt_emissao,\n         dt_entrega,\n         obs,\n         beg_ven_tipo_pedido_id,\n         beg_ven_forma_cobranca_id,\n         beg_ven_tabela_preco_id,\n         beg_ven_forma_pagamento_id,\n         beg_condicao_pagamento_id,\n         beg_ven_plano_venda_id,\n         beg_vw_pessoa_entrega_id,\n         beg_vw_pessoa_cobranca_id,\n         beg_vw_transportadora_id,\n         beg_vw_representante_id,\n         beg_vw_cliente_id,\n         plano_editavel,\n         docstatus,\n         tp_frete,\n         vlr_frete,\n         impresso,\n         serie,\n         num_nf,\n         faturado,\n         nf_emitida,\n         beg_vw_preposto_id,\n         partes,\n         num_volumes,\n         beg_vw_ven_pedido_id,\n         beg_vw_televenda_id,\n         beg_cidade_id,\n         bairro,\n         endereco,\n         cep,\n         complementar,\n         peso,\n         msg_erro_aprovacao,\n         responsavel_venda,\n         endereco_entrega,\n         pessoa_cobranca,\n         vlr_total,\n         beg_fro_rota_id,\n         pedido_externo,\n         obs_credito,\n         tp_cadastro,\n         ind_cliente_filial,\n         beg_ven_com_regra_id,\n         comissao,\n         nro_ordem_compra,\n         representante_padrao,\n         televendedor_padrao,\n         msg_obs,\n         beg_ger_divisao_pedido_id)\n      values\n        (v_id,\n         1000000,\n         1000016,\n         'Y',\n         SEQ_PEDIDO.NEXTVAL, --:NEW.VALUE,\n         SYSDATE,\n         1000000,\n         SYSDATE,\n         1000000,\n         TRUNC(SYSDATE),\n         :NEW.DT_ENTREGA,\n         NULL,\n         V_PEDIDO.BEG_VEN_TIPO_PEDIDO_ID,\n         2000001,\n         NULL,\n         2000013,\n         2000001,\n         NULL,\n         V_PEDIDO.BEG_VW_CLIENTE_ID,\n         V_PEDIDO.BEG_VW_CLIENTE_ID,\n         NULL,\n         NULL,\n         V_PEDIDO.BEG_VW_CLIENTE_ID,\n         'N',\n         'AP',\n         'F',\n         0,\n         'Y',\n         NULL,\n         NULL,\n         'N',\n         'N',\n         NULL,\n         1,\n         NULL,\n         NULL,\n         NULL,\n         V_PEDIDO.beg_cidade_id,\n         V_PEDIDO.bairro,\n         V_PEDIDO.endereco,\n         V_PEDIDO.cep,\n         'N', -- complementar\n         0,\n         NULL,\n         NULL,\n         'N',\n         'N',\n         0,\n         NULL,\n         NULL,\n         NULL,\n         'P', -- tp_cadastro\n         'N',\n         NULL,\n         0,\n         NULL,\n         NULL,\n         NULL,\n         NULL,\n         V_PEDIDO.beg_ger_divisao_pedido_id);\n      NULL;\n\n      :new.beg_ven_pedido_id := v_id;\n\n      --\n\n    END IF;\n\n    ---\n\n    ---\n  END IF;\n  --\n  commit;\nend DIE_TRG_BU_LINHA_PEDIDO;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIU_BEG_VEN_LIN_PED_DATAS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  CURSOR C1 IS\n    SELECT TP.*\n      FROM BEG_VEN_TIPO_PEDIDO TP\n         , BEG_VEN_PEDIDO      P\n    WHERE TP.BEG_VEN_TIPO_PEDIDO_ID = P.BEG_VEN_TIPO_PEDIDO_ID\n      AND P.BEG_VEN_PEDIDO_ID       = :NEW.BEG_VEN_PEDIDO_ID;\n  --\n  R_C1 C1%ROWTYPE;\n  --\n  CURSOR C2 IS\n    SELECT SK.BEG_PRODUTO_ID\n    FROM BEG_PRD_SKU SK\n    WHERE SK.BEG_PRD_SKU_ID = :NEW.BEG_PRD_SKU_ID;\n   \n  R_C2 C2%ROWTYPE; \n  --\n  cursor c_produto is \n    select die_vw_prd_pai_id, sk.beg_prd_sku_id\n    from   beg_produto p,\n           BEG_PRD_SKU SK\n    where  p.beg_produto_Id = :new.beg_vw_prd_preco_id\n      AND  SK.BEG_PRODUTO_ID = P.DIE_VW_PRD_PAI_ID;\n  --\n  v_produto_pai c_produto%ROWTYPE;\n  --\n  CURSOR C3 IS\n    SELECT SK.BEG_PRD_SKU_id,\n           sk.beg_produto_id\n    FROM BEG_PRD_SKU SK\n    WHERE (SK.beg_produto_id = :NEW.beg_vw_prd_preco_id\n    or sk.beg_prd_sku_id = :new.beg_prd_sku_id);\n   \n  R_C3 C3%ROWTYPE; \n  --\nbegin\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que inicializa corretamente as datas do pedido.\n   Modulo.......: VEN - Vendas\n   Analista.....: Tiago Gabriel\n   Alterac?es:\n   Data        Desenvolvedor  Alterac?o\n   21/12/2006  Tiago Gabriel  Criac?o.\n  --------------------------------------------------------------------------------------------------- */\n  if INSERTING then\n      --\n      OPEN C3;\n      FETCH C3 INTO R_C3;\n      CLOSE C3;\n      :NEW.beg_prd_sku_id := R_C3.beg_prd_sku_id;\n      :new.beg_vw_prd_preco_id := r_c3.beg_produto_id;\n      -----\n    IF NVL(:NEW.VL_UNITARIO,0) = 0 THEN\n     \n      open c_produto;\n      fetch c_produto into v_produto_pai;\n      close c_produto;\n      OPEN C1;\n      FETCH C1 INTO R_C1;\n      CLOSE C1;\n      --\n      IF R_C1.TIPO_PRECO = 2 THEN\n        :NEW.VL_UNITARIO := round(beg_fnc_cst_valor(:NEW.AD_ORG_ID\n                                             ,nvl(v_produto_pai.die_vw_prd_pai_id,:NEW.BEG_VW_PRD_PRECO_ID)\n                                             ,NVL(v_produto_pai.beg_prd_sku_id,:NEW.BEG_PRD_SKU_ID))*1.3,2);---acrescentado *1.3 para ajuste nos valores de custo de transf \n        if :NEW.VL_UNITARIO = 0 then\n          :NEW.VL_UNITARIO := round(beg_fnc_prd_preco(:NEW.AD_ORG_ID\n                                               ,nvl(v_produto_pai.die_vw_prd_pai_id,:NEW.BEG_VW_PRD_PRECO_ID)\n                                               ,NVL(v_produto_pai.beg_prd_sku_id,:NEW.BEG_PRD_SKU_ID))*.7,2);   \n        end if;\n      ELSE\n        :NEW.VL_UNITARIO := round(beg_fnc_prd_preco(:NEW.AD_ORG_ID\n                                             ,nvl(v_produto_pai.die_vw_prd_pai_id,:NEW.BEG_VW_PRD_PRECO_ID)\n                                             ,NVL(v_produto_pai.beg_prd_sku_id,:NEW.BEG_PRD_SKU_ID)),2);   \n      END IF;      \n      --\n    END IF;\n    :new.CREATED := sysdate;\n    :NEW.VL_UNITARIO := round(:NEW.VL_UNITARIO,2);\n    \n    if :new.beg_ven_linha_pedido_id is null then \n      :new.beg_ven_linha_pedido_id:= beg_fnc_ad_sequence('BEG_VEN_LINHA_PEDIDO');\n     end if; \n      OPEN C2;\n      FETCH C2 INTO R_C2;\n      CLOSE C2;\n      :NEW.BEG_VW_PRD_PRECO_ID := R_C2.BEG_PRODUTO_ID;\n     \n  end if;\n  if updating then\n      OPEN C3;\n      FETCH C3 INTO R_C3;\n      CLOSE C3;\n      :NEW.beg_prd_sku_id := R_C3.beg_prd_sku_id;\n  end if;\n  :new.UPDATED    := sysdate;\n  :new.DT_ENTREGA := TRUNC(:new.DT_ENTREGA);\n\nend TRG_BIU_BEG_VEN_LIN_PED_DATAS;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_VEN_LINHA_PEDIDO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  -- local variables here\n  V_PRODUTO_ID              number(10);\n  V_QTD                     number(18, 4);\n  V_VL_UNITARIO             number(18, 4);\n  V_VL_SUGERIDO             number(18, 4);\n  V_BEG_VEN_PEDIDO_ID       number(10);\n  V_BEG_VEN_LINHA_PEDIDO_ID number(10);\n  V_MARGEM_MINIMA           number(18, 4);\n  V_MAIL_OK                 varchar2(1000);\n  --\n  cursor BUSCA_PRODUTO is\n    select (V_QTD * DECODE(V_VL_SUGERIDO, 0, V_VL_UNITARIO, V_VL_SUGERIDO)) +\n           (((V_QTD *\n           DECODE(V_VL_SUGERIDO, 0, V_VL_UNITARIO, V_VL_SUGERIDO)) *\n           NVL(0, 0)) / 100) TOTAL,\n           NVL(0, 0) IPI,\n           P.value\n      from BEG_PRD_CONTABIL C,\n           BEG_PRD_NCM      N,\n           BEG_PRODUTO      P\n     where C.BEG_PRODUTO_ID(+) = V_PRODUTO_ID\n       and N.BEG_PRD_NCM_ID(+) = C.BEG_PRD_NCM_ID\n       and P.BEG_PRODUTO_ID(+) = C.BEG_PRODUTO_ID;\n  --\n  VREG1 BUSCA_PRODUTO%rowtype;\n  --\n  cursor BUSCA_FRETE is\n    select DECODE(P.TP_FRETE, 'F', P.VLR_FRETE, 0) FRETE,\n           DOCSTATUS,\n           P.value\n      from BEG_VEN_PEDIDO P\n     where P.BEG_VEN_PEDIDO_ID = V_BEG_VEN_PEDIDO_ID;\n  --\n  VREG3 BUSCA_FRETE%rowtype;\n  --\n  cursor BUSCA_PEDIDO is\n    select value,\n           TP_CADASTRO,\n           beg_ven_tipo_pedido_id,\n           BEG_GER_DIVISAO_PEDIDO_ID\n      from BEG_VEN_PEDIDO P\n     where P.BEG_VEN_PEDIDO_ID = V_BEG_VEN_PEDIDO_ID;\n  --\n  VREG4 BUSCA_PEDIDO%rowtype;\n  --\n  cursor busca_conferencia is\n    select 1\n    from   beg_ven_pedido_conferido c\n    where  c.beg_ven_pedido_id = :new.beg_ven_pedido_id;\n  --\n  v_conf   busca_conferencia%rowtype;\n  --\n  cursor C_AUTORIZACAO(P_BEG_VEN_PEDIDO_ID number, P_BEG_PRODUTO_ID number, P_BEG_PRD_SKU_ID number) is\n    select VLR_UNIT_AUTORIZADO,\n           QUANTIDADE\n      from BEG_VEN_AUTORIZACAO\n     where BEG_VEN_PEDIDO_ID = P_BEG_VEN_PEDIDO_ID\n       and BEG_PRODUTO_ID = P_BEG_PRODUTO_ID\n       and BEG_PRD_SKU_ID = P_BEG_PRD_SKU_ID\n       and ISACTIVE = 'Y';\n  V_VLR_UNIT_AUTORIZADO number(18, 4) := 0;\n  V_QTD_AUTORIZADA      number(18, 4) := 0;\n  /*  cursor Busca_Conferencias is\n    select * from Beg_Ven_Pedido_Conferido Pc where Pc.Beg_Ven_Pedido_Id = v_Beg_Ven_Pedido_Id;\n  --\n  Vreg4 Busca_Conferencias%rowtype;*/\n\n  -------Cursor para validar poiscao fisica com divisao informada no pedido\n\n   CURSOR BUSCA_POSICAO IS\n    SELECT NVL(r.beg_ger_divisao_pedido_id,2000000) beg_ger_divisao_pedido_id\n    FROM   BEG_PRD_SKU s,\n           BEG_PRD_SKU_DETALHE SD,\n           Beg_Ger_Rua_Divisao r\n    WHERE  S.BEG_PRODUTO_ID = :NEW.beg_vw_prd_preco_id\n    --AND    S.PADRAO = 'Y'\n    AND    SD.BEG_PRD_SKU_ID = S.BEG_PRD_SKU_ID\n    AND    SD.AD_ORG_ID = 0\n    AND    SD.posicao_fisica between r.rua_inicial and nvl(r.rua_final,r.rua_inicial);\n  ---\n  V_POSICAO    BUSCA_POSICAO%ROWTYPE;\n\n  --\n  CURSOR C_DELETE_PED IS\n    SELECT docstatus,\n           p.faturado,\n           p.beg_ven_tipo_pedido_id\n      FROM BEG_VEN_PEDIDO p\n     WHERE BEG_VEN_PEDIDO_ID = :OLD.BEG_VEN_PEDIDO_ID;\n  --\n  R_DELETE_PED C_DELETE_PED%ROWTYPE;\n  --\n  CURSOR C_VALIDA_CONFERENCIA IS\n    SELECT 1\n      FROM BEG_VEN_PEDIDO_CONFERIDO\n     WHERE BEG_VEN_PEDIDO_ID = NVL(:NEW.BEG_VEN_PEDIDO_ID,:OLD.BEG_VEN_PEDIDO_ID)\n       AND DOCSTATUS = 'CO';\n  --\n  R_VALIDA_CONFERENCIA C_VALIDA_CONFERENCIA%ROWTYPE;\n  --\n  VPERC_MAX_PRECO  number(7, 4) := 0;\n  VPERC_MIN_PRECO  number(7, 4) := 0;\n  V_BEG_PRD_SKU_ID number(10);\n  --\n  CURSOR C3 IS\n    SELECT SK.BEG_PRD_SKU_id\n    FROM BEG_PRD_SKU SK\n    WHERE SK.beg_produto_id = :NEW.beg_vw_prd_preco_id;\n\n  R_C3 C3%ROWTYPE;\nbegin\n  --\n  if  inserting  then\n      OPEN C3;\n      FETCH C3 INTO R_C3;\n      CLOSE C3;\n      :NEW.beg_prd_sku_id := R_C3.beg_prd_sku_id;\n\n    OPEN busca_conferencia;\n    FETCH busca_conferencia INTO v_conf;\n      --\n      IF busca_conferencia%FOUND THEN\n        RAISE_APPLICATION_ERROR(-20001,'Não pode alterar Linha do Pedido quanto estiver em Separação!');\n      END IF;\n\n    CLOSE busca_conferencia;\n        V_BEG_VEN_PEDIDO_ID       := :new.BEG_VEN_PEDIDO_ID;\n     open BUSCA_PEDIDO;\n      fetch BUSCA_PEDIDO\n        into VREG4;\n      close BUSCA_PEDIDO;\n\n      open BUSCA_POSICAO;\n      fetch BUSCA_POSICAO\n        into V_POSICAO;\n      close BUSCA_POSICAO;\n\n      if vreg4.beg_ger_divisao_pedido_id <> V_POSICAO.beg_ger_divisao_pedido_id then\n        RAISE_APPLICATION_ERROR(-20001,\n                                  'Produto nao esta na mesma divisao informada no pedido !');\n      end if;\n\n  end if;\n  --\n  if DELETING then\n    --\n    OPEN C_DELETE_PED;\n    FETCH C_DELETE_PED INTO R_DELETE_PED;\n    CLOSE C_DELETE_PED;\n    --\n    if R_DELETE_PED.faturado = 'Y' then\n      RAISE_APPLICATION_ERROR(-20001,'Pedido ja faturado exclusao nao permitida!');\n    end if;\n   /* if r_delete_ped.beg_ven_tipo_pedido_id <> 2000019 then\n      RAISE_APPLICATION_ERROR(-20001,'Tipo de pedido nao permite exclusao, utilize a funcao Produto Divergente!');\n    end if;*/\n    --\n    V_PRODUTO_ID              := :old.BEG_VW_PRD_PRECO_ID; --PRODUTO_ID;\n    V_QTD                     := :new.QUANTIDADE -\n                                 NVL(:old.QTD_FALTANTE, 0);\n    V_VL_UNITARIO             := :old.VL_UNITARIO;\n    V_BEG_VEN_PEDIDO_ID       := :old.BEG_VEN_PEDIDO_ID;\n    V_BEG_VEN_LINHA_PEDIDO_ID := :old.BEG_VEN_LINHA_PEDIDO_ID;\n    V_VL_SUGERIDO             := :old.VLR_UNIT_SUGERIDO;\n  else\n    if :new.VLR_UNIT_SUGERIDO is null then\n      :new.VLR_UNIT_SUGERIDO := 0;\n    end if;\n    V_PRODUTO_ID              := :new.BEG_VW_PRD_PRECO_ID; --PRODUTO_ID;\n    V_QTD                     := :new.QUANTIDADE -\n                                 NVL(:new.QTD_FALTANTE, 0);\n    V_VL_UNITARIO             := :new.VL_UNITARIO;\n    V_BEG_VEN_PEDIDO_ID       := :new.BEG_VEN_PEDIDO_ID;\n    V_BEG_VEN_LINHA_PEDIDO_ID := :new.BEG_VEN_LINHA_PEDIDO_ID;\n    V_VL_SUGERIDO             := :new.VLR_UNIT_SUGERIDO;\n    V_BEG_PRD_SKU_ID          := :new.BEG_PRD_SKU_ID;\n    open BUSCA_FRETE;\n    fetch BUSCA_FRETE\n      into VREG3;\n    close BUSCA_FRETE;\n    if VREG3.DOCSTATUS = 'CO' then\n      RAISE_APPLICATION_ERROR(-20003,\n                              'Pedido ja conferido, e aguardando faturamento alteracao nao permitida em itens');\n    end if;\n    V_MARGEM_MINIMA := BEG_FNC_RETORNA_PARAM_GERAL('Vendas',\n                                                   null,\n                                                   'MARGEM_MINIMA');\n    if V_MARGEM_MINIMA >\n       BEG_PCK_VEN_COMISSOES.BEG_FNC_RETORNA_MARGEM(:new.BEG_VEN_PEDIDO_ID,\n                                                    :new.BEG_VW_PRD_PRECO_ID,\n                                                    :new.beg_prd_sku_id,\n                                                    :new.VL_UNITARIO,\n                                                    :new.VLR_UNIT_SUGERIDO) then\n      VREG1.TOTAL := 0;\n      open BUSCA_PRODUTO;\n      fetch BUSCA_PRODUTO\n        into VREG1;\n      close BUSCA_PRODUTO;\n      open BUSCA_PEDIDO;\n      fetch BUSCA_PEDIDO\n        into VREG4;\n      close BUSCA_PEDIDO;\n\n\n      if (VREG4.TP_CADASTRO = 'D' and\n         BEG_PCK_VEN_COMISSOES.V_VEN_AUTORIZACAO = 'N') then\n\n        open C_AUTORIZACAO(:new.BEG_VEN_PEDIDO_ID,\n                           :new.BEG_VW_PRD_PRECO_ID,\n                           :new.BEG_PRD_SKU_ID);\n        fetch C_AUTORIZACAO\n          into V_VLR_UNIT_AUTORIZADO, V_QTD_AUTORIZADA;\n\n        if C_AUTORIZACAO%notfound then\n          close C_AUTORIZACAO;\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Preco fora da margem necessita de autorizac?o !');\n        end if;\n\n        close C_AUTORIZACAO;\n\n        if NVL(V_VLR_UNIT_AUTORIZADO, 0) <> 0\n           and :new.VLR_UNIT_SUGERIDO <> NVL(V_VLR_UNIT_AUTORIZADO, 0) then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Preco diferente do autorizado ! Vlr. Autorizado : ' ||\n                                  TO_CHAR(V_VLR_UNIT_AUTORIZADO,\n                                          '999G999G990D00'));\n        end if;\n\n        if NVL(V_VLR_UNIT_AUTORIZADO, 0) <> 0\n           and :new.VLR_UNIT_SUGERIDO <> NVL(V_VLR_UNIT_AUTORIZADO, 0) then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Preco diferente do autorizado ! Vlr. Autorizado : ' ||\n                                  TO_CHAR(V_VLR_UNIT_AUTORIZADO,\n                                          '999G999G990D0000'));\n        end if;\n\n        if NVL(:new.QUANTIDADE, 0) <> V_QTD_AUTORIZADA then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Quantidade diferente da quantidade autorizada ! Qtd. Autorizada : ' ||\n                                  TO_CHAR(V_QTD_AUTORIZADA,\n                                          '999G999G990D0000'));\n        end if;\n\n    /*  else\n\n        BEG_PRC_MAIL('compiere@distribuidoranacional.com.br',\n                     'rodrigo@distribuidoranacional.com.br',\n                     'Margem Inferior',\n                     'Pedido ' || VREG4.value || ' o item ' || VREG1.value ||\n                     ' possui % de comissao de ' ||\n                     BEG_PCK_VEN_COMISSOES.BEG_FNC_RETORNA_MARGEM(:new.BEG_VEN_PEDIDO_ID,\n                                                                  :new.BEG_VW_PRD_PRECO_ID,\n                                                                  :new.beg_prd_sku_id,\n                                                                  :new.VL_UNITARIO,\n                                                                  :new.VLR_UNIT_SUGERIDO),\n                     V_MAIL_OK);*/\n      end if;\n    end if;\n    ---------------------------------\n  end if;\n  VREG1.TOTAL := 0;\n  open BUSCA_PRODUTO;\n  fetch BUSCA_PRODUTO\n    into VREG1;\n  close BUSCA_PRODUTO;\n  --  Raise_Application_Error(-20501, Vreg1.Total);\n  if INSERTING then\n    update BEG_VEN_PEDIDO P\n       set P.VLR_TOTAL = NVL(P.VLR_TOTAL, 0) + VREG1.TOTAL\n     where BEG_VEN_PEDIDO_ID = :new.BEG_VEN_PEDIDO_ID;\n  elsif UPDATING then\n    --\n    update BEG_VEN_PEDIDO P\n       set P.VLR_TOTAL = NVL(P.VLR_TOTAL, 0) -\n                         (((:old.QUANTIDADE - :old.QTD_FALTANTE) *\n                          DECODE(:old.VLR_UNIT_SUGERIDO,\n                                  0,\n                                  :old.VL_UNITARIO,\n                                  :old.VLR_UNIT_SUGERIDO)) +\n                          ((((:old.QUANTIDADE - :old.QTD_FALTANTE) *\n                          DECODE(:old.VLR_UNIT_SUGERIDO,\n                                    0,\n                                    :old.VL_UNITARIO,\n                                    :old.VLR_UNIT_SUGERIDO)) *\n                          NVL(VREG1.IPI, 0)) / 100))\n     where BEG_VEN_PEDIDO_ID = :new.BEG_VEN_PEDIDO_ID;\n    --\n    update BEG_VEN_PEDIDO P\n       set P.VLR_TOTAL = NVL(P.VLR_TOTAL, 0) + VREG1.TOTAL\n     where BEG_VEN_PEDIDO_ID = :new.BEG_VEN_PEDIDO_ID;\n  else\n    if NVL(BEG_PCK_VEN_COMISSOES.DELECAO_PEDIDO, 'N') = 'N' then\n      update BEG_VEN_PEDIDO P\n         set P.VLR_TOTAL = P.VLR_TOTAL -\n                           (((:old.QUANTIDADE - :old.QTD_FALTANTE) *\n                           DECODE(:old.VLR_UNIT_SUGERIDO,\n                                    0,\n                                    :old.VL_UNITARIO,\n                                    :old.VLR_UNIT_SUGERIDO)) +\n                           ((((:old.QUANTIDADE - :old.QTD_FALTANTE) *\n                           DECODE(:old.VLR_UNIT_SUGERIDO,\n                                      0,\n                                      :old.VL_UNITARIO,\n                                      :old.VLR_UNIT_SUGERIDO)) *\n                           NVL(VREG1.IPI, 0)) / 100))\n       where BEG_VEN_PEDIDO_ID = :old.BEG_VEN_PEDIDO_ID;\n    end if;\n  end if;\nend BEG_TRG_BIUD_VEN_LINHA_PEDIDO;\n"}`;
    
    }
}
