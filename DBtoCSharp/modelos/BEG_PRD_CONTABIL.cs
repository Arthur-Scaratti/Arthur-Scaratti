
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_CONTABIL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_CONTABIL_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACOES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_ORIGEM_MERC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_NCM_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_CONTABIL_CLASS_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_FISCAL_CLASS_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AUD_PRD_CONTABIL_LOG { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que insere o log das alteracoes no Contabil Produto para consultas\n                  no Compiere.\n   Modulo.......: PRD - Produto\n   Analista.....: Aroldo de Oliveira Krul\n   Alteracoes:\n   Data        Desenvolvedor  Alteracao\n   13/06/2011  Aroldo O.Krul  Criação\n  --------------------------------------------------------------------------------------------------- */\n  cursor cr_col is\n    select t.ad_table_id\n         , c.ad_column_id\n         , Upper( c.columnname ) columnname\n      from ad_table  t\n         , ad_column c\n     where t.ad_table_id = c.ad_table_id\n       and t.tablename   = 'BEG_PRD_CONTABIL'\n       and Upper( c.columnname ) not in ( 'CREATED', 'CREATEDBY', 'UPDATED', 'UPDATEDBY' );\n\n  vc_oldvalue ad_changelog.oldvalue%Type;\n  vc_newvalue ad_changelog.newvalue%Type;\n\nbegin\n  -- Insere os registros na tabela de log\n insert into beg_prd_contabil_log\n values\n      ('OLD'\n      , :OLD.beg_prd_contabil_id,    :OLD.ad_client_id,   :OLD.ad_org_id\n      , :OLD.isactive,               :OLD.created,        :OLD.Createdby\n      , :OLD.updated,                :OLD.updatedby,      :OLD.Observacoes\n      , :OLD.beg_fis_origem_merc_id, :OLD.beg_prd_ncm_id, :OLD.beg_prd_contabil_class_id\n      , :OLD.beg_produto_id,         :OLD.beg_prd_fiscal_class_id);\n\n  if updating then\n    insert into beg_prd_contabil_log\n    values\n      ('NEW'\n      , :NEW.beg_prd_contabil_id,    :NEW.ad_client_id,   :NEW.ad_org_id\n      , :NEW.isactive,               :NEW.created,        :NEW.Createdby\n      , :NEW.updated,                :NEW.updatedby,      :NEW.Observacoes\n      , :NEW.beg_fis_origem_merc_id, :NEW.beg_prd_ncm_id, :NEW.beg_prd_contabil_class_id\n      , :NEW.beg_produto_id,         :NEW.beg_prd_fiscal_class_id);\n  end if;\n\n  for r_col in cr_col loop\n    if deleting                     or\n       Updating( r_col.columnname ) then\n      -- Busca valores old e new para a coluna\n      execute immediate 'select ' || r_col.columnname || ' from beg_prd_contabil_log where ind_registro = ''OLD'''\n         into vc_oldvalue;\n\n      if deleting then\n        vc_newvalue := null;\n      else\n        execute immediate 'select ' || r_col.columnname || ' from beg_prd_contabil_log where ind_registro = ''NEW'''\n           into vc_newvalue;\n      end if;\n\n      if Nvl( vc_oldvalue, '^' ) <> Nvl( vc_newvalue, '^' ) then\n\n        insert into ad_changelog\n               ( ad_changelog_id\n               , ad_session_id\n               , ad_table_id\n               , ad_column_id\n               , ad_client_id\n               , ad_org_id\n               , createdby\n               , updatedby\n               , record_id\n               , oldvalue\n               , newvalue )\n        values ( beg_fnc_ad_sequence( 'AD_ChangeLog' ) -- ad_changelog_id\n               , beg_pck_ad_dictionary.vn_ad_session_id -- ad_session_id\n               , r_col.ad_table_id -- ad_table_id\n               , r_col.ad_column_id -- ad_column_id\n               , beg_pck_ad_dictionary.vn_ad_client_id -- ad_client_id\n               , beg_pck_ad_dictionary.vn_ad_org_id -- ad_org_id\n               , beg_pck_ad_dictionary.vn_ad_user_id -- createdby\n               , beg_pck_ad_dictionary.vn_ad_user_id -- updatedby\n               , Nvl( :new.Beg_Prd_Contabil_Id, :old.Beg_Prd_Contabil_Id ) -- record_id\n               , vc_oldvalue\n               , vc_newvalue );\n\n      end if;\n    end if;\n  end loop;\n\n  delete from beg_prd_contabil_log;\n\nend BEG_TRG_AUD_PRD_CONTABIL_LOG;"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_PRD_NCM_INV { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  --mf\n  cursor valida_ncm is\n    select b.value\n      from beg_prd_ncm b\n     where  b.BEG_PRD_NCM_ID = :new.BEG_PRD_NCM_ID\n     /*  and b.value in\n           ('1111.11.11', '2222.22.22', '3333.33.33', '4444.44.44',\n            '5555.55.55', '6666.66.66', '7777.77.77', '8888.88.88',\n            '9999.99.99', '0000.00.00')*/; -- Códigos NCM Fictícios;\n  --\n  V_PRDNCM valida_ncm%rowtype;\nbegin\n  open valida_ncm;\n  fetch valida_ncm\n    into V_PRDNCM;\n  if v_prdncm.value in('1111.11.11', '2222.22.22', '3333.33.33', '4444.44.44',\n            '5555.55.55', '6666.66.66', '7777.77.77', '8888.88.88',\n            '9999.99.99'/*, '0000.00.00'*/) then\n    RAISE_APPLICATION_ERROR(-20501, 'Ncm invalido.');\n  end if;\n  close valida_ncm;\n\nend beg_trg_bu_prd_ncm_inv;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_PRD_CONT_NCM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  cursor BUSCA_NCM_MATRIZ is\n    select 1\n      from BEG_FIS_NCM F\n     where F.BEG_PRD_NCM_ID = :new.BEG_PRD_NCM_ID;\n  --\n  V_NCM BUSCA_NCM_MATRIZ%rowtype;\n  \n \nbegin\n  open BUSCA_NCM_MATRIZ;\n  fetch BUSCA_NCM_MATRIZ\n    into V_NCM;\n  if BUSCA_NCM_MATRIZ%notfound then\n    RAISE_APPLICATION_ERROR(-20501,\n                            'Ncm vinculada ao item nao possui cadastro na matriz tributaria.');\n  end if;\n  close BUSCA_NCM_MATRIZ;\n  \n  end BEG_TRG_BIU_PRD_CONT_NCM;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_PRD_NCM { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\nPRAGMA AUTONOMOUS_TRANSACTION;\n  cursor BUSCA_NCM_PROD is\n    select 1\n      from beg_prd_contabil c\n     where c.beg_produto_id = :NEW.BEG_PRODUTO_ID\n       AND c.beg_prd_ncm_id <> :NEW.BEG_PRD_NCM_ID;\n\n  V_NCM_PROD BUSCA_NCM_PROD%rowtype;\n\nbegin\n\n  open BUSCA_NCM_PROD;\n  fetch BUSCA_NCM_PROD\n    into V_NCM_PROD;\n  if BUSCA_NCM_PROD%found then\n    RAISE_APPLICATION_ERROR(-20501,\n                            'Produto ja possui NCM cadastrado verifique!');\n  end if;\n  close BUSCA_NCM_PROD;\n\nend BEG_TRG_BIU_PRD_NCM;\n"}`;
    
    }
}
