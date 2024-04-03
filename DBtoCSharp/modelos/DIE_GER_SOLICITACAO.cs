
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_GER_SOLICITACAO
    {
            [StringLength(2)]
        /// <summary>
        /// Status do documento
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// Indicativo para retorno do testador ao desenvolvedor
        /// </summary>
        public string IND_RETORNA_DESENV { get; set; }
            [Required]
        /// <summary>
        /// (E)rro, (S)ugestao, (M)elhoria ou (R)evisao
        /// </summary>
        public string IND_TIPO_SOLICITACAO { get; set; }
        
        /// <summary>
        /// Indicativo para reenviar email em caso de erro na primeira tentativa
        /// </summary>
        public string REENVIA_EMAIL { get; set; }
            [StringLength(200)]
        /// <summary>
        /// Quando cancelamento, obrigar uma observação
        /// </summary>
        public string OBS_CANCELAMENTO { get; set; }
        
        /// <summary>
        /// Indicativo para retorno do homologador ao desenvolvdor
        /// </summary>
        public string IND_RET_HOMOLOG_DESENV { get; set; }
        
        /// <summary>
        /// Indicativo para retorno do homologador ao testador
        /// </summary>
        public string IND_RET_HOMOLOG_TESTE { get; set; }
        
        /// <summary>
        /// Data do ultimo retorno ao desenvolvedor
        /// </summary>
        public string DT_RETORNO_DESENV { get; set; }
        
        /// <summary>
        /// Data do ultimo retorno do homologador para o desenvolvedor
        /// </summary>
        public string DT_RET_HOMOLOG_DESENV { get; set; }
        
        /// <summary>
        /// Data do ultimo retorno do homologador para o testador
        /// </summary>
        public string DT_RET_HOMOLOG_TESTE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id da solicitacao
        /// </summary>
        public int DIE_GER_SOLICITACAO_ID { get; set; }
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
            [Required]
        /// <summary>
        /// id do parceiro comercial - solicitação
        /// </summary>
        public int DIE_VW_GER_SOLICITANTE_ID { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// Descreição da Solicitação
        /// </summary>
        public string DESC_SOLICITACAO { get; set; }
        
        /// <summary>
        /// Id do desenvolvedor
        /// </summary>
        public int DIE_VW_GER_DESENVOLVEDOR_ID { get; set; }
        
        /// <summary>
        /// Data do inico do desenvolvimento
        /// </summary>
        public string DT_INICIO { get; set; }
        
        /// <summary>
        /// Data final do desenvolvimento
        /// </summary>
        public string DT_FINAL { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// Observacao do desenvolvimento
        /// </summary>
        public string OBS_DESENV { get; set; }
        
        /// <summary>
        /// Id do testador
        /// </summary>
        public int DIE_VW_GER_TESTADOR_ID { get; set; }
        
        /// <summary>
        /// Data de inicio do testador
        /// </summary>
        public string DT_INI_TST { get; set; }
        
        /// <summary>
        /// Data final do testador
        /// </summary>
        public string DT_FIN_TST { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// Observação do testador
        /// </summary>
        public string OBS_TESTADOR { get; set; }
        
        /// <summary>
        /// Id do Homologador
        /// </summary>
        public int DIE_VW_GER_HOMOLOGADOR_ID { get; set; }
        
        /// <summary>
        /// Data da homologação
        /// </summary>
        public string DT_HOMOLOGACAO { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// Observação da homologação
        /// </summary>
        public string OBS_HOMOLOGACAO { get; set; }
        
        /// <summary>
        /// Define a prioridade da solicitação
        /// </summary>
        public string PRIORIDADE { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_GER_SOLICITACAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  VC_ENVIAR               varchar2(1) := 'N';\n  VC_EMAIL_ACOMPANHAMENTO BEG_PESSOA.EMAIL%type; -- E-mail acompanhamento\n  VC_EMAIL                BEG_PESSOA.EMAIL%type; -- E-mail solicitante\n  VC_EMAIL_DESENV         BEG_PESSOA.EMAIL%type; -- E-mail desenvolvedor\n  VC_EMAIL_TESTADOR       BEG_PESSOA.EMAIL%type; -- E-mail Testador\n  VC_EMAIL_HOMOLOGADOR    BEG_PESSOA.EMAIL%type; -- E-mail homologador\n  VC_TEXTO                varchar2(4000); -- Texto Solicitante\n  VC_TEXTOD               varchar2(4000); -- Texto Desenvolvedor\n  VC_TEXTOT               varchar2(4000); -- Texto Testador\n  VC_TEXTOH               varchar2(4000); -- Texto Homologador\n  VC_TEXTOG               varchar2(4000); -- Texto Gerente\n  VC_OK                   varchar2(2) := 'OK';\n  --  VN_CODIGO            BEG_PESSOA.BEG_PESSOA_ID%type;\n\nbegin\n\n  --if UPDATING then\n  VC_ENVIAR               := 'N';\n  VC_EMAIL_ACOMPANHAMENTO := 'jailson.desenvolvimento@diementz.com.br';\n  VC_EMAIL_DESENV         := null;\n  VC_TEXTO                := null;\n  VC_TEXTOD               := null;\n  VC_TEXTOT               := null;\n  VC_TEXTOH               := null;\n  VC_TEXTOG               := null;\n  --\n  if INSERTING then\n    if NVL(LENGTH(:new.DESC_SOLICITACAO), 0) = 0 then\n      RAISE_APPLICATION_ERROR(-20001, 'Faltou a descricao da solicitacao!');\n    else\n      VC_TEXTOG := 'NOVA SOLICITAÇÃO (' || :new.value || ') - ' ||\n                   :new.DESC_SOLICITACAO;\n    end if;\n  end if;\n\n  VC_EMAIL := DIE_FNC_BUSCA_EMAIL_DESENV(:new.DIE_VW_GER_SOLICITANTE_ID);\n\n  -- Jailson Tavares 01/02/2008\n\n  if (INSERTING or UPDATING)\n     and :new.DOCSTATUS = 'CL'\n     and ((:new.DT_FINAL is null and :new.DT_FIN_TST is null and\n     :new.DT_HOMOLOGACAO is null) or\n     (:new.DT_FINAL is not null and :new.DT_FIN_TST is null and\n     :new.DT_HOMOLOGACAO is null) or\n     (:new.DT_FINAL is not null and :new.DT_FIN_TST is not null and\n     :new.DT_HOMOLOGACAO is null)) then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Para concluir esta solicitacao e necessario que todas as etapas estejam concluidas!');\n  end if;\n\n  if (INSERTING or UPDATING)\n     and :new.DOCSTATUS = 'CL'\n     and (NVL(:new.DIE_VW_GER_HOMOLOGADOR_ID, 0) > 0 or\n     NVL(:new.DIE_VW_GER_HOMOLOGADOR_ID, 0) = 0)\n     and :new.DT_HOMOLOGACAO is null then\n    RAISE_APPLICATION_ERROR(-20002,\n                            'Para concluir esta solicitacao e necessario preencher os dados da homologacao!');\n  end if;\n  --\n\n  -- Envia email para os responsaveis por cada etapa\n  if ((INSERTING and NVL(:new.DIE_VW_GER_DESENVOLVEDOR_ID, 0) > 0) or\n     (NVL(:new.DIE_VW_GER_DESENVOLVEDOR_ID, 0) <>\n     NVL(:old.DIE_VW_GER_DESENVOLVEDOR_ID, 0))) then\n    VC_EMAIL_DESENV := DIE_FNC_BUSCA_EMAIL_DESENV(:new.DIE_VW_GER_DESENVOLVEDOR_ID);\n    VC_TEXTOD       := 'Solicitacao de desenvolvimento (' || :new.value ||\n                       ') - ' || :new.DESC_SOLICITACAO;\n  end if;\n\n  if ((INSERTING and NVL(:new.DIE_VW_GER_TESTADOR_ID, 0) > 0) or\n     (NVL(:new.DIE_VW_GER_TESTADOR_ID, 0) <>\n     NVL(:old.DIE_VW_GER_TESTADOR_ID, 0))) then\n    VC_EMAIL_TESTADOR := DIE_FNC_BUSCA_EMAIL_DESENV(:new.DIE_VW_GER_TESTADOR_ID);\n    VC_TEXTOT         := 'Solicitacao de Teste (' || :new.value || ') - ' ||\n                         :new.DESC_SOLICITACAO;\n  end if;\n\n  if ((INSERTING and NVL(:new.DIE_VW_GER_HOMOLOGADOR_ID, 0) > 0) or\n     (NVL(:new.DIE_VW_GER_HOMOLOGADOR_ID, 0) <>\n     NVL(:old.DIE_VW_GER_HOMOLOGADOR_ID, 0))) then\n    VC_EMAIL_HOMOLOGADOR := DIE_FNC_BUSCA_EMAIL_DESENV(:new.DIE_VW_GER_HOMOLOGADOR_ID);\n    VC_TEXTOH            := 'Solicitacao para homologacao (' || :new.value ||\n                            ') - ' || :new.DESC_SOLICITACAO;\n  end if;\n\n  -- Gera e-mail para o solicitante quando o desenvolvimento foi atendido\n  if NVL(:new.DIE_VW_GER_DESENVOLVEDOR_ID, 0) > 0 then\n    if NVL(:new.DT_FINAL, TRUNC(sysdate + 10)) !=\n       NVL(:old.DT_FINAL, TRUNC(sysdate + 10)) then\n      if NVL(LENGTH(:new.OBS_DESENV), 0) = NVL(LENGTH(:old.OBS_DESENV), 0) then\n        RAISE_APPLICATION_ERROR(-20003,\n                                'Observacao referente ao desenvolvimento deve ser informada ou complementada');\n      end if;\n      /*select BEG_PESSOA_ID\n       into VN_CODIGO\n       from DIE_GER_DESENV DE\n      where DE.DIE_GER_DESENV_ID = :new.DIE_VW_GER_DESENVOLVEDOR_ID;*/\n      VC_TEXTO  := 'Sua solicitacao  (' || :new.value || ') - ' ||\n                   :new.DESC_SOLICITACAO ||\n                   ' que estava em fase de desenvolvimento com ' ||\n                   DIE_FNC_BUSCA_NOME_PESSOA(:new.DIE_VW_GER_DESENVOLVEDOR_ID) ||\n                   ' foi finalizado' || ' - ' || :new.OBS_DESENV;\n      VC_ENVIAR := 'Y';\n    end if;\n  end if;\n\n  -- Gera e-mail para o solicitante quando o teste foi realizado\n  if NVL(:new.DIE_VW_GER_TESTADOR_ID, 0) > 0 then\n    if :new.IND_RETORNA_DESENV = 'Y'\n       and NVL(:new.DIE_VW_GER_DESENVOLVEDOR_ID, 0) > 0 then\n      :new.IND_RETORNA_DESENV := 'N';\n      :new.DT_FIN_TST         := null;\n      :new.DT_FINAL           := null;\n      :new.DT_RETORNO_DESENV  := sysdate;\n      -- notificacao do desenvolvedor    \n      VC_EMAIL_DESENV := DIE_FNC_BUSCA_EMAIL_DESENV(:new.DIE_VW_GER_DESENVOLVEDOR_ID);\n      VC_TEXTOD       := 'Retorno ao desenvolvimento (' || :new.value ||\n                         ') - ' || :new.DESC_SOLICITACAO ||\n                         '  Conforme o resultado do teste: ' ||\n                         :new.OBS_TESTADOR;\n      -- Notificacao do Solicitante\n      VC_TEXTO  := 'Sua solicitacao  (' || :new.value || ') - ' ||\n                   :new.DESC_SOLICITACAO ||\n                   ' que estava em fase de testes com ' ||\n                   DIE_FNC_BUSCA_NOME_PESSOA(:new.DIE_VW_GER_TESTADOR_ID) ||\n                   ' retornou ao desenvolvedor, confome resultado de teste: ' ||\n                   ' - ' || :new.OBS_TESTADOR;\n      VC_ENVIAR := 'Y';\n    else\n      -- Jailson Tavares 11/02/2008 \n      -- envio email após retorno ao desenvolvimento\n      if :new.DT_FINAL is not null\n         and :new.DIE_VW_GER_TESTADOR_ID > 0\n         and :new.DT_FIN_TST is null\n         and :new.DT_RETORNO_DESENV is not null then\n      \n        VC_EMAIL_TESTADOR := DIE_FNC_BUSCA_EMAIL_DESENV(:new.DIE_VW_GER_TESTADOR_ID);\n        VC_TEXTOT         := 'A solicitacao que retornou ao desenvolvimento (' ||\n                             :new.value || ') - ' || :new.DESC_SOLICITACAO ||\n                             ' está disponivel para novos testes. ' ||\n                             ' ***** ' || :new.OBS_DESENV;\n        VC_ENVIAR         := 'Y';\n      \n      else\n      \n        if NVL(:new.DT_FIN_TST, TRUNC(sysdate + 10)) !=\n           NVL(:old.DT_FIN_TST, TRUNC(sysdate + 10)) then\n          if NVL(LENGTH(:new.OBS_TESTADOR), 0) =\n             NVL(LENGTH(:old.OBS_TESTADOR), 0) then\n            RAISE_APPLICATION_ERROR(-20004,\n                                    'Observacao referente aos testes deve ser informada ou complementada');\n          end if;\n          /*select BEG_PESSOA_ID\n           into VN_CODIGO\n           from DIE_GER_DESENV DE\n          where DE.DIE_GER_DESENV_ID = :new.DIE_VW_GER_DESENVOLVEDOR_ID;*/\n          VC_TEXTO  := 'Sua solicitacao  (' || :new.value || ') - ' ||\n                       :new.DESC_SOLICITACAO ||\n                       ' que estava em fase de testes com ' ||\n                       DIE_FNC_BUSCA_NOME_PESSOA(:new.DIE_VW_GER_TESTADOR_ID) ||\n                       ' foi finalizado' || ' - ' || :new.OBS_TESTADOR;\n          VC_ENVIAR := 'Y';\n        end if;\n      end if;\n    end if;\n  end if;\n\n  -- Gera e-mail para o solicitante quando a solicitacao for homologada\n\n  /* Jailson Tavares 28/01/2008 */\n\n  -- retorno do homologador ao desenvolvedor\n\n  if NVL(:new.DIE_VW_GER_HOMOLOGADOR_ID, 0) > 0 then\n    if :new.IND_RET_HOMOLOG_DESENV = 'Y'\n       and NVL(:new.DIE_VW_GER_DESENVOLVEDOR_ID, 0) > 0 then\n      :new.IND_RET_HOMOLOG_DESENV := 'N';\n      :new.DT_HOMOLOGACAO         := null;\n      :new.DT_FINAL               := null;\n      :new.DT_FIN_TST             := null;\n      :new.DT_RET_HOMOLOG_DESENV  := sysdate;\n      -- notificacao do desenvolvedor    \n      VC_EMAIL_DESENV := DIE_FNC_BUSCA_EMAIL_DESENV(:new.DIE_VW_GER_DESENVOLVEDOR_ID);\n      VC_TEXTOD       := 'Retorno ao desenvolvimento (' || :new.value ||\n                         ') - ' || :new.DESC_SOLICITACAO ||\n                         '  Conforme o resultado da homologacao: ' ||\n                         :new.OBS_HOMOLOGACAO;\n      -- Notificacao do Solicitante\n      VC_TEXTO  := 'Sua solicitacao  (' || :new.value || ') - ' ||\n                   :new.DESC_SOLICITACAO ||\n                   ' que estava em fase de homologacao com ' ||\n                   DIE_FNC_BUSCA_NOME_PESSOA(:new.DIE_VW_GER_HOMOLOGADOR_ID) ||\n                   ' retornou ao desenvolvedor, confome resultado da homologacao: ' ||\n                   ' - ' || :new.OBS_HOMOLOGACAO;\n      VC_ENVIAR := 'Y';\n    else\n      -- Jailson Tavares 11/02/2008 \n      -- envio email após retorno ao desenvolvimento pelo homologador\n      if :new.DT_FIN_TST is not null\n         and :new.DIE_VW_GER_HOMOLOGADOR_ID > 0\n         and :new.DT_FIN_TST is null\n         and :new.DT_RET_HOMOLOG_DESENV is not null then\n      \n        VC_EMAIL_HOMOLOGADOR := DIE_FNC_BUSCA_EMAIL_DESENV(:new.DIE_VW_GER_HOMOLOGADOR_ID);\n        VC_TEXTOH            := 'A solicitacao que retornou ao desenvolvimento (' ||\n                                :new.value || ') - ' ||\n                                :new.DESC_SOLICITACAO ||\n                                ' esta disponivel para homologacao. ' ||\n                                ' ***** ' || :new.OBS_TESTADOR;\n        VC_ENVIAR            := 'Y';\n      \n      else\n      \n        if NVL(:new.DT_HOMOLOGACAO, TRUNC(sysdate + 10)) !=\n           NVL(:old.DT_HOMOLOGACAO, TRUNC(sysdate + 10)) then\n          if NVL(LENGTH(:new.OBS_HOMOLOGACAO), 0) =\n             NVL(LENGTH(:old.OBS_HOMOLOGACAO), 0) then\n            RAISE_APPLICATION_ERROR(-20005,\n                                    'Observacao referente a homologacao deve ser informada ou complementada');\n          end if;\n          VC_TEXTO  := 'Sua solicitacao  (' || :new.value || ') - ' ||\n                       :new.DESC_SOLICITACAO ||\n                       ' que estava em fase de homologacao com ' ||\n                       DIE_FNC_BUSCA_NOME_PESSOA(:new.DIE_VW_GER_HOMOLOGADOR_ID) ||\n                       ' foi finalizado' || ' - ' || :new.OBS_HOMOLOGACAO;\n          VC_ENVIAR := 'Y';\n        end if;\n      end if;\n    end if;\n  end if;\n\n  -- retorno do homologador ao testador\n\n  if NVL(:new.DIE_VW_GER_HOMOLOGADOR_ID, 0) > 0 then\n    if :new.IND_RET_HOMOLOG_TESTE = 'Y'\n       and NVL(:new.DIE_VW_GER_TESTADOR_ID, 0) > 0 then\n      :new.IND_RET_HOMOLOG_TESTE := 'N';\n      :new.DT_HOMOLOGACAO        := null;\n      :new.DT_FIN_TST            := null;\n      :new.DT_RET_HOMOLOG_TESTE  := sysdate;\n      -- notificacao do testador    \n      VC_EMAIL_TESTADOR := DIE_FNC_BUSCA_EMAIL_DESENV(:new.DIE_VW_GER_TESTADOR_ID);\n      VC_TEXTOT         := 'Retorno aos testes (' || :new.value || ') - ' ||\n                           :new.DESC_SOLICITACAO ||\n                           '  Conforme o resultado da homologacao: ' ||\n                           :new.OBS_HOMOLOGACAO;\n      -- Notificacao do Solicitante\n      VC_TEXTO  := 'Sua solicitacao  (' || :new.value || ') - ' ||\n                   :new.DESC_SOLICITACAO ||\n                   ' que estava em fase de homologacao com ' ||\n                   DIE_FNC_BUSCA_NOME_PESSOA(:new.DIE_VW_GER_HOMOLOGADOR_ID) ||\n                   ' retornou ao desenvolvedor, confome resultado da homologacao: ' ||\n                   ' - ' || :new.OBS_HOMOLOGACAO;\n      VC_ENVIAR := 'Y';\n    else\n      -- Jailson Tavares 11/02/2008 \n      -- envio email após retorno ao teste pelo homologador\n      if :new.DT_FIN_TST is not null\n         and :new.DIE_VW_GER_HOMOLOGADOR_ID > 0\n         and :new.DT_FIN_TST is null\n         and :new.DT_RET_HOMOLOG_DESENV is not null then\n      \n        VC_EMAIL_HOMOLOGADOR := DIE_FNC_BUSCA_EMAIL_DESENV(:new.DIE_VW_GER_HOMOLOGADOR_ID);\n        VC_TEXTOH            := 'A solicitacao que retornou ao teste (' ||\n                                :new.value || ') - ' ||\n                                :new.DESC_SOLICITACAO ||\n                                ' esta disponivel para homologacao. ' ||\n                                ' ***** ' || :new.OBS_TESTADOR;\n        VC_ENVIAR            := 'Y';\n      \n        if NVL(:new.DT_HOMOLOGACAO, TRUNC(sysdate + 10)) !=\n           NVL(:old.DT_HOMOLOGACAO, TRUNC(sysdate + 10)) then\n          if NVL(LENGTH(:new.OBS_HOMOLOGACAO), 0) =\n             NVL(LENGTH(:old.OBS_HOMOLOGACAO), 0) then\n            RAISE_APPLICATION_ERROR(-20006,\n                                    'Observacao referente a homologacao deve ser informada ou complementada');\n          end if;\n          VC_TEXTO  := 'Sua solicitacao  (' || :new.value || ') - ' ||\n                       :new.DESC_SOLICITACAO ||\n                       ' que estava em fase de homologacao com ' ||\n                       DIE_FNC_BUSCA_NOME_PESSOA(:new.DIE_VW_GER_HOMOLOGADOR_ID) ||\n                       ' foi finalizado' || ' - ' || :new.OBS_HOMOLOGACAO;\n          VC_ENVIAR := 'Y';\n        end if;\n      end if;\n    end if;\n  end if;\n  --\n\n  -- Envio de e-mail\n\n  if VC_TEXTOG is not null\n     and :new.DIE_VW_GER_SOLICITANTE_ID <> 1000000 then\n    BEG_PRC_MAIL('compiere@diementz.com.br',\n                 VC_EMAIL_ACOMPANHAMENTO,\n                 'Inclusao de Solicitacao',\n                 VC_TEXTOG,\n                 VC_OK);\n  end if;\n\n  if VC_ENVIAR = 'Y' then\n    BEG_PRC_MAIL('compiere@diementz.com.br',\n                 VC_EMAIL,\n                 'Solicitacao para o Desenvolvimento',\n                 VC_TEXTO,\n                 VC_OK);\n  end if;\n\n  if VC_EMAIL_DESENV is not null then\n    BEG_PRC_MAIL('compiere@diementz.com.br',\n                 VC_EMAIL_DESENV,\n                 'Solicitacao de Desenvolvimento',\n                 VC_TEXTOD,\n                 VC_OK);\n  end if;\n\n  if VC_EMAIL_TESTADOR is not null then\n    BEG_PRC_MAIL('compiere@diementz.com.br',\n                 VC_EMAIL_TESTADOR,\n                 'Solicitacao de Teste',\n                 VC_TEXTOT,\n                 VC_OK);\n  end if;\n\n  if VC_EMAIL_HOMOLOGADOR is not null then\n    BEG_PRC_MAIL('compiere@diementz.com.br',\n                 VC_EMAIL_HOMOLOGADOR,\n                 'Solicitacao para Homologacao',\n                 VC_TEXTOH,\n                 VC_OK);\n  end if;\nend DIE_TRG_BIU_GER_SOLICITACAO;\n"}`;
    
    }
}
