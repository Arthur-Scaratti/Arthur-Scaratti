
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARTAO_PARCELA
    {
        
        /// <summary>
        /// Percentual da tarifa administradora aplicada na compra
        /// </summary>
        public int TARIFA_ADM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TX_ADIANTAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTVENCTO_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUIDO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_AUTORIZACAO_TEF { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO_RESUMO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Identificacao de transacao realizada pelo ecommerce
        /// </summary>
        public string TID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ESTORNO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CONFERIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CONFERIDO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_ANTECIPACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ANTECIPACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VALE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGA_B2W { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_VENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PARC_ADM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_PARC_LOJA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAIXA_HIST_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IOF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS_ADM { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_PARCELA_ID { get; set; }
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
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CDDUPL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string PARCELA { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCUPOM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTVENCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTPAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int JUROS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRNF { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRCAIXA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CDCARTAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTMOVIM { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTDEP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEQUENCIA { get; set; }
            [Required]
    [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NRAUTOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_TAXA_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESTORNO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_LOG_CARTAO_PARCELA { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  cursor cr_col is\n    select tc.ad_table_id\n         , cc.ad_column_id\n         , Upper( cc.columnname ) columnname\n         , cb.data_type\n      from ad_table         tc\n         , ad_column        cc\n         , user_tab_columns cb\n     where tc.ad_table_id         = cc.ad_table_id\n       and Upper( tc.tablename )  = cb.table_name\n       and Upper( cc.columnname ) = cb.column_name\n       and Upper( tc.tablename )  = 'DIE_CARTAO_PARCELA'\n       and Upper( cc.columnname ) not in ( 'CREATED', 'CREATEDBY', 'UPDATED', 'UPDATEDBY' );\n\n  vc_cmd         VarChar2( 500 );\n  vc_oldvalue    ad_changelog.oldvalue%Type;\n  vc_newvalue    ad_changelog.newvalue%Type;\n\nbegin\n\n  -- Insere os registros na tabela de log\n  insert into die_cartao_parcela_log\n  values (:old.die_cartao_parcela_id,\n          :old.ad_client_id,\n          :old.ad_org_id,\n          :old.isactive,\n          :old.created,\n          :old.createdby,\n          :old.updated,\n          :old.updatedby,\n          :old.CDDUPL,\n          :old.PARCELA,\n          :old.CODIGO,\n          :old.NRCUPOM,\n          :old.DTEMISSAO,\n          :old.DTVENCTO,\n          :old.DTPAGTO,\n          :old.VALOR,\n          :old.DESCONTO,\n          :old.JUROS,\n          :old.SITUACAO,\n          :old.nrnf,\n          :old.serie,\n          :old.nrcaixa,\n          :old.observacao,\n          :old.cdcartao,\n          :old.dtmovim,\n          :old.nome,\n          :old.dtdep,\n          :old.sequencia,\n          :old.nrautor,\n          :old.beg_pessoa_id,\n          :old.beg_crc_titulo_id,\n          :old.die_car_taxa_id,\n          :old.ind_estorno,\n          :old.vlr_tx_adiantamento,\n          :old.dtvencto_orig,\n          :old.valor_orig,\n          :old.desconto_orig,\n          :old.vlr_liquido,\n          :old.cod_autorizacao_tef,\n          :old.numero_resumo,\n          :old.tid,\n          :old.dt_estorno,\n          :old.ind_conferido,\n          :old.dt_conferido,\n          :old.nr_antecipacao,\n          :old.dt_antecipacao,\n          :old.die_crc_recibo_id,\n          :old.vlr_vale,\n          :old.entrega_b2w,\n          :old.die_cartao_cr_venda_id,\n          :old.vlr_parc_adm,\n          'OLD' ,\n          :old.die_cartao_parcela_id,\n          :old.id_parc_loja,\n          :old.die_caixa_hist_id,\n          :old.beg_vw_cliente_id,\n          :old.vlr_iof,\n          :old.vlr_juros_adm,\n          :old.tarifa_adm);\n  if updating then\n    insert into die_cartao_parcela_log\n    values (:new.die_cartao_parcela_id,\n            :new.ad_client_id,\n            :new.ad_org_id,\n            :new.isactive,\n            :new.created,\n            :new.createdby,\n            :new.updated,\n            :new.updatedby,\n            :new.CDDUPL,\n            :new.PARCELA,\n            :new.CODIGO,\n            :new.NRCUPOM,\n            :new.DTEMISSAO,\n            :new.DTVENCTO,\n            :new.DTPAGTO,\n            :new.VALOR,\n            :new.DESCONTO,\n            :new.JUROS,\n            :new.SITUACAO,\n            :new.nrnf,\n            :new.serie,\n            :new.nrcaixa,\n            :new.observacao,\n            :new.cdcartao,\n            :new.dtmovim,\n            :new.nome,\n            :new.dtdep,\n            :new.sequencia,\n            :new.nrautor,\n            :new.beg_pessoa_id,\n            :new.beg_crc_titulo_id,\n            :new.die_car_taxa_id,\n            :new.ind_estorno,\n            :new.vlr_tx_adiantamento,\n            :new.dtvencto_orig,\n            :new.valor_orig,\n            :new.desconto_orig,\n            :new.vlr_liquido,\n            :new.cod_autorizacao_tef,\n            :new.numero_resumo,\n            :new.tid,\n            :new.dt_estorno,\n            :new.ind_conferido,\n            :new.dt_conferido,\n            :new.nr_antecipacao,\n            :new.dt_antecipacao,\n            :new.die_crc_recibo_id,\n            :new.vlr_vale,\n            :new.entrega_b2w,\n            :new.die_cartao_cr_venda_id,\n            :new.vlr_parc_adm,\n            'NEW',\n            :new.die_cartao_parcela_id,\n            :new.id_parc_loja,\n            :new.die_caixa_hist_id,\n            :new.beg_vw_cliente_id,\n            :new.vlr_iof,\n            :new.vlr_juros_adm,\n            :new.tarifa_adm);\n  end if;\n\n  for r_col in cr_col loop\n    if deleting                     or\n       Updating( r_col.columnname ) then\n      -- Busca valores old e new para a coluna\n      vc_cmd := 'select ';\n      if r_col.data_type = 'NUMBER' then\n        vc_cmd := vc_cmd || 'To_Char( ' || r_col.columnname || ' )';\n      else\n        vc_cmd := vc_cmd || r_col.columnname;\n      end if;\n      vc_cmd := vc_cmd || ' from die_cartao_parcela_log where ind_registro = ''OLD''';\n      execute immediate vc_cmd\n         into vc_oldvalue;\n\n      if deleting then\n        vc_newvalue := 'EXCLUSÃO';\n      else\n        vc_cmd := 'select ';\n        if r_col.data_type = 'NUMBER' then\n          vc_cmd := vc_cmd || 'To_Char( ' || r_col.columnname || ' )';\n        else\n          vc_cmd := vc_cmd || r_col.columnname;\n        end if;\n        vc_cmd := vc_cmd || ' from die_cartao_parcela_log where ind_registro = ''NEW''';\n        execute immediate vc_cmd\n           into vc_newvalue;\n\n      end if;\n\n      if Nvl( vc_oldvalue, '^' ) <> Nvl( vc_newvalue, '^' ) or\n         vc_newvalue             =  'EXCLUSÃO'              then\n\n       if UPDATING then\n        insert into ad_changelog\n               ( ad_changelog_id\n               , ad_session_id\n               , ad_table_id\n               , ad_column_id\n               , ad_client_id\n               , ad_org_id\n               , createdby\n               , updatedby\n               , record_id\n               , oldvalue\n               , newvalue )\n        values ( BEG_FNC_AD_Sequence( 'AD_ChangeLog' ) -- ad_changelog_id\n               , beg_pck_ad_dictionary.vn_ad_session_id -- ad_session_id\n               , r_col.ad_table_id -- ad_table_id\n               , r_col.ad_column_id -- ad_column_id\n               , beg_pck_ad_dictionary.vn_ad_client_id -- ad_client_id\n               , beg_pck_ad_dictionary.vn_ad_org_id -- ad_org_id\n               , beg_pck_ad_dictionary.vn_ad_user_id -- createdby\n               , beg_pck_ad_dictionary.vn_ad_user_id -- updatedby\n               , Nvl( :new.die_cartao_parcela_id, :old.die_cartao_parcela_id ) -- record_id\n               , vc_oldvalue\n               , vc_newvalue );\n        end if;\n      end if;\n    end if;\n  end loop;\n\n  delete from die_cartao_parcela_log;\n\nend DIE_TRG_LOG_CARTAO_PARCELA;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CARTAO_PARCELA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  V_ID NUMBER(10);\n\n  CURSOR C1 IS\n    SELECT F.DIE_CARTAO_CR_FATURA_ID\n      FROM DIE_CARTAO_CR_FATURA F\n     WHERE TO_CHAR(TRUNC(F.DT_VCTO), 'MMRRRR') =\n           to_CHAR(TRUNC(:NEW.DTVENCTO), 'MMRRRR')\n          -- AND F.AD_ORG_ID = :NEW.AD_ORG_ID\n       AND F.BEG_PESSOA_ID =\n           NVL(:NEW.BEG_VW_CLIENTE_ID, :NEW.BEG_PESSOA_ID);\n\n  R1 C1%ROWTYPE;\n\n  cursor C_FECH_CONT2 is\n    select max(C.DT_FINAL) DT_FINAL\n      from BEG_FECH_CONTABIL C\n     WHERE C.ISACTIVE = 'Y'\n       and c.ind_escrita = 'N';\n  --\n  R_FECH_CONT2 C_FECH_CONT2%rowtype;\n\n  CURSOR C_TAXA IS\n    SELECT T.TAXA_AVISTA, T.TAXA_PARC, T.BEG_CAR_TIPO_VENDA_ID, T.NRO_MAX_PARCELA, T.NRO_INI_PARCELA\n      FROM DIE_CAR_TAXA T\n     WHERE T.DIE_CAR_TAXA_ID = :NEW.DIE_CAR_TAXA_ID;\n  R_TAXA C_TAXA%ROWTYPE;\n\nBEGIN\n\n  IF INSERTING OR DELETING THEN\n  \n    open C_FECH_CONT2;\n    fetch C_FECH_CONT2\n      into R_FECH_CONT2;\n    close C_FECH_CONT2;\n    IF (R_FECH_CONT2.DT_FINAL >= :NEW.DTEMISSAO) OR\n       (R_FECH_CONT2.DT_FINAL >= :OLD.DTEMISSAO) then\n      RAISE_APPLICATION_ERROR(-20501,\n                              'Movimento ja encerrado! Estorno nao permitido');\n    END IF;\n  \n  END IF;\n\n  IF INSERTING OR UPDATING THEN\n  \n    IF :NEW.DT_ESTORNO IS NOT NULL AND :OLD.DT_ESTORNO IS NULL THEN\n    \n      open C_FECH_CONT2;\n      fetch C_FECH_CONT2\n        into R_FECH_CONT2;\n      close C_FECH_CONT2;\n      IF R_FECH_CONT2.DT_FINAL >= :NEW.DT_ESTORNO then\n        RAISE_APPLICATION_ERROR(-20501,\n                                'Movimento ja encerrado! Estorno nao permitido');\n      END IF;\n    \n    END IF;\n  \n    ---- AJUSTE PARA CALCULO DA TAXA 21/03/2022\n    IF :NEW.DTEMISSAO > TO_DATE('01/01/2022', 'DD/MM/RRRR') AND\n       :NEW.DIE_CAR_TAXA_ID NOT IN (1000036, 1000048, 1000046) THEN\n    \n      IF (INSERTING AND  NVL(:NEW.DESCONTO, 0) = 0 ) OR\n         (UPDATING AND :OLD.DIE_CAR_TAXA_ID <> :NEW.DIE_CAR_TAXA_ID) THEN\n      \n        open C_TAXA;\n        fetch C_TAXA\n          into R_TAXA;\n        close C_TAXA;\n      \n        IF R_TAXA.BEG_CAR_TIPO_VENDA_ID = 1000000 THEN\n        \n          IF NVL(:NEW.DESCONTO, 0) = 0 THEN\n          \n            :NEW.DESCONTO := ROUND((:NEW.VALOR * CASE WHEN R_TAXA.NRO_MAX_PARCELA > 1 THEN R_TAXA.TAXA_PARC ELSE R_TAXA.TAXA_AVISTA END) / 100, 2);\n            :NEW.TARIFA_ADM := CASE WHEN R_TAXA.NRO_MAX_PARCELA > 1 THEN R_TAXA.TAXA_PARC ELSE R_TAXA.TAXA_AVISTA END;\n          \n          ELSE\n          \n            :NEW.DESCONTO_ORIG := ROUND((:NEW.VALOR * CASE WHEN R_TAXA.NRO_MAX_PARCELA > 1 THEN R_TAXA.TAXA_PARC ELSE R_TAXA.TAXA_AVISTA END) / 100,\n                                        2);\n            :NEW.TARIFA_ADM := CASE WHEN R_TAXA.NRO_MAX_PARCELA > 1 THEN R_TAXA.TAXA_PARC ELSE R_TAXA.TAXA_AVISTA END;\n                                                   \n          END IF;\n        \n        ELSE\n          IF NVL(:NEW.DESCONTO, 0) = 0 THEN\n          \n            :NEW.DESCONTO := ROUND((:NEW.VALOR * CASE WHEN R_TAXA.NRO_MAX_PARCELA > 1 THEN R_TAXA.TAXA_PARC ELSE R_TAXA.TAXA_AVISTA END) / 100,\n                                   2);\n            :NEW.TARIFA_ADM := CASE WHEN R_TAXA.NRO_MAX_PARCELA > 1 THEN R_TAXA.TAXA_PARC ELSE R_TAXA.TAXA_AVISTA END;                       \n          \n          ELSE\n          \n            :NEW.DESCONTO_ORIG := ROUND((:NEW.VALOR * CASE WHEN R_TAXA.NRO_MAX_PARCELA > 1 THEN R_TAXA.TAXA_PARC ELSE R_TAXA.TAXA_AVISTA END) / 100,\n                                        2);\n            :NEW.TARIFA_ADM := CASE WHEN R_TAXA.NRO_MAX_PARCELA > 1 THEN R_TAXA.TAXA_PARC ELSE R_TAXA.TAXA_AVISTA END;\n                                        \n          END IF;\n        \n        END IF;\n      \n      END IF;\n      \n      IF INSERTING AND  NVL(:NEW.TARIFA_ADM,0)= 0 THEN\n        \n         open C_TAXA;\n        fetch C_TAXA\n          into R_TAXA;\n        close C_TAXA;\n      \n        IF R_TAXA.BEG_CAR_TIPO_VENDA_ID = 1000000 THEN\n          \n          :NEW.TARIFA_ADM := CASE WHEN R_TAXA.NRO_MAX_PARCELA > 1 THEN R_TAXA.TAXA_PARC ELSE R_TAXA.TAXA_AVISTA END;\n          \n        ELSE\n        \n          :NEW.TARIFA_ADM := CASE WHEN R_TAXA.NRO_MAX_PARCELA > 1 THEN R_TAXA.TAXA_PARC ELSE R_TAXA.TAXA_AVISTA END;  \n        \n        END IF;\n        \n      END IF;\n    END IF;\n  \n    ----\n  \n    :NEW.VLR_LIQUIDO := :NEW.VALOR - :NEW.DESCONTO;\n  \n    IF :NEW.IND_ESTORNO = 'N' THEN\n      :NEW.DT_ESTORNO := NULL;\n    END IF;\n  \n    IF :NEW.DIE_CAR_TAXA_ID in (1000036, 1000048, 1000046) THEN\n    \n      IF :NEW.DIE_CARTAO_CR_VENDA_ID IS NOT NULL AND\n         :OLD.DIE_CARTAO_CR_VENDA_ID IS NULL THEN\n      \n        open C1;\n        fetch C1\n          into R1;\n        CLOSE C1;\n      \n        IF R1.DIE_CARTAO_CR_FATURA_ID IS NULL THEN\n        \n          V_ID := beg_fnc_ad_sequence('DIE_CARTAO_CR_FATURA');\n        \n          INSERT INTO DIE_CARTAO_CR_FATURA\n            (DIE_CARTAO_CR_FATURA_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             DT_VCTO,\n             BEG_PESSOA_ID,\n             VLR_FATURA,\n             VLR_ABERTO)\n          VALUES\n            (V_ID,\n             1000000,\n             0, --:NEW.AD_ORG_ID,\n             'Y',\n             SYSDATE,\n             1000000,\n             SYSDATE,\n             1000000,\n             :NEW.DTVENCTO,\n             NVL(:NEW.BEG_VW_CLIENTE_ID, :NEW.BEG_PESSOA_ID),\n             0,\n             0);\n        \n          INSERT INTO DIE_CARTAO_CR_COMPRAS\n            (DIE_CARTAO_CR_COMPRAS_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             DT_VCTO,\n             DIE_CARTAO_PARCELA_ID,\n             VLR_PARCELA,\n             OBS,\n             DIE_CARTAO_CR_FATURA_ID,\n             DTEMISSAO)\n          VALUES\n            (BEG_FNC_AD_SEQUENCE('DIE_CARTAO_CR_COMPRAS'),\n             1000000,\n             0, --:NEW.AD_ORG_ID,\n             'Y',\n             SYSDATE,\n             1000000,\n             SYSDATE,\n             1000000,\n             :NEW.DTVENCTO,\n             :NEW.DIE_CARTAO_PARCELA_ID,\n             case when :new.vlr_parc_adm > 0\n             then(:NEW.VLR_PARC_ADM - NVL(:NEW.VLR_IOF, 0) -\n                  NVL(:NEW.VLR_JUROS_ADM, 0)) else :NEW.VALOR end,\n             NULL,\n             v_id,\n             :NEW.DTEMISSAO\n             \n             );\n        \n        ELSE\n          INSERT INTO DIE_CARTAO_CR_COMPRAS\n            (DIE_CARTAO_CR_COMPRAS_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             DT_VCTO,\n             DIE_CARTAO_PARCELA_ID,\n             VLR_PARCELA,\n             OBS,\n             DIE_CARTAO_CR_FATURA_ID,\n             DTEMISSAO)\n          VALUES\n            (BEG_FNC_AD_SEQUENCE('DIE_CARTAO_CR_COMPRAS'),\n             1000000,\n             0, --:NEW.AD_ORG_ID,\n             'Y',\n             SYSDATE,\n             1000000,\n             SYSDATE,\n             1000000,\n             :NEW.DTVENCTO,\n             :NEW.DIE_CARTAO_PARCELA_ID,\n             case when :new.vlr_parc_adm > 0\n             then(:NEW.VLR_PARC_ADM - NVL(:NEW.VLR_IOF, 0) -\n                  NVL(:NEW.VLR_JUROS_ADM, 0)) else :NEW.VALOR end,\n             NULL,\n             R1.DIE_CARTAO_CR_FATURA_ID,\n             :NEW.DTEMISSAO);\n        \n        END IF;\n      \n      END IF;\n    \n      IF :NEW.IND_ESTORNO = 'Y' AND :OLD.IND_ESTORNO = 'N' THEN\n      \n        UPDATE DIE_CARTAO_CR_COMPRAS C\n           SET C.IND_CANCELADO   = :NEW.IND_ESTORNO,\n               C.DT_CANCELAMENTO = :NEW.DT_ESTORNO\n         WHERE C.DIE_CARTAO_PARCELA_ID = :NEW.DIE_CARTAO_PARCELA_ID;\n      \n      END IF;\n    \n    END IF;\n  \n  END IF;\n\n  if deleting and :old.ind_conferido = 'Y' then\n  \n    RAISE_APPLICATION_ERROR(-20501,\n                            'Movimento ja conferido. Exclusao nao permitida. ');\n  \n  end if;\n\n  if deleting and :old.DIE_CAR_TAXA_ID in (1000036, 1000048, 1000046) then\n  \n    delete die_cartao_cr_compras c\n     where c.Die_Cartao_Parcela_Id = :OLD.DIE_CARTAO_PARCELA_ID;\n  \n  end if;\n\nEND DIE_TRG_BIU_CARTAO_PARCELA;\n"}`;
    
    }
}
