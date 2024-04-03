
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_CARTORIO
    {
            [Required]
        /// <summary>
        /// Tipo documento - (C)heque, (N)ota promissoria, (T)etra de cambio (título)
        /// </summary>
        public string TP_DOCUMENTO { get; set; }
        
        /// <summary>
        /// Id do banco
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// Id da agencia
        /// </summary>
        public int BEG_AGENCIA_ID { get; set; }
        
        /// <summary>
        /// Indicativo se o titulo esta aberto
        /// </summary>
        public string IND_ABERTO { get; set; }
        
        /// <summary>
        /// Status do documento. - AI- Iniciado BA- Aguardando CP-Protestar DN-Ñ Protestar EC-Cartorio FB-Baixar GE-Excluido HR-Cancelar
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// id do motivo da baixa
        /// </summary>
        public int BEG_MOTIVO_BAIXA_ID { get; set; }
        
        /// <summary>
        /// Indica protestar
        /// </summary>
        public string IND_PROTESTAR { get; set; }
        
        /// <summary>
        /// Valor corrigido a data de implantação do documento
        /// </summary>
        public int VLR_CORRIGIDO { get; set; }
        
        /// <summary>
        /// Alínea do cheque
        /// </summary>
        public int BEG_CHQ_ALIQUOTA_ID { get; set; }
        
        /// <summary>
        /// Valor do contrato
        /// </summary>
        public int VLR_CONTRATO { get; set; }
        
        /// <summary>
        /// Valor em aberto do contrato
        /// </summary>
        public int VLR_CONTRATO_ABERTO { get; set; }
        
        /// <summary>
        /// Id do tipo dotitulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario Apex
        /// </summary>
        public string APP_USER { get; set; }
        
        /// <summary>
        /// Data de envio para liberacao
        /// </summary>
        public string DT_ENVIO_LIBERACAO { get; set; }
        
        /// <summary>
        /// Data de envio para o Jurídico
        /// </summary>
        public string DT_ENVIO_JURIDICO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Notao para impressao
        /// </summary>
        public string BT_IMPRIME { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Numero do instrumento de protesto
        /// </summary>
        public string NRO_INSTRUMENTO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Numero do livro de protesto
        /// </summary>
        public string NRO_LIVRO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// numero da folha do protesto
        /// </summary>
        public string NRO_FOLHA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// numero do microfilme
        /// </summary>
        public string NRO_MICROFILME { get; set; }
        
        /// <summary>
        /// Data de aprovacao ou nao do protesto
        /// </summary>
        public string DT_APROV_PROTESTO { get; set; }
        
        /// <summary>
        /// Indica que mercadoria foi devolvido
        /// </summary>
        public string IND_DEVOLVIDO { get; set; }
            [Required]
        /// <summary>
        /// Data de Venciento
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// Data de emissao
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// Número do documento a ser protestado
        /// </summary>
        public string TITULO_PARCELA { get; set; }
            [Required]
        /// <summary>
        /// Codigo do cliente
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do registro referente ao cartorio
        /// </summary>
        public int BEG_COB_CARTORIO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo Sim ou Não
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data de criação do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que fez a criação do registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao do registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que fez a ultima alteracao no registro
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// Numero do documento (cheque,contrato+parcela, etc)
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// Data do protocolo
        /// </summary>
        public string DT_PROTOCOLO { get; set; }
        
        /// <summary>
        /// Data da intimacao
        /// </summary>
        public string DT_INTIMACAO { get; set; }
        
        /// <summary>
        /// Baixa no cartorio
        /// </summary>
        public string DT_SAI_CARTORIO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Número do protocolo
        /// </summary>
        public string NRO_PROTOCOLO { get; set; }
        
        /// <summary>
        /// Valor do emolumento
        /// </summary>
        public int VLR_EMOLUMENTO { get; set; }
            [StringLength(600)]
        /// <summary>
        /// Observacao
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// Valor título
        /// </summary>
        public int VLR_TITULO { get; set; }
        
        /// <summary>
        /// Valor declarado
        /// </summary>
        public int VLR_DECLARADO { get; set; }
        
        /// <summary>
        /// Id do titulo (contrato+parcela)
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AIU_OF_COB_CARTORIO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  VC_OK                  varchar2(3) := null;\n  VN_IND_OPERACAO        number(1);\n  VN_BEG_MOTIVO_BAIXA_ID BEG_MOTIVO_BAIXA.BEG_MOTIVO_BAIXA_ID%type := null;\n\nbegin\n\n   if not INSERTING then -- AOK -- 11/08/2008\n    if NVL(:new.NRO_PROTOCOLO, '^') <> '^'\n       or :new.DT_PROTOCOLO is not null then\n      if NVL(:new.NRO_PROTOCOLO, '^') = '^' then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Faltou informar o numero do protocolo');\n      end if;\n      if :new.DT_PROTOCOLO is null then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Faltou informar a data do protocolo');\n      end if;\n    end if;\n  \n    if :new.DT_PROTOCOLO <> :old.DT_PROTOCOLO\n       and :new.NRO_PROTOCOLO <> :old.NRO_PROTOCOLO\n       and :new.DT_SAI_CARTORIO is not null then\n      RAISE_APPLICATION_ERROR(-20003,\n                              'Não pode ser informado a data de saída neste momento');\n    end if;\n  end if;\n\n  VN_IND_OPERACAO := 1;\n\n  -- AOK - 11/08/2008 - Alterado teste da dt_sai_cartorio  \n  if :new.DT_SAI_CARTORIO is not null\n     and NVL(:new.NRO_PROTOCOLO, '^') <> '^'\n     and :new.DT_PROTOCOLO is not null then\n    --  if :new.DT_SAI_CARTORIO <> NVL(:old.DT_SAI_CARTORIO, TRUNC(sysdate - 9)) then\n    if :new.BEG_MOTIVO_BAIXA_ID is null then\n      RAISE_APPLICATION_ERROR(-20002, 'Faltou informar o motivo da baixa!');\n    end if;\n    VN_BEG_MOTIVO_BAIXA_ID := :new.BEG_MOTIVO_BAIXA_ID;\n    VN_IND_OPERACAO        := 3;\n  end if;\n\n  -- AOK - 11/08/2008 - Documento liquidado\n  if :new.IND_ABERTO = 'N' then\n    VN_IND_OPERACAO        := 3;\n    VN_BEG_MOTIVO_BAIXA_ID := BEG_FNC_RETORNA_PARAM_GERAL('Cobranca',\n                                                          null,\n                                                          'BAIXA_PADRAO');\n  end if;\n\n  --RAISE_APPLICATION_ERROR(-20003, 'Passou - ' || VN_IND_OPERACAO);\n\n  if NVL(:new.NRO_PROTOCOLO, '^') <> '^'\n     and :new.DT_PROTOCOLO is not null then\n  \n    VC_OK := DIE_FNC_CRIA_RESTRICAO('C', -- ptipo\n                                    VN_IND_OPERACAO, -- pind_operacao\n                                    :new.AD_CLIENT_ID, --\n                                    :new.AD_ORG_ID, -- \n                                    :new.BEG_VW_CLIENTE_ID, --\n                                    :new.BEG_CRC_TITULO_ID, --\n                                    :new.BEG_COB_CARTORIO_ID, -- porigem_id\n                                    :new.TP_DOCUMENTO, --PTIPODOC,\n                                    :new.TITULO_PARCELA, -- pnrodoc\n                                    :new.BEG_AGENCIA_ID, --\n                                    VN_BEG_MOTIVO_BAIXA_ID, --:new.BEG_MOTIVO_BAIXA_ID,\n                                    :new.DT_PROTOCOLO,\n                                    :new.DT_SAI_CARTORIO);\n    if VC_OK <> 'OK' then\n      RAISE_APPLICATION_ERROR(-20010,\n                              'Ocorreu algum erro na criacao da restricao!');\n    end if;\n  end if;\nend DIE_TRG_AIU_OF_COB_CARTORIO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AU_OF_COB_CARTORIO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  VC_OK           varchar2(3) := null;\n  VN_IND_OPERACAO number(1);\n\n  pragma autonomous_transaction;\n\nbegin\n\n-- AOK - 29/01/2009 - transferido consistencia para DIE_TRG_BIUD_CARTORIO\n/*  if NVL(:new.NRO_PROTOCOLO, '^') <> '^'\n     or :new.DT_PROTOCOLO is not null then\n    if NVL(:new.NRO_PROTOCOLO, '^') = '^' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Faltou informar o numero do protocolo');\n    end if;\n    if :new.DT_PROTOCOLO is null then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Faltou informar a data do protocolo');\n    end if;\n  end if;\n\n  if :new.DT_PROTOCOLO <> :old.DT_PROTOCOLO\n     and :new.NRO_PROTOCOLO <> :old.NRO_PROTOCOLO\n     and :new.DT_SAI_CARTORIO is not null then\n    RAISE_APPLICATION_ERROR(-20003,\n                            'Não pode ser informado a data de saída neste momento');\n  end if;\n*/  \n\n  VN_IND_OPERACAO := 1; -- Inclusao da restricao\n  if :new.DT_SAI_CARTORIO <> NVL(:old.DT_SAI_CARTORIO, TRUNC(sysdate - 9)) then\n    if :new.BEG_MOTIVO_BAIXA_ID is null then\n      RAISE_APPLICATION_ERROR(-20002, 'Faltou informar o motivo da baixa!');\n    end if;\n    VN_IND_OPERACAO := 3; -- Excluir/baixar a restricao\n  end if;\n\n  --RAISE_APPLICATION_ERROR(-20003, 'Passou - ' || VN_IND_OPERACAO);\n\n  if NVL(:new.NRO_PROTOCOLO, '^') <> '^'\n     and :new.DT_PROTOCOLO is not null then\n  \n    VC_OK := DIE_FNC_CRIA_RESTRICAO('C', -- ptipo\n                                    VN_IND_OPERACAO, -- pind_operacao\n                                    :new.AD_CLIENT_ID,\n                                    :new.AD_ORG_ID,\n                                    :new.BEG_VW_CLIENTE_ID,\n                                    :new.BEG_CRC_TITULO_ID,\n                                    :new.BEG_COB_CARTORIO_ID, -- porigem_id\n                                    :new.TP_DOCUMENTO, --PTIPODOC,\n                                    :new.TITULO_PARCELA, -- pnrodoc\n                                    :new.BEG_AGENCIA_ID,\n                                    :new.BEG_MOTIVO_BAIXA_ID,\n                                    :new.DT_PROTOCOLO,\n                                    :new.DT_SAI_CARTORIO);\n    if VC_OK = 'OK' then\n      commit;\n    end if;\n  \n    if VC_OK <> 'OK' then\n      RAISE_APPLICATION_ERROR(-20010,\n                              'Ocorreu algum erro na criacao da restricao!');\n    end if;\n  end if;\nend DIE_TRG_AU_OF_COB_CARTORIO;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_CARTORIO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  --\n  VC_MNT_VIA_PORTAL char(1) := 'N'; -- AOK - 23/07/2009\n  --\n  -- Busca os dados dos titulos\n  --\n  cursor CTITULO is\n    select T.AD_CLIENT_ID,\n           T.AD_ORG_ID,\n           T.value,\n           T.PARCELA,\n           T.BEG_TIPO_TITULO_ID,\n           T.BEG_PESSOA_ID,\n           T.DT_EMISSAO,\n           T.IND_ABERTO,\n           T.value || '-' || LPAD(NVL(T.PARCELA, 0), 2, 0) TITULO_PARCELA\n      from BEG_CRC_TITULO T\n     where T.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID;\n  RTITULO CTITULO%rowtype;\n\n  --\n  -- Busca dados do titulo que a callout não esta trazendo -- AOK - 08/05/2009\n  --\n  cursor CTIT_RENEG(PAD_ORG_ID number, PBEG_TIPO_TITULO_ID number, PVALUE varchar2, PPARCELA number) is\n    select *\n      from BEG_CRC_TITULO T\n     where T.AD_ORG_ID = PAD_ORG_ID --1000059 -- 1000002\n       and T.BEG_TIPO_TITULO_ID = PBEG_TIPO_TITULO_ID --2500012 --2500004\n       and T.value = PVALUE --'7047' --'73236'\n       and T.PARCELA = PPARCELA --8 --00;\n    ;\n  RTIT_RENEG CTIT_RENEG%rowtype;\n  --\n  -- Totaliza o valor do contrato e o valor em aberto\n  --\n  cursor CTOTTITULO is\n    select sum(W.VLR_TITULO) VLR_CONTRATO,\n           sum(W.VLR_ABERTO) VLR_CONTRATO_ABERTO\n      from BEG_CRC_TITULO W\n     where W.AD_CLIENT_ID = RTITULO.AD_CLIENT_ID\n       and W.AD_ORG_ID = RTITULO.AD_ORG_ID\n       and W.value = RTITULO.value\n       and W.BEG_TIPO_TITULO_ID = RTITULO.BEG_TIPO_TITULO_ID\n       and W.BEG_PESSOA_ID = RTITULO.BEG_PESSOA_ID;\n  RTOTTIT CTOTTITULO%rowtype;\n  --\n  VB_APEX boolean;\n  --\nbegin\n\n  if not DELETING then\n    -- AOK - 08/05/2009\n    -- AOK - 29/01/2009 - Transferido consistencia que estava na DIE_TRG_AU_OF_COB_CARTORIO\n    if NVL(:new.NRO_PROTOCOLO, '^') <> '^'\n       or :new.DT_PROTOCOLO is not null then\n      if NVL(:new.NRO_PROTOCOLO, '^') = '^' then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Faltou informar o numero do protocolo');\n      end if;\n      if :new.DT_PROTOCOLO is null then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Faltou informar a data do protocolo');\n      end if;\n    end if;\n  \n    if :new.DT_PROTOCOLO <> :old.DT_PROTOCOLO\n       and :new.NRO_PROTOCOLO <> :old.NRO_PROTOCOLO\n       and :new.DT_SAI_CARTORIO is not null then\n      RAISE_APPLICATION_ERROR(-20003,\n                              'Não pode ser informado a data de saída neste momento');\n    end if;\n  \n    if NVL(:new.BEG_MOTIVO_BAIXA_ID, 0) > 0\n       and :new.DT_SAI_CARTORIO is null then\n      RAISE_APPLICATION_ERROR(-20004, 'Faltou informar data de baixa!');\n    end if;\n  \n    if :new.APP_USER is not null\n       and INSERTING then\n      --  :new.DOCSTATUS := 'CO';\n      VB_APEX           := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n                                                                    'BEG_COB_CARTORIO',\n                                                                    :new.AD_CLIENT_ID,\n                                                                    :new.AD_ORG_ID,\n                                                                    :new.CREATED,\n                                                                    :new.CREATEDBY,\n                                                                    :new.UPDATED,\n                                                                    :new.UPDATEDBY,\n                                                                    :new.BEG_COB_CARTORIO_ID);\n      :new.APP_USER     := null;\n      VC_MNT_VIA_PORTAL := 'Y';\n    end if;\n    -- AOK -- 04/11/2008\n    if :new.APP_USER is not null\n       and UPDATING then\n      VB_APEX       := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TAB_UPD(:new.APP_USER,\n                                                                  :new.UPDATED,\n                                                                  :new.UPDATEDBY);\n      :new.APP_USER := null;\n    end if;\n  \n    if INSERTING then\n      -- Verifica filial\n      if NVL(:new.AD_ORG_ID, 0) = 0 then\n        RAISE_APPLICATION_ERROR(-20005, 'Deve ser selecionada uma filial!');\n      end if;\n    \n      :new.DOCSTATUS := 'AI';\n    \n      -- AOK - 08/05/2009 -- \n      -- Quando o tipo titulo for renegociacao (callout não trata)\n      -- Para diferenciar da chamada da callout - ele aceitará como 999999/99\n      --if :new.TP_DOCUMENTO = 'T'  -- AOK - 23/07/09\n      if VC_MNT_VIA_PORTAL = 'N' -- AOK - 23/07/09\n         and :new.TP_DOCUMENTO = 'T' -- AOK -- 23/07/09\n         and :new.BEG_TIPO_TITULO_ID =\n         BEG_FNC_RETORNA_PARAM_GERAL('Vendas', null, 'RENEGOCIACAO') then\n        open CTIT_RENEG(:new.AD_ORG_ID,\n                        :new.BEG_TIPO_TITULO_ID,\n                        BEG_$P(:new.TITULO_PARCELA, '/'),\n                        BEG_$P(:new.TITULO_PARCELA, '/', 2));\n        fetch CTIT_RENEG\n          into RTIT_RENEG;\n        if CTIT_RENEG%found then\n          if RTIT_RENEG.IND_ABERTO = 'Y' then\n            :new.BEG_CRC_TITULO_ID := RTIT_RENEG.BEG_CRC_TITULO_ID;\n            :new.BEG_VW_CLIENTE_ID := RTIT_RENEG.BEG_PESSOA_ID;\n            :new.DT_EMISSAO        := RTIT_RENEG.DT_EMISSAO;\n            :new.DT_VCTO           := RTIT_RENEG.DT_VCTO;\n            :new.VLR_TITULO        := RTIT_RENEG.VLR_ABERTO;\n          else\n            RAISE_APPLICATION_ERROR(-20001,\n                                    'Título de renegociação ja quitado');\n          end if;\n        else\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Não encontrou este título de renegociação');\n        end if;\n        close CTIT_RENEG;\n      end if;\n      --\n    \n      if NVL(:new.BEG_CRC_TITULO_ID, 0) > 0 then\n        -- Quando existir a informacao do titulo, buscar a data de emissao e ind_ativo\n        open CTITULO;\n        fetch CTITULO\n          into RTITULO;\n        if CTITULO%notfound then\n          RAISE_APPLICATION_ERROR(-20006,\n                                  'Titulo não encontrado, verifique se informou a Filial e Número do Documento no formato 999999-99');\n        end if;\n        if INSERTING then\n          :new.DT_EMISSAO     := RTITULO.DT_EMISSAO;\n          :new.IND_ABERTO     := RTITULO.IND_ABERTO;\n          :new.TITULO_PARCELA := RTITULO.TITULO_PARCELA;\n          :new.VLR_CORRIGIDO  := BEG_FNC_CRC_VLR_DEVIDO_DIA(:new.BEG_CRC_TITULO_ID,\n                                                            TRUNC(sysdate));\n        end if;\n        close CTITULO;\n      \n        open CTOTTITULO;\n        fetch CTOTTITULO\n          into RTOTTIT;\n        close CTOTTITULO;\n        :new.VLR_CONTRATO        := RTOTTIT.VLR_CONTRATO;\n        :new.VLR_CONTRATO_ABERTO := RTOTTIT.VLR_CONTRATO_ABERTO;\n      end if;\n    \n      -- Prevendo o cadastramento dos cartorios antigos - 02/09/2008 - AOK\n      if :new.NRO_PROTOCOLO is not null\n         and :new.DT_PROTOCOLO is not null then\n        if :new.DT_ENVIO_LIBERACAO is null then\n          :new.DT_ENVIO_LIBERACAO := :new.DT_VCTO;\n        end if;\n        :new.IND_PROTESTAR := 'Y';\n      end if;\n    \n    end if;\n    --  end if;\n    --  if INSERTING\n    --     or UPDATING then\n    if NVL(:new.DT_EMISSAO, TRUNC(sysdate + 1)) >\n       NVL(:new.DT_VCTO, TRUNC(sysdate + 1)) then\n      RAISE_APPLICATION_ERROR(-20007,\n                              'A Data de Emissão não pode ser maior que a Data de Vencimento!');\n    end if;\n  \n    if :new.DT_VCTO >= TRUNC(sysdate) then\n      RAISE_APPLICATION_ERROR(-20008,\n                              'A Data de Vencimento deve ser menor que a data de hoje!');\n    end if;\n    -- AOK - 11/08/2008 - No cadastramento for liberado para aprovacao\n    if :new.DT_ENVIO_LIBERACAO is not null\n       and :new.DOCSTATUS = 'AI' -- IP -- Em pogresso - Iniciado\n     then\n      :new.DOCSTATUS := 'BA'; --'WC' -- Aguardando confirmação\n    end if;\n    -- AOK -- 11/09/2008 - Quando titulo for quitado antes de ser liberado\n    if :new.IND_ABERTO = 'N'\n       and :new.IND_PROTESTAR is null\n       and :new.DT_PROTOCOLO is null then\n      :new.IND_PROTESTAR := 'N';\n      :new.OBSERVACAO    := 'MSG Automatica - Titulo foi quitado';\n      :new.DOCSTATUS     := 'DN'; --'NP'; Não Protestar\n    end if;\n  \n    if :new.DT_PROTOCOLO < :new.DT_VCTO\n       or :new.DT_SAI_CARTORIO < :new.DT_VCTO then\n      RAISE_APPLICATION_ERROR(-20009,\n                              'A Data de Protocolo e/ou Saída do cartório deve(m) ser maior(es) que a Data de Vencimento!');\n    end if;\n    -- AOK - 11/09/2008\n    if :new.IND_PROTESTAR in ('Y', 'N')\n       and NVL(:new.IND_DEVOLVIDO, 'N') = 'N' -- AOK - 28/01/2009\n     then\n      if :new.DT_APROV_PROTESTO is null then\n        :new.DT_APROV_PROTESTO := sysdate;\n      end if;\n      if :new.IND_PROTESTAR = 'N' then\n        --  if NVL(:new.OBSERVACAO, '^') = :old.observacao then -- AOK - 29/05/2008\n        if NVL(:new.OBSERVACAO, '^') = '^' then\n          RAISE_APPLICATION_ERROR(-20010,\n                                  'Faltou informar alguma observacao/motivo!.');\n        end if;\n        :new.DOCSTATUS := 'DN'; -- 'NA'; -- Não Aprovado \n      else\n        :new.DOCSTATUS := 'CP'; -- Aprovado o Protesto/Cartorio\n      end if;\n    end if;\n    --\n    if :new.DT_PROTOCOLO is not null then\n      if :new.DT_SAI_CARTORIO < :new.DT_PROTOCOLO then\n        RAISE_APPLICATION_ERROR(-20011,\n                                'A Data de saída do cartório deve ser maior que a data de protocolo!');\n      end if;\n    end if;\n    if :new.NRO_PROTOCOLO is not null then\n      --  if :new.IND_ABERTO = 'N' then  -- AOK - 29/01/2009\n      if (:new.IND_ABERTO = 'N' or NVL(:new.IND_DEVOLVIDO, 'N') = 'Y') -- AOK - 29/01/2009\n       then\n        :new.DOCSTATUS := 'FB'; -- Baixar\n      else\n        :new.DOCSTATUS := 'EC'; --AP'; -- Aprovado / Cartorio -- AOK - 11/08/2008\n        if :new.IND_PROTESTAR is null then\n          :new.IND_PROTESTAR := 'Y';\n        end if;\n      end if;\n    end if;\n    --\n    if UPDATING then\n      if :new.DT_SAI_CARTORIO is not null then\n        if :new.NRO_PROTOCOLO is not null then\n          :new.DOCSTATUS := 'GO'; -- 'CO'; Completo / Cancelado\n        else\n          :new.DOCSTATUS := 'HE'; -- 'CO'; Completo / Excluido\n        end if;\n      end if;\n    end if;\n  else\n    if not :new.DOCSTATUS = 'AI' then\n      -- AOK - 08/05/2009\n      if NVL(trim(:old.NRO_PROTOCOLO), '^') <> '^' then\n        RAISE_APPLICATION_ERROR(-20012,\n                                'Este registro não pode ser excluído pois já foi protestado!');\n      end if;\n    end if;\n  end if;\n  --\nend DIE_TRG_BIUD_CARTORIO;\n"}`;
    
    }
}
