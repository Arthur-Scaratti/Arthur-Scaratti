
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_CONTATO
    {
        
        /// <summary>
        /// Dados bancarios da MTZ onde o cliente ficou de depositar
        /// </summary>
        public int BEG_DADOS_BANCARIOS_ID { get; set; }
        
        /// <summary>
        /// Tipo de pessoa (F)isica ou (J)uridica
        /// </summary>
        public string TP_PESSOA { get; set; }
        
        /// <summary>
        /// Funcionario (Y/N)
        /// </summary>
        public string FUNCIONARIO { get; set; }
        
        /// <summary>
        /// Data que foi enviado o cliente para o SPC
        /// </summary>
        public string DT_ENVIO_SPC { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario APEX
        /// </summary>
        public string APP_USER { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status do Contato
        /// </summary>
        public string DOCSTATUS { get; set; }
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
            [StringLength(500)]
        /// <summary>
        /// Observacoes
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// Id do parceiro comercial  - cliente
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do cobrador
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// Id da situacao do contato
        /// </summary>
        public int BEG_COB_SIT_CONTATO_ID { get; set; }
        
        /// <summary>
        /// Total do valor  em abereto
        /// </summary>
        public int VL_TOT_ABERTO { get; set; }
        
        /// <summary>
        /// Total do valor em aberto atualizado
        /// </summary>
        public int VL_TOT_ABERTO_ATUAL { get; set; }
        
        /// <summary>
        /// Total do valor prevsito de pagamento
        /// </summary>
        public int VL_TOT_PREVISTO_PGTO { get; set; }
        
        /// <summary>
        /// Data paraprevisao de pagamento
        /// </summary>
        public string DT_PREVISAO_PGTO { get; set; }
            [StringLength(250)]
        /// <summary>
        /// numeros de telefones
        /// </summary>
        public string TELEFONES { get; set; }
        
        /// <summary>
        /// Indica se atualiza data de aviso pagto nos titulos
        /// </summary>
        public string IND_ATUAL_DT_AVISO_PGTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica a atuacao do cobrador
        /// </summary>
        public string IND_ATUACAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do contato referente a cobranca
        /// </summary>
        public int BEG_COB_CONTATO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_OF_BEG_COB_CONTATO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  VC_ASSUNTO   varchar2(500);\n  VC_TEXTO     varchar2(500);\n  VC_EMAIL_CLI varchar2(100);\n  VC_EMAIL_LOJ varchar2(100);\n  V_OK         char(2);\n\n  -- Verifica se a situacao de contato envia e-mail\n  cursor C1 is\n    select SC.IND_EMAIL_LOJA,\n           SC.IND_EMAIL_CLIENTE\n      from BEG_COB_SIT_CONTATO SC\n     where SC.BEG_COB_SIT_CONTATO_ID = :new.BEG_COB_SIT_CONTATO_ID\n       and (SC.IND_EMAIL_LOJA = 'Y' or SC.IND_EMAIL_CLIENTE = 'Y');\n\n  -- Busca os dados do cliente\n  cursor C2 is\n    select P.CPFCNPJ,\n           P.name CLIENTE,\n           P.EMAIL\n      from BEG_PESSOA P\n     where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  R2 C2%rowtype;\n\n  -- Busca o e-mail da loja\n  cursor C3 is\n    select X.EMAIL\n      from BEG_PESSOA_FILIAL PF,\n           BEG_COB_PARAMETRO CP,\n           BEG_DADO_FILIAL   DF,\n           BEG_PESSOA        X\n     where PF.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n       and CP.AD_CLIENT_ID = PF.AD_CLIENT_ID\n       and CP.AD_ORG_ID = PF.BEG_FILIAL_ID\n       and CP.IND_CONTATO = 'Y'\n       and DF.AD_CLIENT_ID = PF.AD_CLIENT_ID\n       and DF.AD_ORG_ID = PF.BEG_FILIAL_ID\n       and X.BEG_PESSOA_ID = DF.BEG_PESSOA_ID\n       and PF.BEG_FILIAL_ID in -- AOK - 05/05/2009\n           (select A.AD_ORG_ID\n              from BEG_CRC_TITULO_ABERTO_ORG A\n             where A.BEG_PESSOA_ID = PF.BEG_PESSOA_ID\n               and A.DT_VCTO < TRUNC(sysdate));\n\n  -- Busca o e-mail do usuario logado no portal -- AOK - 30/10/2008\n  cursor CEMAIL_USER is\n    select U.EMAIL,\n           BEG_$P(P.name, ' ') NOME -- AOK - 03/11/2008\n      from BEG_APEX_USER U,\n           BEG_PESSOA    P\n     where UPPER(USUARIO) = :new.APP_USER\n       and P.BEG_PESSOA_ID = U.BEG_PESSOA_ID;\n  VC_EMAIL_USER BEG_APEX_USER.EMAIL%type;\n  VC_NOME_USER  varchar2(20);\n\nbegin\n  --\n  for R1 in C1\n  loop\n  \n    -- Busca os dados do cliente - incluindo e-mail\n    open C2;\n    fetch C2\n      into R2;\n    close C2;\n  \n    -- busca o e-mail do usuario logodado portal\n    VC_NOME_USER := null;\n    open CEMAIL_USER;\n    fetch CEMAIL_USER\n      into VC_EMAIL_USER, VC_NOME_USER;\n    if CEMAIL_USER%notfound\n       or VC_EMAIL_USER is null then\n      VC_EMAIL_USER := 'compiere@diementz.com.br';\n    end if;\n    close CEMAIL_USER;\n  \n    -- Busca o endereco de e-mail do fornecedor\n    for R3 in C3\n    loop\n      --\n      if R1.IND_EMAIL_LOJA = 'Y' then\n        VC_EMAIL_LOJ := R3.EMAIL;\n      end if;\n      if R1.IND_EMAIL_CLIENTE = 'Y'\n         and R2.EMAIL is not null then\n        VC_EMAIL_CLI := R2.EMAIL;\n      end if;\n      --\n      VC_ASSUNTO := 'Referente contato - crediario';\n    \n      if VC_EMAIL_USER = 'compiere@diementz.com.br' then\n        VC_TEXTO := 'NÃO RESPONDER PARA ESTE E-MAIL, ENVIO AUTOMÁTICO!' /*TS 07/07/2009*/\n                    || CHR(13) || ' ' || CHR(13) || 'A/C Crediario     ' ||\n                    CHR(13) || ' ' || CHR(13) || R2.CPFCNPJ || ' - ' ||\n                    R2.CLIENTE || CHR(13) || '  ' || CHR(13) ||\n                    :new.OBSERVACAO || '      Usuario(a): ' ||\n                    NVL(VC_NOME_USER, :new.APP_USER);\n      else\n        VC_TEXTO := 'A/C Crediario     ' || CHR(13) || ' ' || CHR(13) ||\n                    R2.CPFCNPJ || ' - ' || R2.CLIENTE || CHR(13) || '  ' ||\n                    CHR(13) || :new.OBSERVACAO || '      Usuario(a): ' ||\n                    NVL(VC_NOME_USER, :new.APP_USER);\n      end if;\n      -- :new.APP_USER; -- AOK -- 03/11/2008\n      --\n      if R1.IND_EMAIL_LOJA = 'Y' then\n        BEG_PRC_MAIL(VC_EMAIL_USER, --'compiere@diementz.com.br',\n                     VC_EMAIL_LOJ,\n                     VC_ASSUNTO,\n                     VC_TEXTO,\n                     V_OK);\n      end if;\n      --\n      if R1.IND_EMAIL_CLIENTE = 'Y' then\n        --\n        VC_TEXTO := CHR(13) || R2.CPFCNPJ || ' - ' || R2.CLIENTE || CHR(13) || '  ' ||\n                    CHR(13) || :new.OBSERVACAO;\n        --\n        BEG_PRC_MAIL(VC_EMAIL_USER, --'compiere@diementz.com.br',\n                     VC_EMAIL_CLI,\n                     'LOJA DIEMENTZ',\n                     VC_TEXTO,\n                     V_OK);\n      end if;\n    end loop;\n  end loop;\n  --\nend DIE_TRG_BIU_OF_BEG_COB_CONTATO;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_AIU_COB_CONTATO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  VN_DIASEMANA number(1);\n  VC_FUNC      varchar2(1) := 'N';\n  VC_CONTRATO  BEG_CRC_TITULO.value%type; -- AOK - 30/10/2008\n  --\n  cursor C_SIT is\n    select *\n      from BEG_COB_SIT_CONTATO SC\n     where SC.BEG_COB_SIT_CONTATO_ID = :new.BEG_COB_SIT_CONTATO_ID;\n  RSIT C_SIT%rowtype;\n\n  -- Busca dados do cobrador\n  cursor C_COBRADOR is\n    select *\n      from BEG_COBRADOR C\n     where C.BEG_COBRADOR_ID = :new.BEG_COBRADOR_ID;\n  R_COBRADOR C_COBRADOR%rowtype;\n\n  --  Buscar os titulos pendentes - AOK - 30/10/2008\n  cursor CTIT_PEND_INTERNO is\n    select *\n      from DIE_VW_COB_TIT_PEND_INT TPI\n     where TPI.BEG_PESSOA_ID = :new.BEG_PESSOA_ID --2032102\n     order by 1; -- beg_crc_titulo_id\n\n  pragma autonomous_transaction;\nbegin\n\n  if UPDATING then\n    if NVL(:new.BEG_COB_SIT_CONTATO_ID, 0) = 0 then\n      -- AOK -- 17/04/2008\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Faltou informar uma situacao para o contato!');\n    end if;\n  end if;\n  -- Conforme a situacao alterada, previsto reagendamento do contato automaticamente\n  --  if UPDATING then\n  if NVL(:new.BEG_COB_SIT_CONTATO_ID, 0) <>\n     NVL(:old.BEG_COB_SIT_CONTATO_ID, 0) then\n  \n    -- Busca dados da situacao\n    open C_SIT;\n    fetch C_SIT\n      into RSIT;\n    close C_SIT;\n    if :new.IND_ATUAL_DT_AVISO_PGTO = 'Y'\n       and RSIT.IND_REAGENDA = 'Y' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Situacao do contato incorreta - foi informado Data Aviso Pgto!');\n    end if;\n    -- Verifica o cobrador\n    open C_COBRADOR;\n    fetch C_COBRADOR\n      into R_COBRADOR;\n    close C_COBRADOR;\n    if R_COBRADOR.IND_ATUACAO = 'E' then\n      if RSIT.IND_COBRADOR = 'Y'\n         or RSIT.IND_REAGENDA = 'Y'\n         or RSIT.IND_EMAIL_LOJA = 'Y'\n         or RSIT.IND_EMAIL_CLIENTE = 'Y'\n         or RSIT.IND_OBS_TITULO = 'Y'\n         or RSIT.IND_DEPOSITO = 'Y' then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Situacao de contato incorreta para este cobrador!');\n      end if;\n    end if;\n  \n    -- Verifica se a soma de dias cai no final de semana\n    select TO_CHAR(TRUNC(sysdate) + RSIT.QTDE_DIAS, 'D')\n      into VN_DIASEMANA\n      from DUAL;\n    if VN_DIASEMANA = 7 -- (SABADO) \n     then\n      RSIT.QTDE_DIAS := RSIT.QTDE_DIAS + 2;\n    elsif VN_DIASEMANA = 1 -- (DOMINGO)\n     then\n      RSIT.QTDE_DIAS := RSIT.QTDE_DIAS + 1;\n    end if;\n    --\n    if RSIT.IND_REAGENDA = 'Y' then\n      -- if RSIT.QTDE_DIAS >= 0 then -- AOK - 03/09/2007\n      select FUNCIONARIO\n        into VC_FUNC\n        from BEG_PESSOA\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    \n      insert into BEG_COB_CONTATO\n        (BEG_COB_CONTATO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         value,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         OBSERVACAO,\n         BEG_PESSOA_ID,\n         BEG_COBRADOR_ID,\n         BEG_COB_SIT_CONTATO_ID,\n         VL_TOT_ABERTO,\n         VL_TOT_ABERTO_ATUAL,\n         VL_TOT_PREVISTO_PGTO,\n         DT_PREVISAO_PGTO,\n         TELEFONES,\n         IND_ATUAL_DT_AVISO_PGTO,\n         TP_PESSOA,\n         FUNCIONARIO,\n         DOCSTATUS)\n      values\n        (BEG_FNC_AD_SEQUENCE('BEG_COB_CONTATO'),\n         :new.AD_CLIENT_ID,\n         :new.AD_ORG_ID,\n         'Y', --ISACTIVE,\n         BEG_FNC_AD_SEQUENCE_VALUE('BEG_COB_CONTATO', :new.AD_CLIENT_ID), --VALUE,\n         --TRUNC(sysdate) + RSIT.QTDE_DIAS, --CREATED, Tiago da Silva 21/12/2009\n         sysdate + RSIT.QTDE_DIAS, --CREATED, Tiago da Silva 21/12/2009\n         :new.CREATEDBY,\n         --TRUNC(sysdate) + RSIT.QTDE_DIAS, --UPDATED, Tiago da Silva 21/12/2009\n         sysdate + RSIT.QTDE_DIAS, --UPDATED, Tiago da Silva 21/12/2009\n         :new.UPDATEDBY,\n         null, --OBSERVACAO,\n         :new.BEG_PESSOA_ID,\n         :new.BEG_COBRADOR_ID,\n         null, --BEG_COB_SIT_CONTATO_ID,\n         0, --VL_TOT_ABERTO,\n         0, --VL_TOT_ABERTO_ATUAL,\n         0, --VL_TOT_PREVISTO_PGTO,\n         null, --DT_PREVISAO_PGTO,\n         :new.TELEFONES,\n         'N', --IND_ATUAL_DT_AVISO_PGTO,\n         :new.TP_PESSOA,\n         VC_FUNC,\n         'IP'); --DOCSTATUS);\n    end if;\n    -- AOK -- 30/10/2008 - gravar a obs no titulo\n    if RSIT.IND_OBS_TITULO = 'Y'\n       and R_COBRADOR.IND_ATUACAO = 'I' then\n      VC_CONTRATO := '9999999999';\n      for RTIT_PEND in CTIT_PEND_INTERNO\n      loop\n        if RTIT_PEND.TITULO <> VC_CONTRATO then\n          VC_CONTRATO := RTIT_PEND.TITULO;\n          update BEG_CRC_TITULO T\n             set T.OBS = case when LENGTH(trim(T.OBS || ' ' || :new.OBSERVACAO)) > 500 then RPAD(trim(T.OBS || ' ' || :new.OBSERVACAO), 500) else trim(T.OBS || ' ' || :new.OBSERVACAO) end\n           where T.BEG_CRC_TITULO_ID = RTIT_PEND.BEG_CRC_TITULO_ID;\n        end if;\n      end loop;\n    end if;\n  end if;\n  --  end if;\n  commit;\n  -- AOK - 30/10/2008 - baixar um reagendamento - quando for atendido antecipadamente\n  /*  if NVL(:new.BEG_COB_SIT_CONTATO_ID, 0) <>\n       NVL(:old.BEG_COB_SIT_CONTATO_ID, 0) then\n      if :new.BEG_COB_SIT_CONTATO_ID =\n         BEG_FNC_RETORNA_PARAM_GERAL('Cobranca', null, 'CONTATO_SUCESSO') then\n        update BEG_COB_CONTATO W\n           set W.BEG_COB_SIT_CONTATO_ID = BEG_FNC_RETORNA_PARAM_GERAL('Cobranca',\n                                                                      null,\n                                                                      'CONTATO_SUCESSO'),\n               W.DOCSTATUS              = 'CO',\n               W.OBSERVACAO             = 'Msg auto.- agendamento cancelado, pois teve algum contato com sucesso antecipado'\n         where W.BEG_COB_CONTATO_ID <> :new.BEG_COB_CONTATO_ID\n           and W.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n           and W.CREATED < sysdate\n           and W.DOCSTATUS = 'IP';\n        commit;\n      end if;\n    end if;\n  */\nend BEG_TRG_AIU_COB_CONTATO;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_COB_CONTATO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  VN_SUCESSO  BEG_COB_SIT_CONTATO.BEG_COB_SIT_CONTATO_ID%type; -- AOK - 02/12/2008\n  VN_COBR_EXT BEG_COB_SIT_CONTATO.BEG_COB_SIT_CONTATO_ID%type; -- AOK - 02/12/2008\n\n  -- Verifica se o cliente esta na tabela de controle do SPC - ativo\n  cursor C_SPC(PBEG_PESSOA_ID number) is\n    select *\n      from BEG_COB_TITULO_SPC TS\n     where TS.BEG_PESSOA_ID = PBEG_PESSOA_ID\n       and TS.DT_ENVIO_SPC is not null\n       and TS.DT_BAIXA_SPC is null;\n\n  RSPC C_SPC%rowtype;\n\n  -- Verifica se a situacao de contato envia e-mail\n  cursor C_PESS is\n    select P.TP_PESSOA,\n           P.FUNCIONARIO,\n           BEG_FNC_GER_TELEFONE(:new.BEG_PESSOA_ID, null, 'Y') TELEFONE\n      from BEG_PESSOA P\n     where P.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  R_PESS C_PESS%rowtype;\n\n  -- Le informações do cobrador\n  cursor C_COBRADOR is\n    select C.*\n      from BEG_COBRADOR C\n     where C.BEG_COBRADOR_ID = :new.BEG_COBRADOR_ID;\n\n  RCOBR C_COBRADOR%rowtype;\n\n  -- Totaliza os valores dos titulos do cliente - cobrador interno\n  cursor C_TOTTIT is\n    select sum(X.VLR_ABERTO) VL_TOT_ABERTO,\n           sum(BEG_FNC_CRC_VLR_DEVIDO(X.BEG_CRC_TITULO_ID)) VL_TOT_ABERTO_ATUAL\n      from DIE_VW_COB_TITULO X\n     where X.BEG_PESSOA_ID = :new.BEG_PESSOA_ID; -- 2022732\n  RTOTTIT C_TOTTIT%rowtype;\n\n  -- Totaliza os valores dos titulos do cliente - cobrador externo\n  cursor C_TOTTITE is\n    select sum(X.VLR_ABERTO) VL_TOT_ABERTO,\n           sum(BEG_FNC_CRC_VLR_DEVIDO(X.BEG_CRC_TITULO_ID)) VL_TOT_ABERTO_ATUAL\n      from DIE_VW_COB_TITULOE X\n     where X.BEG_PESSOA_ID = :new.BEG_PESSOA_ID; -- 2022732\n  RTOTTITE C_TOTTITE%rowtype;\n\n  -- Definicao de variais diversas\n  --VN_VL_ABERTO_ATUAL     BEG_COB_CONTATO_TITULO.VL_ABERTO_ATUAL%type;\n  --  VN_VL_TOT_ABERTO       BEG_COB_CONTATO.VL_TOT_ABERTO%type;\n  --  VN_VL_TOT_ABERTO_ATUAL BEG_COB_CONTATO.VL_TOT_ABERTO_ATUAL%type;\n  --  VDT_ENVIO_SPC          BEG_COB_CONTATO_TITULO.DT_ENVIO_SPC%type;\n\n  --  pragma autonomous_transaction;\n  VB_APEX boolean;\nbegin\n  --\n  --RAISE_APPLICATION_ERROR(-20008, 'To aqui!.');\n  --\n  if INSERTING\n     or UPDATING\n     and :new.DOCSTATUS <> 'CO' then\n    -- aok -- 02/12/2008\n    open C_COBRADOR;\n    fetch C_COBRADOR\n      into RCOBR;\n    close C_COBRADOR;\n    --  aok - 02/12/2008\n    VN_SUCESSO  := BEG_FNC_RETORNA_PARAM_GERAL('Cobranca',\n                                               null,\n                                               'CONTATO_SUCESSO');\n    VN_COBR_EXT := BEG_FNC_RETORNA_PARAM_GERAL('Cobranca',\n                                               null,\n                                               'CONTATO_COBR_EXT');\n    --                                                  \n    :new.DOCSTATUS := 'IP';\n    --\n    --RAISE_APPLICATION_ERROR(-20009, 'To aqui!.');\n    --\n    if :new.DT_PREVISAO_PGTO is not null\n       and :new.DT_PREVISAO_PGTO < TRUNC(sysdate) then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'A data para previsao não pode ser inferior a data atual.');\n    end if;\n    ---- MF 18/05/2018\n    if :new.DT_PREVISAO_PGTO is not null\n       and trunc(:new.DT_PREVISAO_PGTO)-TRUNC(sysdate) > 30 then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'A data para previsao não pode ser maior que 30 dias.');\n    end if;\n    \n    \n    -- AOK - 02/12/2008\n    if :new.DT_PREVISAO_PGTO is not null\n       and NVL(:new.IND_ATUAL_DT_AVISO_PGTO, 'N') = 'N' then\n      RAISE_APPLICATION_ERROR(-20003,\n                              'Foi informado data de previsão de pagamento - se não for efetivar, apague-a!       ');\n    end if;\n    -- aok - 02/12/2008\n    if :new.DT_PREVISAO_PGTO is not null\n       and NVL(:new.IND_ATUAL_DT_AVISO_PGTO, 'N') = 'Y' then\n      if not (NVL(:new.BEG_COB_SIT_CONTATO_ID, 0) = VN_SUCESSO or\n          NVL(:new.BEG_COB_SIT_CONTATO_ID, 0) = VN_COBR_EXT) then\n      \n        RAISE_APPLICATION_ERROR(-20004,\n                                'Situação de contato invalida com data de previsao de pagamento - verifique!    ');\n      end if;\n    end if;\n    -- aok - 02/12/2008\n    if RCOBR.IND_ATUACAO = 'E' then\n      if NVL(:new.BEG_COB_SIT_CONTATO_ID, 0) <> VN_COBR_EXT then\n        RAISE_APPLICATION_ERROR(-20005,\n                                'A Situacao não confere com a atuação do cobrador - Verifique!        ');\n      end if;\n    else\n      if NVL(:new.BEG_COB_SIT_CONTATO_ID, 0) = VN_COBR_EXT then\n        RAISE_APPLICATION_ERROR(-20006,\n                                'A Situacao não confere com a atuação do cobrador - Verifique!        ');\n      end if;\n    end if;\n    -- AOK - 02/12/2008\n    if :new.DT_PREVISAO_PGTO is null\n       and NVL(:new.IND_ATUAL_DT_AVISO_PGTO, 'N') = 'Y' then\n      RAISE_APPLICATION_ERROR(-20007,\n                              'Faltou informar a data para previsao de pagamento - verifique !         ');\n    end if;\n  \n    -- Consistencia da situacao do contato + alteracao de sit.contato\n    if NVL(:new.BEG_COB_SIT_CONTATO_ID, 0) <>\n       NVL(:old.BEG_COB_SIT_CONTATO_ID, 0) then\n      if NVL(:new.BEG_COB_SIT_CONTATO_ID, 0) = 0 then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'A Situacao do contato deve ser definida!.');\n      end if;\n      /*      if NVL(:new.OBSERVACAO, '^') = NVL(:old.OBSERVACAO, '^') then\n              RAISE_APPLICATION_ERROR(-20003,\n                                      'Faltou informar alguma observacao!.');\n            end if;\n      */\n    \n      :new.OBSERVACAO := BEG_PCK_UTIL.CONVERTE_ACENTOS(:new.OBSERVACAO);\n      :new.DOCSTATUS  := 'CO'; -- Completo\n    \n    end if;\n  end if;\n\n  if :new.APP_USER is not null\n     and INSERTING then\n    --:new.DOCSTATUS := 'CO';\n    VB_APEX := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n                                                        'BEG_COB_CONTATO',\n                                                        :new.AD_CLIENT_ID,\n                                                        :new.AD_ORG_ID,\n                                                        :new.CREATED,\n                                                        :new.CREATEDBY,\n                                                        :new.UPDATED,\n                                                        :new.UPDATEDBY,\n                                                        :new.BEG_COB_CONTATO_ID);\n    null;\n  end if;\n  -- AOK -- 04/11/2008\n  if :new.APP_USER is not null\n     and UPDATING then\n    VB_APEX := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TAB_UPD(:new.APP_USER,\n                                                          :new.UPDATED,\n                                                          :new.UPDATEDBY);\n    --:new.APP_USER := null;\n  end if;\n\n  if INSERTING then\n    --VN_VL_ABERTO_ATUAL     := 0;\n    --VN_VL_TOT_ABERTO       := 0;\n    --VN_VL_TOT_ABERTO_ATUAL := 0;\n  \n    -- AOK -- 04/03/2008\n    open C_PESS;\n    fetch C_PESS\n      into R_PESS;\n    close C_PESS;\n    --\n    :new.TP_PESSOA   := R_PESS.TP_PESSOA;\n    :new.FUNCIONARIO := R_PESS.FUNCIONARIO;\n    :new.TELEFONES   := R_PESS.TELEFONE;\n  \n    -- Le o controle spc -- AOK - 09/10/2007\n    :new.DT_ENVIO_SPC := null;\n    open C_SPC(:new.BEG_PESSOA_ID);\n    fetch C_SPC\n      into RSPC;\n    if C_SPC%found then\n      :new.DT_ENVIO_SPC := RSPC.DT_ENVIO_SPC;\n    end if;\n    close C_SPC;\n    --\n    if :new.APP_USER is null then\n      -- Busca o indicador de atuacao do cobrador\n      /*      open C_COBRADOR;\n            fetch C_COBRADOR\n              into RCOBR;\n            close C_COBRADOR;\n      */ --\n      if RCOBR.IND_ATUACAO = 'I' then\n        open C_TOTTIT;\n        fetch C_TOTTIT\n          into RTOTTIT;\n        close C_TOTTIT;\n        :new.VL_TOT_ABERTO       := RTOTTIT.VL_TOT_ABERTO;\n        :new.VL_TOT_ABERTO_ATUAL := RTOTTIT.VL_TOT_ABERTO_ATUAL;\n      \n      else\n        open C_TOTTITE;\n        fetch C_TOTTITE\n          into RTOTTITE;\n        close C_TOTTITE;\n        :new.VL_TOT_ABERTO       := RTOTTITE.VL_TOT_ABERTO;\n        :new.VL_TOT_ABERTO_ATUAL := RTOTTITE.VL_TOT_ABERTO_ATUAL;\n      end if;\n    end if;\n  end if;\n\n  -- Permite eliminar um contato quando este ainda estiver \"Em progresso\"\n  if DELETING then\n    if :old.DOCSTATUS = 'CO' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Contato nao pode ser mais eliminado');\n    \n    end if;\n  end if;\n  --\nend BEG_TRG_BIUD_COB_CONTATO;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_COB_CONTATO_IND { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor C_COBRADOR is\n    select IND_ATUACAO\n      from BEG_COBRADOR C\n     where C.BEG_COBRADOR_ID = :new.BEG_COBRADOR_ID;\n\n  VC_IND_ATUACAO BEG_COBRADOR.IND_ATUACAO%type;\n\nbegin\n  --\n  --  RAISE_APPLICATION_ERROR(-20008, 'To aqui!  beg_trg_biu_cob_contato_ind.');\n\n  if NVL(:new.IND_ATUAL_DT_AVISO_PGTO, 'N') = 'Y' then\n    --\n    open C_COBRADOR;\n    fetch C_COBRADOR\n      into VC_IND_ATUACAO;\n    close C_COBRADOR;\n    --\n    if :new.DT_PREVISAO_PGTO is not null then\n      --\n      if VC_IND_ATUACAO = 'I' then\n        update BEG_CRC_TITULO T\n           set T.DT_AVISO_PGTO = :new.DT_PREVISAO_PGTO\n         where T.IND_ABERTO = 'Y'\n           and T.DT_VCTO <= :new.DT_PREVISAO_PGTO\n           and exists\n         (select 1\n                  from BEG_TIPO_TITULO TT\n                 where TT.BEG_TIPO_TITULO_ID = T.BEG_TIPO_TITULO_ID\n                   and TT.IND_GERA_COBRANCA = 'Y')\n           and NVL(T.NUM_NF_DEVOL, 0) = 0\n              -- and T.BEG_CONVENIO_ID is null\n           and T.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n              --and T.DT_VCTO < sysdate\n           and not exists\n         (select 1\n                  from DIE_COB_RESTR_CONTRATO X\n                 where X.AD_CLIENT_ID = T.AD_CLIENT_ID\n                   and X.AD_ORG_ID = T.AD_ORG_ID\n                   and X.value = T.value\n                   and X.BEG_TIPO_TITULO_ID = T.BEG_TIPO_TITULO_ID\n                   and (X.DT_FINAL is null or X.DT_FINAL > TRUNC(sysdate)))\n           and not exists\n         (select 1\n                  from BEG_PESSOA_RESTRICAO PR,\n                       BEG_RESTRICAO        R\n                 where PR.BEG_PESSOA_ID = T.BEG_PESSOA_ID\n                   and R.BEG_RESTRICAO_ID = PR.BEG_RESTRICAO_ID\n                   and R.DIE_BLOQ_GERA_COBRANCA = 'Y'\n                   and TRUNC(sysdate) between\n                       NVL(PR.DT_INCLUSAO, TRUNC(sysdate)) and\n                       NVL(PR.DT_SAIDA, TRUNC(sysdate)));\n      elsif VC_IND_ATUACAO = 'E' then\n        update BEG_CRC_TITULO T\n           set T.DT_AVISO_PGTO = :new.DT_PREVISAO_PGTO\n         where T.IND_ABERTO = 'Y'\n           and exists\n         (select 1\n                  from BEG_TIPO_TITULO TT\n                 where TT.BEG_TIPO_TITULO_ID = T.BEG_TIPO_TITULO_ID\n                   and TT.IND_GERA_COBRANCA = 'Y')\n           and NVL(T.NUM_NF_DEVOL, 0) = 0\n              --and T.BEG_CONVENIO_ID is null\n           and T.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n           and T.DT_VCTO < sysdate\n           and T.DT_VCTO <= :new.DT_PREVISAO_PGTO\n        /*           and exists -- AOK - 28/10/2008\n                         (select 1\n                                  from BEG_TITULO_COBRADOR TC\n                                 where TC.BEG_PESSOA_ID = T.BEG_PESSOA_ID\n                                   and TC.IND_BAIXA_COBRANCA = 'N'\n                                   and TC.BEG_CRC_TITULO_ID = T.BEG_CRC_TITULO_ID\n                                   and TC.BEG_COBRADOR_ID = T.BEG_COBRADOR_ID)*/\n        ;\n      end if;\n    end if;\n  else\n    :new.IND_ATUAL_DT_AVISO_PGTO := 'N';\n    if :old.IND_ATUAL_DT_AVISO_PGTO = 'Y' then\n      if VC_IND_ATUACAO = 'I' then\n        update BEG_CRC_TITULO T\n           set T.DT_AVISO_PGTO = :old.DT_PREVISAO_PGTO\n         where T.IND_ABERTO = 'Y'\n           and exists\n         (select 1\n                  from BEG_TIPO_TITULO TT\n                 where TT.BEG_TIPO_TITULO_ID = T.BEG_TIPO_TITULO_ID\n                   and TT.IND_GERA_COBRANCA = 'Y')\n           and NVL(T.NUM_NF_DEVOL, 0) = 0\n              -- and T.BEG_CONVENIO_ID is null\n           and T.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n           and T.DT_VCTO < sysdate\n           and not exists\n         (select 1\n                  from DIE_COB_RESTR_CONTRATO X\n                 where X.AD_CLIENT_ID = T.AD_CLIENT_ID\n                   and X.AD_ORG_ID = T.AD_ORG_ID\n                   and X.value = T.value\n                   and X.BEG_TIPO_TITULO_ID = T.BEG_TIPO_TITULO_ID\n                   and (X.DT_FINAL is null or X.DT_FINAL > TRUNC(sysdate)))\n           and not exists\n         (select 1\n                  from BEG_PESSOA_RESTRICAO PR,\n                       BEG_RESTRICAO        R\n                 where PR.BEG_PESSOA_ID = T.BEG_PESSOA_ID\n                   and R.BEG_RESTRICAO_ID = PR.BEG_RESTRICAO_ID\n                   and R.DIE_BLOQ_GERA_COBRANCA = 'Y'\n                   and TRUNC(sysdate) between\n                       NVL(PR.DT_INCLUSAO, TRUNC(sysdate)) and\n                       NVL(PR.DT_SAIDA, TRUNC(sysdate)));\n      else\n        update BEG_CRC_TITULO T\n           set T.DT_AVISO_PGTO = :old.DT_PREVISAO_PGTO\n         where T.IND_ABERTO = 'Y'\n           and exists\n         (select 1\n                  from BEG_TIPO_TITULO TT\n                 where TT.BEG_TIPO_TITULO_ID = T.BEG_TIPO_TITULO_ID\n                   and TT.IND_GERA_COBRANCA = 'Y')\n           and NVL(T.NUM_NF_DEVOL, 0) = 0\n              --and T.BEG_CONVENIO_ID is null\n           and T.BEG_PESSOA_ID = :new.BEG_PESSOA_ID\n           and T.DT_VCTO < sysdate;\n        /*           and exists -- AOK -- 28/10/2008\n        (select 1\n                 from BEG_TITULO_COBRADOR TC\n                where TC.BEG_PESSOA_ID = T.BEG_PESSOA_ID\n                  and TC.IND_BAIXA_COBRANCA = 'N'\n                  and TC.BEG_CRC_TITULO_ID = T.BEG_CRC_TITULO_ID\n                  and TC.BEG_COBRADOR_ID = T.BEG_COBRADOR_ID);*/\n      end if;\n    end if;\n  end if;\n  --\nend BEG_TRG_BIU_COB_CONTATO_IND;\n"}`;
    
    }
}
