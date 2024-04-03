
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PESSOA_RESTRICAO
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do Relacionamento entre Parceiro Comercial e a Restricao
        /// </summary>
        public int BEG_PESSOA_RESTRICAO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Filial responsavel pela restricao
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
        
        /// <summary>
        /// Data de inclusao da pessoa nesta restricao
        /// </summary>
        public string DT_INCLUSAO { get; set; }
        
        /// <summary>
        /// Data de retirada da pessoa desta restricao
        /// </summary>
        public string DT_SAIDA { get; set; }
            [Required]
        /// <summary>
        /// Id da Restricao
        /// </summary>
        public int BEG_RESTRICAO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do Parceiro Comercial
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// id do Orgao Gerador da restricao
        /// </summary>
        public int BEG_ORGAO_GERADOR_ID { get; set; }
        
        /// <summary>
        /// id do motivo da baixa
        /// </summary>
        public int BEG_MOTIVO_BAIXA_ID { get; set; }
        
        /// <summary>
        /// Filial responsavel pela restricao
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [StringLength(300)]
        /// <summary>
        /// Observacao
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// Indica se a restricao foi criada automaticamente
        /// </summary>
        public string IND_AUTOMATICA { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario do Apex
        /// </summary>
        public string APP_USER { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_PESSOA_RESTRICAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor CRESTR is\n    select *\n      from BEG_PESSOA_RESTRICAO PR\n     where PR.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and PR.BEG_RESTRICAO_ID = :new.BEG_RESTRICAO_ID\n       and (PR.BEG_ORGAO_GERADOR_ID = NVL(:new.BEG_ORGAO_GERADOR_ID, 0) or\n           NVL(:new.BEG_ORGAO_GERADOR_ID, 0) = 0)\n       and not (PR.BEG_RESTRICAO_ID in (2000003) -- Não vender a crediario;\n            and PR.BEG_ORGAO_GERADOR_ID in (2000000, 2000001, 2000002)) -- SPC, Cartorio ou Juridico\n       and case when PR.DT_SAIDA > sysdate then null else PR.DT_SAIDA end is null;\n  RRESTR CRESTR%rowtype;\n  --\n  cursor CRESTR2 is\n    select *\n      from BEG_RESTRICAO RES\n     where RES.BEG_RESTRICAO_ID = :new.BEG_RESTRICAO_ID;\n  RRESTR2 CRESTR2%rowtype;\n  --\nbegin\n\n  -- JT 12/01/2010\n  \n if :new.DT_SAIDA <> rrestr.dt_saida then\n  if :new.DT_SAIDA < :new.DT_INCLUSAO\n     or :new.DT_SAIDA < TRUNC(sysdate) then\n  \n    RAISE_APPLICATION_ERROR(-20001,\n                            'Data de saída não pode ser menor que data de hoje e deve ser maior que a data de inclusão!');\n  \n  end if;\n end if; \n  -- JT 12/01/2010\n\n  if INSERTING then\n  \n    open CRESTR;\n    fetch CRESTR\n      into RRESTR;\n    if CRESTR%found then\n      close CRESTR;\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Cliente já possui esta restrição! Consulte-o pelo CPF ....  ');\n    end if;\n    close CRESTR;\n    --\n    -- AOK - 16/04/2009\n    open CRESTR2;\n    fetch CRESTR2\n      into RRESTR2;\n    if CRESTR2%notfound then\n      close CRESTR2;\n      RAISE_APPLICATION_ERROR(-20002, 'Problema no acesso as Restricoes');\n    end if;\n    if RRESTR2.DIE_ELIMINA_DIVERGENCIA = 'Y' then\n      delete DIE_COB_DIVERGENCIA X\n       where X.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    end if;\n    --\n  end if;\n  \n  if :new.beg_restricao_id= 2000004 then   --Falecido nao permitir colocar data de saida\n    \n     :new.dt_saida := null;\n  \n  end if;\n  \n\nend DIE_TRG_BI_PESSOA_RESTRICAO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BI_PESSOA_RESTRICAO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  cursor CRESTR is\n    select *\n      from BEG_PESSOA_RESTRICAO PR\n     where PR.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and PR.BEG_RESTRICAO_ID = :new.BEG_RESTRICAO_ID\n       and (PR.BEG_ORGAO_GERADOR_ID = NVL(:new.BEG_ORGAO_GERADOR_ID, 0) or\n           NVL(:new.BEG_ORGAO_GERADOR_ID, 0) = 0)\n       and not (PR.BEG_RESTRICAO_ID in (2000003) -- Não vender a crediario;\n            and PR.BEG_ORGAO_GERADOR_ID in (2000000, 2000001, 2000002)) -- SPC, Cartorio ou Juridico\n       and case when PR.DT_SAIDA > sysdate then null else PR.DT_SAIDA end is null;\n  RRESTR CRESTR%rowtype;\n  --\n  cursor CRESTR2 is\n    select *\n      from BEG_RESTRICAO RES\n     where RES.BEG_RESTRICAO_ID = :new.BEG_RESTRICAO_ID;\n  RRESTR2 CRESTR2%rowtype;\n  --\nbegin\n  --\n  /*\n  if INSERTING\n     or UPDATING\n     and :new.DT_SAIDA < :new.DT_INCLUSAO\n     or :new.DT_SAIDA < TRUNC(sysdate) then\n  \n    RAISE_APPLICATION_ERROR(-20001,\n                            'Data de saída não pode menor que data de hoje e deve ser maior que a data de inclusão!');\n  \n  end if;\n*/\n  open CRESTR;\n  fetch CRESTR\n    into RRESTR;\n  if CRESTR%found then\n    close CRESTR;\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Cliente já possui esta restrição! Consulte-o pelo CPF ....  ');\n  end if;\n  close CRESTR;\n  --\n  -- AOK - 16/04/2009\n  open CRESTR2;\n  fetch CRESTR2\n    into RRESTR2;\n  if CRESTR2%notfound then\n    close CRESTR2;\n    RAISE_APPLICATION_ERROR(-20002, 'Problema no acesso as Restricoes');\n  end if;\n  if RRESTR2.DIE_ELIMINA_DIVERGENCIA = 'Y' then\n    delete DIE_COB_DIVERGENCIA X\n     where X.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  end if;\n  --\nend DIE_TRG_BI_PESSOA_RESTRICAO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_PES_REST_CE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n\n\n      :new.OBSERVACAO :=fnc_beg_remove_ce(:new.OBSERVACAO);\n\n\n\n\nend DIE_TRG_BIU_BEG_PES_REST_CE;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_PESSOA_RESTAPEX { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  VB_APEX boolean;\nbegin\n  if :new.APP_USER is not null\n     and INSERTING then\n    VB_APEX            := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n                                                                   'BEG_PESSOA_RESTRICAO',\n                                                                   :new.AD_CLIENT_ID,\n                                                                   :new.AD_ORG_ID,\n                                                                   :new.CREATED,\n                                                                   :new.CREATEDBY,\n                                                                   :new.UPDATED,\n                                                                   :new.UPDATEDBY,\n                                                                   :new.BEG_PESSOA_RESTRICAO_ID);\n    :new.APP_USER      := null;\n    :new.BEG_FILIAL_ID := :new.AD_ORG_ID;\n    :new.AD_ORG_ID     := 0;\n  \n  end if;\n  if :new.APP_USER is not null\n     and UPDATING then\n    VB_APEX       := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TAB_UPD(:new.APP_USER,\n                                                                :new.UPDATED,\n                                                                :new.UPDATEDBY);\n    :new.APP_USER := null;\n  end if;\n\n  /*  if UPDATING\n       and :new.APP_USER is not null then\n      VB_APEX            := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n                                                                     :new.AD_CLIENT_ID,\n                                                                     :new.AD_ORG_ID,\n                                                                     :new.CREATED,\n                                                                     :new.CREATEDBY,\n                                                                     :new.UPDATED,\n                                                                     :new.UPDATEDBY);\n      :new.CREATED       := :old.CREATED;\n      :new.CREATEDBY     := :old.CREATEDBY;\n      :new.APP_USER      := null;\n      :new.BEG_FILIAL_ID := :new.AD_ORG_ID;\n      :new.AD_ORG_ID     := 0;\n    \n    end if;\n  */\nend BEG_TRG_PESSOA_RESTAPEX;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AD_BEG_PES_REST { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  -- local variables here\n  --  pragma autonomous_transaction;\nbegin\n  insert into DIE_LOG_TABELA\n    (DIE_LOG_TABELA_ID,\n     AD_CLIENT_ID,\n     AD_ORG_ID,\n     ISACTIVE,\n     value,\n     CREATED,\n     CREATEDBY,\n     UPDATED,\n     UPDATEDBY,\n     name,\n     USUARIO,\n     BEG_PESSOA_ID)\n  values\n    (BEG_FNC_AD_SEQUENCE('DIE_LOG_TABELA'),\n     NVL(:old.AD_CLIENT_ID, 1000000), -- AD_CLIENTE_ID\n     NVL(:old.AD_ORG_ID, 0), -- AD_ORG_ID\n     'Y',\n     'BEG_PESSOA_ENDERECO', --VALUE,\n     sysdate, --CREATED,\n     0, --CREATEDBY,\n     sysdate, --UPDATED,\n     0, --UPDATEDBY,\n     :old.DT_INCLUSAO || ' ' || :old.DT_SAIDA || ' ' ||\n     :old.BEG_RESTRICAO_ID || ' ' || :old.BEG_ORGAO_GERADOR_ID || ' ' ||\n     :old.BEG_MOTIVO_BAIXA_ID || ' ' || :old.BEG_FILIAL_ID,\n     user,\n     :old.BEG_PESSOA_ID);\n  --\n  --  commit;  -- pragma autonomus_transaction\n  --\nend DIE_TRG_AD_BEG_PES_REST;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_REPL_RESTRICAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n----\nbegin\n\n  -- Somente quando a situacao do registro não tiver sido alterada\n  if :new.ISACTIVE = :old.ISACTIVE then\n    if not DELETING\n       and :new.ISACTIVE = :old.ISACTIVE then\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    else\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n    end if;\n  end if;\n\nend DIE_TRG_BIUD_REPL_RESTRICAO;\n"}`;
    
    }
}
