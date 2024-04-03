
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CONVENIO
    {
            [Required]
        /// <summary>
        /// Carencia referente ao vencimento
        /// </summary>
        public int CARENCIA_VCTO { get; set; }
            [Required]
        /// <summary>
        /// Carencia referente ao faturamento
        /// </summary>
        public int CARENCIA_FATUR { get; set; }
            [Required]
        /// <summary>
        /// Id da filial responsavel pelo convenio
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [Required]
        /// <summary>
        /// Dia inicio referente ao mes de referencia
        /// </summary>
        public int DIA_INICIO { get; set; }
            [Required]
        /// <summary>
        /// Dia final referente ao mes de referencia
        /// </summary>
        public int DIA_FIM { get; set; }
            [StringLength(200)]
        /// <summary>
        /// Observacoes
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// numero do ultimo lote baixado
        /// </summary>
        public int ULTIMO_LOTE_BAIXADO { get; set; }
        
        /// <summary>
        /// data do ultimo lote baixado
        /// </summary>
        public string DT_ULT_LOTE_BAIXADO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// autorizador do convenio ex: Direto, Veccel, Tecbiz
        /// </summary>
        public string AUTORIZADOR { get; set; }
        
        /// <summary>
        /// Quantidade de dias  para geracao do lote - retroativo
        /// </summary>
        public int QTDE_DIA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do convenio
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da loja
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Registro ativo ou desativado
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Codigo da convenida
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Quando o registtro foi criado
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// usuario da ultima alteracao
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data de inicio do convenio
        /// </summary>
        public string DT_INICIO { get; set; }
        
        /// <summary>
        /// Data de termino do convenio
        /// </summary>
        public string DT_FIM { get; set; }
            [Required]
        /// <summary>
        /// Dia da apresentacao dos novos titulos ao convenio
        /// </summary>
        public int DIA_FATURAMENTO { get; set; }
            [Required]
        /// <summary>
        /// Dia da apresentacao  da cobranca do periodo ao convenio
        /// </summary>
        public int DIA_VENCIMENTO { get; set; }
            [Required]
        /// <summary>
        /// Numero maximo de parcelas permitidas pelo convenio
        /// </summary>
        public int MAX_PARCELA { get; set; }
            [Required]
        /// <summary>
        /// Percentual de comissao do convenio
        /// </summary>
        public int PERC_COMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Id do parceiro comercial - CONVENIO
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do grupo de convenio ao qual pertence
        /// </summary>
        public int BEG_GRUPO_CONVENIO_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_LOG_BEG_CONVENIO { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  cursor cr_col is\n    select tc.ad_table_id,\n           cc.ad_column_id,\n           Upper(cc.columnname) columnname,\n           cb.data_type\n      from ad_table tc, ad_column cc, user_tab_columns cb\n     where tc.ad_table_id = cc.ad_table_id\n       and Upper(tc.tablename) = cb.table_name\n       and Upper(cc.columnname) = cb.column_name\n       and Upper(tc.tablename) = 'BEG_CONVENIO'\n       and Upper(cc.columnname) not in\n           ('CREATED', 'CREATEDBY', 'UPDATED', 'UPDATEDBY');\n\n  vc_cmd      VarChar2(500);\n  vc_oldvalue ad_changelog.oldvalue%Type;\n  vc_newvalue ad_changelog.newvalue%Type;\n\nbegin\n\n  -- Insere os registros na tabela de log\n  insert into BEG_CONVENIO_LOG\n  values\n    ('OLD',\n     :OLD.BEG_CONVENIO_ID,\n     :OLD.AD_CLIENT_ID,\n     :OLD.AD_ORG_ID,\n     :OLD.ISACTIVE,\n     :OLD.VALUE,\n     :OLD.CREATED,\n     :OLD.CREATEDBY,\n     :OLD.UPDATED,\n     :OLD.UPDATEDBY,\n     :OLD.DT_INICIO,\n     :OLD.DT_FIM,\n     :OLD.DIA_FATURAMENTO,\n     :OLD.DIA_VENCIMENTO,\n     :OLD.MAX_PARCELA,\n     :OLD.PERC_COMISSAO,\n     :OLD.BEG_PESSOA_ID,\n     :OLD.BEG_GRUPO_CONVENIO_ID,\n     :OLD.CARENCIA_VCTO,\n     :OLD.CARENCIA_FATUR,\n     :OLD.BEG_FILIAL_ID,\n     :OLD.DIA_INICIO,\n     :OLD.DIA_FIM,\n     :OLD.OBSERVACAO,\n     :OLD.QTDE_DIA,\n     :OLD.ULTIMO_LOTE_BAIXADO,\n     :OLD.DT_ULT_LOTE_BAIXADO,\n     :OLD.AUTORIZADOR);\n\n  if updating then\n    insert into BEG_CONVENIO_LOG\n    values\n      ('NEW',\n       :NEW.BEG_CONVENIO_ID,\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.VALUE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       :NEW.DT_INICIO,\n       :NEW.DT_FIM,\n       :NEW.DIA_FATURAMENTO,\n       :NEW.DIA_VENCIMENTO,\n       :NEW.MAX_PARCELA,\n       :NEW.PERC_COMISSAO,\n       :NEW.BEG_PESSOA_ID,\n       :NEW.BEG_GRUPO_CONVENIO_ID,\n       :NEW.CARENCIA_VCTO,\n       :NEW.CARENCIA_FATUR,\n       :NEW.BEG_FILIAL_ID,\n       :NEW.DIA_INICIO,\n       :NEW.DIA_FIM,\n       :NEW.OBSERVACAO,\n       :NEW.QTDE_DIA,\n       :NEW.ULTIMO_LOTE_BAIXADO,\n       :NEW.DT_ULT_LOTE_BAIXADO,\n       :NEW.AUTORIZADOR);\n  end if;\n\n  for r_col in cr_col loop\n    if deleting or Updating(r_col.columnname) then\n      -- Busca valores old e new para a coluna\n      vc_cmd := 'select ';\n      if r_col.data_type = 'NUMBER' then\n        vc_cmd := vc_cmd || 'To_Char( ' || r_col.columnname || ' )';\n      else\n        vc_cmd := vc_cmd || r_col.columnname;\n      end if;\n      vc_cmd := vc_cmd ||\n                ' from BEG_CONVENIO_LOG where ind_registro = ''OLD''';\n      execute immediate vc_cmd\n        into vc_oldvalue;\n    \n      if deleting then\n        vc_newvalue := 'EXCLUSÃO';\n      else\n        vc_cmd := 'select ';\n        if r_col.data_type = 'NUMBER' then\n          vc_cmd := vc_cmd || 'To_Char( ' || r_col.columnname || ' )';\n        else\n          vc_cmd := vc_cmd || r_col.columnname;\n        end if;\n        vc_cmd := vc_cmd ||\n                  ' from BEG_CONVENIO_LOG where ind_registro = ''NEW''';\n        execute immediate vc_cmd\n          into vc_newvalue;\n      \n      end if;\n    \n      if Nvl(vc_oldvalue, '^') <> Nvl(vc_newvalue, '^') or\n         vc_newvalue = 'EXCLUSÃO' then\n      \n        insert into ad_changelog\n          (ad_changelog_id,\n           ad_session_id,\n           ad_table_id,\n           ad_column_id,\n           ad_client_id,\n           ad_org_id,\n           createdby,\n           updatedby,\n           record_id,\n           oldvalue,\n           newvalue)\n        values\n          (BEG_FNC_AD_Sequence('AD_ChangeLog') -- ad_changelog_id\n          ,\n           beg_pck_ad_dictionary.vn_ad_session_id -- ad_session_id\n          ,\n           r_col.ad_table_id -- ad_table_id\n          ,\n           r_col.ad_column_id -- ad_column_id\n          ,\n           beg_pck_ad_dictionary.vn_ad_client_id -- ad_client_id\n          ,\n           beg_pck_ad_dictionary.vn_ad_org_id -- ad_org_id\n          ,\n           beg_pck_ad_dictionary.vn_ad_user_id -- createdby\n          ,\n           beg_pck_ad_dictionary.vn_ad_user_id -- updatedby\n          ,\n           Nvl(:new.beg_convenio_id, :old.beg_convenio_id) -- record_id\n          ,\n           vc_oldvalue,\n           vc_newvalue);\n      \n      end if;\n    end if;\n  end loop;\n\n  delete from BEG_CONVENIO_LOG;\n\nend TRG_LOG_BEG_CONVENIO;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_CONVENIO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  VN_LIXO number;\n  cursor C1 is\n    select count(1)\n      from BEG_CRC_TITULO T\n     where T.IND_ABERTO = 'Y'\n       and T.BEG_CONVENIO_ID = :new.BEG_CONVENIO_ID;\n\nbegin\n\n  VN_LIXO := 0;\n  --\n  if UPDATING\n     and :new.ISACTIVE <> :old.ISACTIVE then\n    open C1;\n    fetch C1\n      into VN_LIXO;\n    if C1%notfound then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Erro ao acessar o convenio - ' || sqlerrm);\n    end if;\n    close C1;\n    if VN_LIXO > 0 then\n      RAISE_APPLICATION_ERROR(-20002,\n                              'Convenio não pode ser desativado, pois possui títulos em aberto');\n    end if;\n  end if;\n\n  if inserting then \n\n    update beg_pessoa a set\n        a.conveniada = 'Y'\n    where a.beg_pessoa_id = :NEW.BEG_PESSOA_ID;    \n    \n  end if;\n  \n  \nend BEG_TRG_BU_CONVENIO;\n"}`;
    
    }
}
