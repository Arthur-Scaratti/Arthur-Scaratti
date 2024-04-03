
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONTADOR
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CONTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [Required]
    [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string NRNF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VAL_TOTAL { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 'A'=Conferido OK   'C'= Cancelado   'I'= Inutilizado
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CANC { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }

        [NotMapped]
        public string Trigger_TRG_LOG_DIE_CONTADOR { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  cursor cr_col is\n    select tc.ad_table_id\n         , cc.ad_column_id\n         , Upper( cc.columnname ) columnname\n         , cb.data_type\n      from ad_table         tc\n         , ad_column        cc\n         , user_tab_columns cb\n     where tc.ad_table_id         = cc.ad_table_id\n       and Upper( tc.tablename )  = cb.table_name\n       and Upper( cc.columnname ) = cb.column_name\n       and Upper( tc.tablename )  = 'DIE_CONTADOR'\n       and Upper( cc.columnname ) not in ( 'CREATED', 'CREATEDBY', 'UPDATED', 'UPDATEDBY' );\n\n  vc_cmd         VarChar2( 500 );\n  vc_oldvalue    ad_changelog.oldvalue%Type;\n  vc_newvalue    ad_changelog.newvalue%Type;\n\nbegin\n\n  -- Insere os registros na tabela de log\n  insert into die_contador_log\n  values (:old.die_contador_id,\n          :old.ad_client_id,\n          :old.ad_org_id,\n          :old.isactive,\n          :old.created,\n          :old.createdby,\n          :old.updated,\n          :old.updatedby,\n          :old.value,\n          :old.filial,\n          :old.nrnf,\n          :old.dt_emiss,\n          :old.val_total,\n          :old.tipo,\n          :old.canc,\n          :old.serie,\n          :old.beg_filial_id,\n          :old.observacao,\n          'OLD' );\n  if updating then\n    insert into die_contador_log\n    values (:new.die_contador_id,\n            :new.ad_client_id,\n            :new.ad_org_id,\n            :new.isactive,\n            :new.created,\n            :new.createdby,\n            :new.updated,\n            :new.updatedby,\n            :new.value,\n            :new.filial,\n            :new.nrnf,\n            :new.dt_emiss,\n            :new.val_total,\n            :new.tipo,\n            :new.canc,\n            :new.serie,\n            :new.beg_filial_id,\n            :new.observacao,\n            'NEW');\n  end if;\n\n  for r_col in cr_col loop\n    if deleting                     or\n       Updating( r_col.columnname ) then\n      -- Busca valores old e new para a coluna\n      vc_cmd := 'select ';\n      if r_col.data_type = 'NUMBER' then\n        vc_cmd := vc_cmd || 'To_Char( ' || r_col.columnname || ' )';\n      else\n        vc_cmd := vc_cmd || r_col.columnname;\n      end if;\n      vc_cmd := vc_cmd || ' from die_contador_log where ind_registro = ''OLD''';\n      execute immediate vc_cmd\n         into vc_oldvalue;\n\n      if deleting then\n        vc_newvalue := 'EXCLUSÃO';\n      else\n        vc_cmd := 'select ';\n        if r_col.data_type = 'NUMBER' then\n          vc_cmd := vc_cmd || 'To_Char( ' || r_col.columnname || ' )';\n        else\n          vc_cmd := vc_cmd || r_col.columnname;\n        end if;\n        vc_cmd := vc_cmd || ' from die_contador_log where ind_registro = ''NEW''';\n        execute immediate vc_cmd\n           into vc_newvalue;\n\n      end if;\n\n      if Nvl( vc_oldvalue, '^' ) <> Nvl( vc_newvalue, '^' ) or\n         vc_newvalue             =  'EXCLUSÃO'              then\n\n       if UPDATING then\n        insert into ad_changelog\n               ( ad_changelog_id\n               , ad_session_id\n               , ad_table_id\n               , ad_column_id\n               , ad_client_id\n               , ad_org_id\n               , createdby\n               , updatedby\n               , record_id\n               , oldvalue\n               , newvalue )\n        values ( BEG_FNC_AD_Sequence( 'AD_ChangeLog' ) -- ad_changelog_id\n               , beg_pck_ad_dictionary.vn_ad_session_id -- ad_session_id\n               , r_col.ad_table_id -- ad_table_id\n               , r_col.ad_column_id -- ad_column_id\n               , beg_pck_ad_dictionary.vn_ad_client_id -- ad_client_id\n               , beg_pck_ad_dictionary.vn_ad_org_id -- ad_org_id\n               , beg_pck_ad_dictionary.vn_ad_user_id -- createdby\n               , beg_pck_ad_dictionary.vn_ad_user_id -- updatedby\n               , Nvl( :new.die_contador_id, :old.die_contador_id ) -- record_id\n               , vc_oldvalue\n               , vc_newvalue );\n        end if;\n      end if;\n    end if;\n  end loop;\n\n  delete from die_contador_log;\n\nend TRG_LOG_DIE_CONTADOR;\n"}`;
    
    }
}
