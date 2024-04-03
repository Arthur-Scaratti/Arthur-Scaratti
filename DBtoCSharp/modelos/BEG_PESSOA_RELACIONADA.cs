
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PESSOA_RELACIONADA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_RELACIONADA_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
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
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string E_MAIL { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PESSOA_RELACIONADA_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string RAMAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string BEG_TP_PESSOA_RELACIONADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PADRAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FONE_COMERCIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CELULAR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FAX { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_VENDA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string PLACA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_UF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_TP_CONTATO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_PES_RELA_CE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n\n\n      :new.NOME :=fnc_beg_remove_ce(:new.NOME);\n      :new.FONE :=fnc_beg_remove_ce(:new.FONE);\n      :new.E_MAIL :=fnc_beg_remove_ce(:new.E_MAIL);\n      :new.OBSERVACAO :=fnc_beg_remove_ce(:new.OBSERVACAO);\n      :new.RAMAL :=fnc_beg_remove_ce(:new.RAMAL);\n      :new.FONE_COMERCIAL :=fnc_beg_remove_ce(:new.FONE_COMERCIAL);\n      :new.CELULAR :=fnc_beg_remove_ce(:new.CELULAR);\n      :new.FAX :=fnc_beg_remove_ce(:new.FAX);\n\n\nend DIE_TRG_BIU_BEG_PES_RELA_CE;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_REPL_PES_RELAC { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"begin\n\n  -- Somente quando a situacao do registro não tiver sido alterada\n  if :new.ISACTIVE = :old.ISACTIVE then\n    if not DELETING\n       and :new.ISACTIVE = :old.ISACTIVE then\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    else\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n    end if;\n  end if;\n\nend DIE_TRG_BIUD_REPL_PES_RELAC;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_PES_RELAC { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  pragma autonomous_transaction;\n  V_TIPO_PESSOA varchar2(3);\n  --  V_FONE          varchar(20);\n  --  V_FONECOMERCIAL varchar(20);\n  --  V_CELULAR       varchar(20);\n  --  V_FAX           varchar(20);\n\n  --\n  cursor BUSCA_REP is\n    select 1\n      from BEG_VW_PREPOSTO R\n     where R.BEG_VW_PREPOSTO_ID = :new.BEG_VW_PESSOA_RELACIONADA_ID;\n  --\n  cursor BUSCA_TEL is\n    select 1\n      from BEG_VW_TELEVENDA TV\n     where TV.BEG_VW_TELEVENDA_ID = :new.BEG_VW_PESSOA_RELACIONADA_ID;\n  --\n  VREG1 BUSCA_REP%rowtype;\n  --\n  cursor BUSCA_TRA is\n    select 1\n      from BEG_VW_TRANSPORTADORA R\n     where R.BEG_VW_TRANSPORTADORA_ID = :new.BEG_VW_PESSOA_RELACIONADA_ID;\n  --\n  --\n  /*  cursor C_BEG_TELEFONE_PESSOA(P_BEG_PESSOA_ID number) is\n      select * from BEG_TELEFONE where BEG_PESSOA_ID = P_BEG_PESSOA_ID;\n  \n    cursor C_BEG_TELEFONE_PESSOA_EXISTE(P_BEG_PESSOA_ID number, P_TIPO char) is\n      select 1\n        from BEG_TELEFONE\n       where BEG_PESSOA_ID = P_BEG_PESSOA_ID\n         and TP_TELEFONE = P_TIPO;\n    V_EXISTE number;\n  */\n  --\nbegin\n  V_TIPO_PESSOA := :new.BEG_TP_PESSOA_RELACIONADA;\n  if V_TIPO_PESSOA = 'REP' then\n    open BUSCA_REP;\n    fetch BUSCA_REP\n      into VREG1;\n    if BUSCA_REP%notfound then\n      RAISE_APPLICATION_ERROR(-20501,\n                              'REPRESENTANTE INEXISTENTE ' ||\n                              :new.BEG_VW_PESSOA_RELACIONADA_ID);\n    end if;\n    close BUSCA_REP;\n  elsif V_TIPO_PESSOA = 'TEL' then\n    open BUSCA_TEL;\n    fetch BUSCA_TEL\n      into VREG1;\n    if BUSCA_TEL%notfound then\n      RAISE_APPLICATION_ERROR(-20502,\n                              'TELE VENDA INEXISTENTE ' ||\n                              :new.BEG_VW_PESSOA_RELACIONADA_ID);\n    end if;\n    close BUSCA_TEL;\n  elsif V_TIPO_PESSOA = 'TRA' then\n    open BUSCA_TRA;\n    fetch BUSCA_TRA\n      into VREG1;\n    if BUSCA_TRA%notfound then\n      RAISE_APPLICATION_ERROR(-20503, 'TRANSPORTADORA INEXISTENTE');\n    end if;\n    close BUSCA_TRA;\n  elsif -- AOK -- 02/04/2007 \n   V_TIPO_PESSOA = 'CON' then\n    :new.BEG_VW_PESSOA_RELACIONADA_ID := null;\n  end if;\n  --\n\n  -- AOK -- 18/01/2007 - Desabiltado pois existe falha no procedimento\n  -------------------------------------------------\n  --Atualizando telefones da pessoa relacionada  --\n  -------------------------------------------------\n  /*  for R in C_BEG_TELEFONE_PESSOA(:new.BEG_VW_PESSOA_RELACIONADA_ID)\n    loop\n      if R.TP_TELEFONE = 'O' then\n        V_FONECOMERCIAL := R.value;\n      elsif R.TP_TELEFONE = 'R' then\n        V_FONE := R.value;\n      elsif R.TP_TELEFONE = 'C' then\n        V_CELULAR := R.value;\n      elsif R.TP_TELEFONE = 'F' then\n        V_FAX := R.value;\n      end if;\n    end loop;\n  \n    if INSERTING then\n      if :new.FONE is null then\n        :new.FONE := V_FONE;\n      end if;\n  \n      if :new.FONE_COMERCIAL is null then\n        :new.FONE_COMERCIAL := V_FONECOMERCIAL;\n      end if;\n  \n      if :new.CELULAR is null then\n        :new.CELULAR := V_CELULAR;\n      end if;\n  \n      if :new.FAX is null then\n        :new.FAX := V_FAX;\n      end if;\n  \n    end if;\n  \n    if UPDATING then\n  \n      if :new.FONE is not null\n         and :new.FONE <> NVL(:old.FONE, 0) then\n        V_EXISTE := 0;\n        open C_BEG_TELEFONE_PESSOA_EXISTE(:new.BEG_VW_PESSOA_RELACIONADA_ID,\n                                          'R');\n        fetch C_BEG_TELEFONE_PESSOA_EXISTE\n          into V_EXISTE;\n        close C_BEG_TELEFONE_PESSOA_EXISTE;\n  \n        if NVL(V_EXISTE, 0) = 1 then\n          update BEG_TELEFONE\n             set value = :new.FONE\n           where BEG_PESSOA_ID = :new.BEG_VW_PESSOA_RELACIONADA_ID\n             and TP_TELEFONE = 'R';\n        else\n          insert into BEG_TELEFONE\n            (BEG_TELEFONE_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             DDD,\n             value,\n             TP_TELEFONE,\n             BEG_PESSOA_ID)\n          values\n            (BEG_FNC_AD_SEQUENCE('BEG_TELEFONE'),\n             :new.AD_CLIENT_ID,\n             :new.AD_ORG_ID,\n             'Y',\n             :new.CREATED,\n             :new.CREATEDBY,\n             :new.UPDATED,\n             :new.UPDATEDBY,\n             :new.DDD,\n             :new.FONE,\n             'R',\n             :new.BEG_VW_PESSOA_RELACIONADA_ID);\n        end if;\n      end if;\n  \n      if :new.FONE_COMERCIAL is not null\n         and :new.FONE_COMERCIAL <> NVL(:old.FONE_COMERCIAL, 0) then\n        V_EXISTE := 0;\n        open C_BEG_TELEFONE_PESSOA_EXISTE(:new.BEG_VW_PESSOA_RELACIONADA_ID,\n                                          'O');\n        fetch C_BEG_TELEFONE_PESSOA_EXISTE\n          into V_EXISTE;\n        close C_BEG_TELEFONE_PESSOA_EXISTE;\n  \n        if NVL(V_EXISTE, 0) = 1 then\n          update BEG_TELEFONE\n             set value = :new.FONE_COMERCIAL\n           where BEG_PESSOA_ID = :new.BEG_VW_PESSOA_RELACIONADA_ID\n             and TP_TELEFONE = 'O';\n        else\n          insert into BEG_TELEFONE\n            (BEG_TELEFONE_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             DDD,\n             value,\n             TP_TELEFONE,\n             BEG_PESSOA_ID)\n          values\n            (BEG_FNC_AD_SEQUENCE('BEG_TELEFONE'),\n             :new.AD_CLIENT_ID,\n             :new.AD_ORG_ID,\n             'Y',\n             :new.CREATED,\n             :new.CREATEDBY,\n             :new.UPDATED,\n             :new.UPDATEDBY,\n             :new.DDD,\n             :new.FONE_COMERCIAL,\n             'O',\n             :new.BEG_VW_PESSOA_RELACIONADA_ID);\n        end if;\n      end if;\n  \n      if :new.CELULAR is not null\n         and :new.CELULAR <> NVL(:old.CELULAR, 0) then\n        V_EXISTE := 0;\n        open C_BEG_TELEFONE_PESSOA_EXISTE(:new.BEG_VW_PESSOA_RELACIONADA_ID,\n                                          'C');\n        fetch C_BEG_TELEFONE_PESSOA_EXISTE\n          into V_EXISTE;\n        close C_BEG_TELEFONE_PESSOA_EXISTE;\n        if NVL(V_EXISTE, 0) = 1 then\n          update BEG_TELEFONE\n             set value = :new.CELULAR\n           where BEG_PESSOA_ID = :new.BEG_VW_PESSOA_RELACIONADA_ID\n             and TP_TELEFONE = 'C';\n        else\n          insert into BEG_TELEFONE\n            (BEG_TELEFONE_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             DDD,\n             value,\n             TP_TELEFONE,\n             BEG_PESSOA_ID)\n          values\n            (BEG_FNC_AD_SEQUENCE('BEG_TELEFONE'),\n             :new.AD_CLIENT_ID,\n             :new.AD_ORG_ID,\n             'Y',\n             :new.CREATED,\n             :new.CREATEDBY,\n             :new.UPDATED,\n             :new.UPDATEDBY,\n             :new.DDD,\n             :new.CELULAR,\n             'C',\n             :new.BEG_VW_PESSOA_RELACIONADA_ID);\n        end if;\n      end if;\n  \n      if :new.FAX is not null\n         and :new.FAX <> NVL(:old.FAX, 0) then\n        V_EXISTE := 0;\n        open C_BEG_TELEFONE_PESSOA_EXISTE(:new.BEG_VW_PESSOA_RELACIONADA_ID,\n                                          'F');\n        fetch C_BEG_TELEFONE_PESSOA_EXISTE\n          into V_EXISTE;\n        close C_BEG_TELEFONE_PESSOA_EXISTE;\n  \n        if NVL(V_EXISTE, 0) = 1 then\n          update BEG_TELEFONE\n             set value = :new.FAX\n           where BEG_PESSOA_ID = :new.BEG_VW_PESSOA_RELACIONADA_ID\n             and TP_TELEFONE = 'F';\n        else\n          insert into BEG_TELEFONE\n            (BEG_TELEFONE_ID,\n             AD_CLIENT_ID,\n             AD_ORG_ID,\n             ISACTIVE,\n             CREATED,\n             CREATEDBY,\n             UPDATED,\n             UPDATEDBY,\n             DDD,\n             value,\n             TP_TELEFONE,\n             BEG_PESSOA_ID)\n          values\n            (BEG_FNC_AD_SEQUENCE('BEG_TELEFONE'),\n             :new.AD_CLIENT_ID,\n             :new.AD_ORG_ID,\n             'Y',\n             :new.CREATED,\n             :new.CREATEDBY,\n             :new.UPDATED,\n             :new.UPDATEDBY,\n             :new.DDD,\n             :new.FAX,\n             'F',\n             :new.BEG_VW_PESSOA_RELACIONADA_ID);\n        end if;\n      end if;\n  \n    end if;\n    commit;\n  */\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_PESSOA_RELACIONADA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  pragma autonomous_transaction;\n  cursor BUSCA_PESSOA_REL is\n    select DECODE(R.BEG_TP_PESSOA_RELACIONADA,\n                  'PPO',\n                  'PREPOSTO',\n                  'TRA',\n                  'TRANSPORTADORA',\n                  'REP',\n                  'REPRESENTANTE',\n                  'COB',\n                  'COBRANCA',\n                  'ENT',\n                  'ENTREGA',\n                  'CON',\n                  'CONTATO',\n                  'TEL',\n                  'TELE-VENDAS',\n                  'RPF',\n                  'REPRES. FORNECEDOR',\n                  'GER',\n                  'GERENTE',\n                  'CAI',\n                  'CAIXA',\n                  'CRE',\n                  'CREDIARISTA') TP_PESSOA\n      from BEG_PESSOA_RELACIONADA R\n     where R.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and R.BEG_TP_PESSOA_RELACIONADA = :new.BEG_TP_PESSOA_RELACIONADA\n       and R.PADRAO = 'Y'\n       and :new.PADRAO = 'Y'\n       and R.BEG_PESSOA_RELACIONADA_ID <> :new.BEG_PESSOA_RELACIONADA_ID;\n  --\n  VREG1 BUSCA_PESSOA_REL%rowtype;\n  -- aok - 16/08/2006\n  -- AOK -- 06/03/2008\n/*  cursor BUSCA_PESSOA is\n    select 1\n      from BEG_PESSOA P\n     where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and P.CLIENTE = 'Y'\n       and P.VENDEDOR = 'Y'; -- AOK - 02/10/2006\n  VLIXO number;\n*/  --\n  -- Representante - AOK - 24/08/2006\n  --\n  cursor CONF_REP(PCOD number) is\n    select count(*) QTD_REP\n      from BEG_PESSOA_RELACIONADA PR\n     where PR.BEG_TP_PESSOA_RELACIONADA in ('REP', 'TEL', 'RPF')\n       and PR.BEG_PESSOA_ID = PCOD\n       and PR.ISACTIVE = 'Y';\n  RCONF_REP CONF_REP%rowtype;\n  --\n  -- Conferencia dos Tele Vendedor - AOK - 29/08/2006\n  --\n  --  cursor CONF_TEL(PCOD number) is\n  --    select count(*) QTD_TEL\n  --      from BEG_PESSOA_RELACIONADA PR\n  --     where PR.BEG_TP_PESSOA_RELACIONADA = 'TEL'\n  --       and PR.BEG_PESSOA_ID = PCOD\n  --       and PR.ISACTIVE = 'Y';\n  --  RCONF_TEL CONF_TEL%rowtype;\n  --  \nbegin\n  -- AOK - 24/08/2006\n  if :new.BEG_TP_PESSOA_RELACIONADA in ('TEL', 'REP', 'RPF') then\n    open CONF_REP(:new.BEG_PESSOA_ID);\n    fetch CONF_REP\n      into RCONF_REP;\n    if NVL(RCONF_REP.QTD_REP, 0) < 2 then\n      :new.PADRAO := 'Y';\n    end if;\n    close CONF_REP;\n  end if;\n  -- AOK - 29/08/2006\n  /*  if :new.BEG_TP_PESSOA_RELACIONADA = 'TEL' then\n    open CONF_TEL(:new.BEG_PESSOA_ID);\n    fetch CONF_TEL\n      into RCONF_TEL;\n    if NVL(RCONF_TEL.QTD_TEL, 0) < 2 then\n      :new.PADRAO := 'Y';\n    end if;\n    close CONF_TEL;\n  end if;  */\n  --\n  if UPPER(:new.PADRAO) = 'N' then\n    :new.PADRAO := null;\n  else\n    --\n    open BUSCA_PESSOA_REL;\n    fetch BUSCA_PESSOA_REL\n      into VREG1;\n    if BUSCA_PESSOA_REL%found then\n      RAISE_APPLICATION_ERROR(-20501,\n                              'Somente um(a) ' || VREG1.TP_PESSOA ||\n                              ' padrao para cada parceiro. - ' ||\n                              :new.BEG_PESSOA_ID || ' / ' ||\n                              :new.BEG_PESSOA_RELACIONADA_ID);\n    end if;\n  end if;\n  -- AOK - 16/08/206\n  -- AOK -- 06/03/2008 - Gerou erro na filial 44 - estam usando incorretamente\n/*  open BUSCA_PESSOA;\n  fetch BUSCA_PESSOA\n    into VLIXO;\n  if BUSCA_PESSOA%found then\n    --\n    if :new.BEG_TP_PESSOA_RELACIONADA = 'PPO'\n       and BEG_PCK_APEX.V_APEX_VENDEDOR = 'N' then\n      RAISE_APPLICATION_ERROR(-20502,\n                              'Parceiro Comercial com tipo de pessoa relacionada invalida!');\n    end if;\n    --\n  end if;\n*/  --\nend BEG_TRG_BIU_PESSOA_RELACIONADA;\n"}`;
    
    }
}
