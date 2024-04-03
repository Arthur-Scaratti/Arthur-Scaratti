
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIS_MATRIZ_TRIBUTARIA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_MARGEM_SUBSTITUICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ICM_SUBSTITUICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MVA_CLIENTE_OPTANTE_SIMPLES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_COFINS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_PIS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_IPI_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_IR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_CSSL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TP_OPERACAO_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Codigo de beneficio fiscal da ST
        /// </summary>
        public string CBENEF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// Uf de origem
        /// </summary>
        public int BEG_VW_UF_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_MATRIZ_TRIBUTARIA_ID { get; set; }
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
    [StringLength(100)]
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
        /// <summary>
        /// 
        /// </summary>
        public int PERC_IPI { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ICM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_PIS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COFINS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ISSQN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_IRRF { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_IPI_DIFERIDO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_FUNRURAL { get; set; }
        
        /// <summary>
        /// UF destino
        /// </summary>
        public int BEG_UF_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_TRIB_ICMS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_TRIB_IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_ORIGEM_MERC_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_TRIB_ICMS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESC_SUFRAMA { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AUD_LOG_MTZ_TRIB { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que insere o log das Matriz Tributaria no Compiere.\n   Modulo.......: FIS - Fiscal\n   Analista.....: Aroldo de Oliveira Krul\n   Alteracoes:\n   Data        Desenvolvedor  Alteracao\n   01/06/2011  Aroldo O.Krul  Criação\n   26/03/2013  Aroldo O.Krul  Inserido beg_fis_cst_pis/cofins/ipi new/old\n  --------------------------------------------------------------------------------------------------- */\n  cursor CR_COL is\n    select T.AD_TABLE_ID,\n           C.AD_COLUMN_ID,\n           UPPER(C.COLUMNNAME) COLUMNNAME\n      from AD_TABLE  T,\n           AD_COLUMN C\n     where T.AD_TABLE_ID = C.AD_TABLE_ID\n       and T.TABLENAME = 'BEG_FIS_MATRIZ_TRIBUTARIA'\n       and UPPER(C.COLUMNNAME) not in\n           ('CREATED', 'CREATEDBY', 'UPDATED', 'UPDATEDBY');\n\n  VC_OLDVALUE AD_CHANGELOG.OLDVALUE%type;\n  VC_NEWVALUE AD_CHANGELOG.NEWVALUE%type;\n\nbegin\n  -- Insere os registros na tabela de log\n  insert into BEG_FIS_MTZ_TRIB_LOG\n  values\n    ('OLD',\n     :OLD.BEG_FIS_MATRIZ_TRIBUTARIA_ID,\n     :OLD.AD_CLIENT_ID,\n     :OLD.AD_ORG_ID,\n     :OLD.ISACTIVE,\n     :OLD.VALUE,\n     :OLD.CREATED,\n     :OLD.CREATEDBY,\n     :OLD.UPDATED,\n     :OLD.UPDATEDBY,\n     :OLD.PERC_IPI,\n     :OLD.PERC_ICM,\n     :OLD.PERC_PIS,\n     :OLD.PERC_COFINS,\n     :OLD.PERC_ISSQN,\n     :OLD.PERC_IRRF,\n     :OLD.PERC_IPI_DIFERIDO,\n     :OLD.PERC_FUNRURAL,\n     :OLD.BEG_UF_ID,\n     :OLD.TP_TRIB_ICMS,\n     :OLD.TP_TRIB_IPI,\n     :OLD.BEG_FIS_ORIGEM_MERC_ID,\n     :OLD.BEG_FIS_TRIB_ICMS_ID,\n     :OLD.BEG_VEN_TIPO_PEDIDO_ID,\n     :OLD.DESC_SUFRAMA,\n     :OLD.PERC_ICM_SUBSTITUICAO,\n     :OLD.PERC_MARGEM_SUBSTITUICAO,\n     :OLD.BEG_VW_UF_ID,\n     :OLD.MVA_CLIENTE_OPTANTE_SIMPLES,\n     :OLD.BEG_FIS_CST_COFINS_ID,\n     :OLD.BEG_FIS_CST_PIS_ID,\n     :OLD.BEG_FIS_CST_IPI_ID,\n     :OLD.PERC_IR,\n     :OLD.PERC_CSSL,\n     :OLD.BEG_VEN_TP_OPERACAO_ID,\n     :OLD.OBSERVACAO,\n     :OLD.BEG_TIPO_NF_ID);\n\n  if UPDATING then\n    insert into BEG_FIS_MTZ_TRIB_LOG\n    values\n      ('NEW',\n       :NEW.BEG_FIS_MATRIZ_TRIBUTARIA_ID,\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       :NEW.ISACTIVE,\n       :NEW.VALUE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       :NEW.PERC_IPI,\n       :NEW.PERC_ICM,\n       :NEW.PERC_PIS,\n       :NEW.PERC_COFINS,\n       :NEW.PERC_ISSQN,\n       :NEW.PERC_IRRF,\n       :NEW.PERC_IPI_DIFERIDO,\n       :NEW.PERC_FUNRURAL,\n       :NEW.BEG_UF_ID,\n       :NEW.TP_TRIB_ICMS,\n       :NEW.TP_TRIB_IPI,\n       :NEW.BEG_FIS_ORIGEM_MERC_ID,\n       :NEW.BEG_FIS_TRIB_ICMS_ID,\n       :NEW.BEG_VEN_TIPO_PEDIDO_ID,\n       :NEW.DESC_SUFRAMA,\n       :NEW.PERC_ICM_SUBSTITUICAO,\n       :NEW.PERC_MARGEM_SUBSTITUICAO,\n       :NEW.BEG_VW_UF_ID,\n       :NEW.MVA_CLIENTE_OPTANTE_SIMPLES,\n       :NEW.BEG_FIS_CST_COFINS_ID,\n       :NEW.BEG_FIS_CST_PIS_ID,\n       :NEW.BEG_FIS_CST_IPI_ID,\n       :NEW.PERC_IR,\n       :NEW.PERC_CSSL,\n       :NEW.BEG_VEN_TP_OPERACAO_ID,\n       :NEW.OBSERVACAO,\n       :NEW.BEG_TIPO_NF_ID);\n  end if;\n\n  for R_COL in CR_COL\n  loop\n    if DELETING\n       or UPDATING(R_COL.COLUMNNAME) then\n      -- Busca valores old e new para a coluna\n      execute immediate 'select ' || R_COL.COLUMNNAME ||\n                        ' from beg_fis_mtz_trib_log where ind_registro = ''OLD'''\n        into VC_OLDVALUE;\n    \n      if DELETING then\n        VC_NEWVALUE := null;\n      else\n        execute immediate 'select ' || R_COL.COLUMNNAME ||\n                          ' from beg_fis_mtz_trib_log where ind_registro = ''NEW'''\n          into VC_NEWVALUE;\n      end if;\n    \n      if NVL(VC_OLDVALUE, '^') <> NVL(VC_NEWVALUE, '^') then\n      \n        insert into AD_CHANGELOG\n          (AD_CHANGELOG_ID,\n           AD_SESSION_ID,\n           AD_TABLE_ID,\n           AD_COLUMN_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           CREATEDBY,\n           UPDATEDBY,\n           RECORD_ID,\n           OLDVALUE,\n           NEWVALUE)\n        values\n          (BEG_FNC_AD_SEQUENCE('AD_ChangeLog') -- ad_changelog_id\n          ,\n           BEG_PCK_AD_DICTIONARY.VN_AD_SESSION_ID -- ad_session_id\n          ,\n           R_COL.AD_TABLE_ID -- ad_table_id\n          ,\n           R_COL.AD_COLUMN_ID -- ad_column_id\n          ,\n           BEG_PCK_AD_DICTIONARY.VN_AD_CLIENT_ID -- ad_client_id\n          ,\n           BEG_PCK_AD_DICTIONARY.VN_AD_ORG_ID -- ad_org_id\n          ,\n           BEG_PCK_AD_DICTIONARY.VN_AD_USER_ID -- createdby\n          ,\n           BEG_PCK_AD_DICTIONARY.VN_AD_USER_ID -- updatedby\n          ,\n           NVL(:NEW.BEG_FIS_MATRIZ_TRIBUTARIA_ID,\n               :OLD.BEG_FIS_MATRIZ_TRIBUTARIA_ID) -- record_id\n          ,\n           VC_OLDVALUE,\n           VC_NEWVALUE);\n      \n      end if;\n    end if;\n  end loop;\n\n  delete from BEG_FIS_MTZ_TRIB_LOG;\n\nend BEG_TRG_AUD_LOG_MTZ_TRIB;\n"}`;
    
    }
}
