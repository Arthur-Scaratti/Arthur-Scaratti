
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_LOTE_COBR
    {
            [StringLength(20)]
        /// <summary>
        /// Nome do Arquivo Texto
        /// </summary>
        public string NOME_ARQUIVO { get; set; }
        
        /// <summary>
        /// Id da cidade para busca de clientes
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// Numero de dias minimo para pesquisa de atrasos
        /// </summary>
        public int NRO_DIAS_MIN { get; set; }
        
        /// <summary>
        /// Numero de dias maximo para pesquisa de atrasos
        /// </summary>
        public int NRO_DIAS_MAX { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica qual processamento sera realizado
        /// </summary>
        public string BTN_PROCESSO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indica qual processo A.Adiciona cliente lote B.finaliza lote
        /// </summary>
        public string IND_PROCESSO { get; set; }
        
        /// <summary>
        /// Numero de dias inferior
        /// </summary>
        public int NRO_DIAS_INF { get; set; }
        
        /// <summary>
        /// numero de dias maximo
        /// </summary>
        public int NRO_DIAS_SUP { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuário Apex
        /// </summary>
        public string APP_USER { get; set; }
        
        /// <summary>
        /// Quantidade de clientes
        /// </summary>
        public int QTDE_CLIENTES { get; set; }
        
        /// <summary>
        /// QUando necessadio reativar o lote
        /// </summary>
        public string IND_REATIVAR { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do lote de cobranca
        /// </summary>
        public int BEG_COB_LOTE_COBR_ID { get; set; }
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
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
        /// Data do movimento
        /// </summary>
        public string DT_MOVIMENTO { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status do documento
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(15)]
        /// <summary>
        /// Usuario que gerou o lote
        /// </summary>
        public string USUARIO { get; set; }
        
        /// <summary>
        /// Id do Cobrador
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// Valor do lote
        /// </summary>
        public int VLR_LOTE { get; set; }
        
        /// <summary>
        /// Quantidade de titulos
        /// </summary>
        public int QTDE_TIT { get; set; }
            [Required]
        /// <summary>
        /// Indicatido para carregar os titulos marcados (s/n)
        /// </summary>
        public string IND_MARCADO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BUD_COB_LOTE_COBR { get; set; } = `{"triggering_event":"UPDATE OR DELETE","trigger_body":"declare\n  --\nbegin\n  if UPDATING then\n    if :old.DOCSTATUS = 'CO' then\n      if :new.IND_REATIVAR = 'N' then -- AOK - 05/12/2008\n        -- Processo de geracão do lote cobranca ja esta finalizado\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Processo de geracão do lote cobranca ja esta finalizado ... Não pode ser alterado!');\n      else\n        :new.IND_REATIVAR := 'N';   -- AOK -- 05/12/2008\n      end if;\n    end if;\n  end if;\n  --\n  if DELETING then\n    -- Naum permite a eliminacão do lote cobranca apos completado todas as etapas\n    if :old.DOCSTATUS = 'CO' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Este lote ja foi processado, não pode ser eliminado');\n    else\n      -- \n      -- Elimina todos os titulos referente ao lote\n      --\n      delete BEG_COB_LOTE_COBR_TIT LT\n       where LT.BEG_COB_LOTE_COBR_ID = :old.BEG_COB_LOTE_COBR_ID;\n      --\n    end if;\n  end if;\n  --\nend BEG_TRG_BD_COB_LOTE_COBR;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_COB_LOTE_COBR { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  --  pragma autonomous_transaction;\n  VB_APEX     boolean;\n  V_AD_ORG_ID number;\n\nbegin\n\n  -- aok - 23/09/2008 \n  if INSERTING\n     or UPDATING('BEG_CIDADE_ID')\n     or UPDATING('IND_MARCADO')\n     or UPDATING('NRO_DIAS_MIN')\n     or UPDATING('NRO_DIAS_MAX')\n     or UPDATING('IND_PROCESSO') then\n  \n    if :new.APP_USER is not null\n       and INSERTING then\n      VB_APEX := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n                                                          'BEG_COB_LOTE_COBR',\n                                                          :new.AD_CLIENT_ID,\n                                                          V_AD_ORG_ID,\n                                                          :new.CREATED,\n                                                          :new.CREATEDBY,\n                                                          :new.UPDATED,\n                                                          :new.UPDATEDBY,\n                                                          :new.BEG_COB_LOTE_COBR_ID);\n    end if;\n  \n    -- Inicializacao de variaveis\n    BEG_PCK_COB_COBRANCA.VCAMINHO              := null;\n    BEG_PCK_COB_COBRANCA.VCOD_VPGRMA           := null;\n    BEG_PCK_COB_COBRANCA.PBEG_COB_LOTE_COBR_ID := null;\n    BEG_PCK_COB_COBRANCA.VC_PROCESSO           := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.BEG_COBRADOR_ID := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.NRO_DIAS_MIN    := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.NRO_DIAS_MAX    := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.DT_MOVIMENTO    := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.BEG_CIDADE_ID   := null;\n    BEG_PCK_COB_COBRANCA.VN_AD_CLIENT_ID       := null;\n    BEG_PCK_COB_COBRANCA.VN_AD_ORG_ID          := null;\n    BEG_PCK_COB_COBRANCA.VIND_MARCADO          := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.AD_CLIENT_ID    := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.AD_ORG_ID       := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.IND_MARCADO     := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.VLR_LOTE        := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.QTDE_TIT        := null;\n    BEG_PCK_COB_COBRANCA.RLOTE.QTDE_CLIENTES   := null; -- AOK -- 28/11/2008\n    BEG_PCK_COB_COBRANCA.RLOTE.DOCSTATUS       := null;\n    --\n    BEG_PCK_COB_COBRANCA.PBEG_COB_LOTE_COBR_ID := :new.BEG_COB_LOTE_COBR_ID;\n    BEG_PCK_COB_COBRANCA.VC_PROCESSO           := :new.IND_PROCESSO;\n    BEG_PCK_COB_COBRANCA.RLOTE.BEG_COBRADOR_ID := :new.BEG_COBRADOR_ID;\n    BEG_PCK_COB_COBRANCA.VN_AD_ORG_ID          := :new.AD_ORG_ID; -- AOK -- 14/10/2008\n  \n    if :new.value is null then\n      :new.value := :new.BEG_COB_LOTE_COBR_ID;\n    end if;\n  \n    -- Leitura do cobrador para buscar parametros para leitura dos titulos - AOK - 28/11/2006\n    open BEG_PCK_COB_COBRANCA.CCOBRADOR(BEG_PCK_COB_COBRANCA.RLOTE.BEG_COBRADOR_ID);\n    fetch BEG_PCK_COB_COBRANCA.CCOBRADOR\n      into BEG_PCK_COB_COBRANCA.RCOBRADOR;\n    if BEG_PCK_COB_COBRANCA.CCOBRADOR%notfound then\n      RAISE_APPLICATION_ERROR(-20002,\n                              'Algum problema ocorreu ao acessar o cobrador .... Verifique!');\n    end if;\n    close BEG_PCK_COB_COBRANCA.CCOBRADOR;\n  \n    -- AOK -- 14/10/2008 - Testar cidade se cobrador externo\n    if BEG_PCK_COB_COBRANCA.RCOBRADOR.IND_ATUACAO = 'E'\n       and BEG_PCK_COB_COBRANCA.RCOBRADOR.BEG_COBRADOR_ID <> 2000146 -- Exceção CDL-Ararangua/SC - AOK - 22/10/2008\n       and NVL(:new.BEG_CIDADE_ID, 0) = 0 then\n      RAISE_APPLICATION_ERROR(-20006,\n                              'Favor informar uma cidade para geração do lote!');\n    end if;\n    -- AOK - 15/04/2009 - Apenas testar o min e max quando na geracao do lote\n    if BEG_PCK_COB_COBRANCA.VC_PROCESSO <> 'B' then\n      -- AOK - 14/10/2008 - Leitura da filial cobrador para buscar parametros de min e max \n      open BEG_PCK_COB_COBRANCA.CCOBRFIL(BEG_PCK_COB_COBRANCA.RLOTE.BEG_COBRADOR_ID,\n                                         BEG_PCK_COB_COBRANCA.VN_AD_ORG_ID);\n      fetch BEG_PCK_COB_COBRANCA.CCOBRFIL\n        into BEG_PCK_COB_COBRANCA.RCOBRFIL;\n      /*    if BEG_PCK_COB_COBRANCA.CCOBRFIL%notfound then\n        close BEG_PCK_COB_COBRANCA.CCOBRFIL;\n        RAISE_APPLICATION_ERROR(-20005,\n                                'Este cobrador não atende a esta filial! ... Verifique!');\n      end if;*/\n      if NVL(BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MIN, 0) = 0 then\n        BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MIN := null;\n      end if;\n      if NVL(BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MAX, 0) = 0 then\n        BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MAX := null;\n      end if;\n      close BEG_PCK_COB_COBRANCA.CCOBRFIL;\n    \n      -- Verifica se o cobrador externo possui calculo dos dias minimos a partir de uma data\n      -- AOK - 08/05/2008\n      if BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MIN is not null\n         and BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MAX is not null then\n        null;\n      else\n        if BEG_PCK_COB_COBRANCA.RCOBRADOR.DT_CALC_DIAS_MIN is not null then\n          select TRUNC(TRUNC(sysdate) -\n                       BEG_PCK_COB_COBRANCA.RCOBRADOR.DT_CALC_DIAS_MIN)\n            into BEG_PCK_COB_COBRANCA.RCOBRADOR.NRO_DIAS_MIN\n            from DUAL;\n        end if;\n        if BEG_PCK_COB_COBRANCA.RCOBRADOR.DT_CALC_DIAS_MAX is not null then\n          select TRUNC(TRUNC(sysdate) -\n                       BEG_PCK_COB_COBRANCA.RCOBRADOR.DT_CALC_DIAS_MAX)\n            into BEG_PCK_COB_COBRANCA.RCOBRADOR.NRO_DIAS_MAX\n            from DUAL;\n          --  raise_application_error(-20001,BEG_PCK_COB_COBRANCA.RCOBRADOR.nro_dias_max);\n        end if;\n        --\n      end if;\n      -- Tratamento dos dias min e max de atraso\n      if NVL(:new.NRO_DIAS_MIN, 0) = 0 then\n        :new.NRO_DIAS_MIN := NVL(BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MIN,\n                                 BEG_PCK_COB_COBRANCA.RCOBRADOR.NRO_DIAS_MIN);\n      end if;\n      if NVL(:new.NRO_DIAS_MAX, 0) = 0 then\n        :new.NRO_DIAS_MAX := NVL(BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MAX,\n                                 BEG_PCK_COB_COBRANCA.RCOBRADOR.NRO_DIAS_MAX);\n      end if;\n    \n      -- AOK - 14/10/2008 - Inserido nvl com parametros do cobrador_filial  \n      if :new.NRO_DIAS_MIN <\n         NVL(BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MIN,\n             BEG_PCK_COB_COBRANCA.RCOBRADOR.NRO_DIAS_MIN) then\n        :new.NRO_DIAS_MIN := NVL(BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MIN,\n                                 BEG_PCK_COB_COBRANCA.RCOBRADOR.NRO_DIAS_MIN);\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Nro.dias MINIMO atrasos nao pode ser inferior a ' ||\n                                NVL(BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MIN,\n                                    BEG_PCK_COB_COBRANCA.RCOBRADOR.NRO_DIAS_MIN));\n      end if;\n    \n      if :new.NRO_DIAS_MAX >\n         NVL(BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MAX,\n             BEG_PCK_COB_COBRANCA.RCOBRADOR.NRO_DIAS_MAX) then\n        :new.NRO_DIAS_MAX := NVL(BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MAX,\n                                 BEG_PCK_COB_COBRANCA.RCOBRADOR.NRO_DIAS_MAX);\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Nro.dias MAXIMO atrasos nao pode ser superior a ' ||\n                                NVL(BEG_PCK_COB_COBRANCA.RCOBRFIL.NRO_DIAS_MAX,\n                                    BEG_PCK_COB_COBRANCA.RCOBRADOR.NRO_DIAS_MAX));\n      end if;\n    end if;\n    if INSERTING then\n      if :new.AD_ORG_ID = 0\n         and BEG_PCK_COB_COBRANCA.RCOBRADOR.IND_ATUACAO = 'E' then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Deve ser obrigatoriamente informado uma Filial!');\n      end if;\n      :new.NRO_DIAS_INF := :new.NRO_DIAS_MIN;\n      :new.NRO_DIAS_SUP := :new.NRO_DIAS_MAX;\n      if :new.DT_MOVIMENTO is null then\n        :new.DT_MOVIMENTO := TRUNC(sysdate);\n      end if;\n      BEG_PCK_COB_COBRANCA.WCONT_ANT := 0;\n    else\n      if :new.NRO_DIAS_INF = 0\n         or :new.NRO_DIAS_INF > :new.NRO_DIAS_MIN then\n        :new.NRO_DIAS_INF := :new.NRO_DIAS_MIN;\n      end if;\n    \n      if :new.NRO_DIAS_SUP = 0\n         or :new.NRO_DIAS_SUP < :new.NRO_DIAS_MAX then\n        :new.NRO_DIAS_SUP := :new.NRO_DIAS_MAX;\n      end if;\n    end if;\n  \n    BEG_PCK_COB_COBRANCA.RLOTE.BEG_COB_LOTE_COBR_ID := :new.BEG_COB_LOTE_COBR_ID;\n    BEG_PCK_COB_COBRANCA.RLOTE.NRO_DIAS_MIN         := :new.NRO_DIAS_MIN;\n    BEG_PCK_COB_COBRANCA.RLOTE.NRO_DIAS_MAX         := :new.NRO_DIAS_MAX;\n    BEG_PCK_COB_COBRANCA.RLOTE.DT_MOVIMENTO         := :new.DT_MOVIMENTO;\n    BEG_PCK_COB_COBRANCA.RLOTE.BEG_CIDADE_ID        := :new.BEG_CIDADE_ID;\n    BEG_PCK_COB_COBRANCA.VN_AD_CLIENT_ID            := :new.AD_CLIENT_ID;\n    BEG_PCK_COB_COBRANCA.VN_AD_ORG_ID               := :new.AD_ORG_ID;\n    BEG_PCK_COB_COBRANCA.VIND_MARCADO               := :new.IND_MARCADO;\n    BEG_PCK_COB_COBRANCA.RLOTE.AD_CLIENT_ID         := :new.AD_CLIENT_ID;\n    BEG_PCK_COB_COBRANCA.RLOTE.AD_ORG_ID            := :new.AD_ORG_ID;\n    BEG_PCK_COB_COBRANCA.RLOTE.IND_MARCADO          := :new.IND_MARCADO;\n    BEG_PCK_COB_COBRANCA.RLOTE.VLR_LOTE             := NVL(:new.VLR_LOTE, 0);\n    BEG_PCK_COB_COBRANCA.RLOTE.QTDE_TIT             := NVL(:new.QTDE_TIT, 0);\n    BEG_PCK_COB_COBRANCA.RLOTE.QTDE_CLIENTES        := NVL(:new.QTDE_CLIENTES,\n                                                           0); -- AOK - 28/11/2008\n    BEG_PCK_COB_COBRANCA.RLOTE.DOCSTATUS            := :new.DOCSTATUS;\n  \n    -- AOK - 10/03/2008 - Le os parametros da cobranca\n    open BEG_PCK_COB_COBRANCA.CPARAM;\n    fetch BEG_PCK_COB_COBRANCA.CPARAM\n      into BEG_PCK_COB_COBRANCA.RPARAM;\n    if BEG_PCK_COB_COBRANCA.CPARAM%notfound then\n      RAISE_APPLICATION_ERROR(-20003,\n                              'Erro na leitura dos parametros gerais da cobranca!');\n    end if;\n    close BEG_PCK_COB_COBRANCA.CPARAM;\n  \n    ------------------------------------\n    -- Buscando parametros do sistema --\n    ------------------------------------\n    BEG_PCK_COB_COBRANCA.VCAMINHO    := BEG_FNC_RETORNA_PARAM_GERAL('Cobranca',\n                                                                    null,\n                                                                    'UTL_FILE_COBRANCA');\n    BEG_PCK_COB_COBRANCA.VCOD_VPGRMA := BEG_FNC_RETORNA_PARAM_GERAL('Cobranca',\n                                                                    null,\n                                                                    'COD_VENDA_PROGRAMADA');\n    if BEG_PCK_COB_COBRANCA.VCAMINHO = '-1' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Nao existe o parametro de saida do arquivo. Ver parametros do sistema');\n    end if;\n  \n    --\n    --  if RLOTE.DOCSTATUS = 'IP' then\n    if BEG_PCK_COB_COBRANCA.VC_PROCESSO = 'A' -- Preparacao do lote\n     then\n      ---------------------------------------------------------------\n      -- Procedure ATUALIZA_BEG_TITULO_COBRADOR\n      ---------------------------------------------------------------\n    \n      if INSERTING then\n        BEG_PCK_COB_COBRANCA.PRC_BEG_TITULO_COBRADOR(BEG_PCK_COB_COBRANCA.PBEG_COB_LOTE_COBR_ID);\n      \n        :new.DOCSTATUS     := NVL(case when BEG_PCK_COB_COBRANCA.WCONT > 0 then 'WC' end, 'IP');\n        :new.VLR_LOTE      := NVL(BEG_PCK_COB_COBRANCA.VVLR_LOTE, 0);\n        :new.QTDE_TIT      := BEG_PCK_COB_COBRANCA.WCONT;\n        :new.QTDE_CLIENTES := BEG_PCK_COB_COBRANCA.VN_QTDE_CLI; -- AOK - 28/11/2008\n      \n        if :new.IND_MARCADO = 'N' then\n          :new.VLR_LOTE      := 0;\n          :new.QTDE_TIT      := 0;\n          :new.QTDE_CLIENTES := 0; -- AOK -- 28/11/2008\n        end if;\n      \n        if NVL(BEG_PCK_COB_COBRANCA.WCONT, 0) =\n           BEG_PCK_COB_COBRANCA.WCONT_ANT then\n          if :new.APP_USER is not null\n             or :new.USUARIO <> 'Sistema' -- AOK - 19/01/2009\n           then\n            RAISE_APPLICATION_ERROR(-20001,\n                                    :new.APP_USER || '-' || :new.USUARIO || '- ' ||\n                                    'Nenhum novo devedor foi encontrato para o período definido!');\n          end if;\n          --          RAISE_APPLICATION_ERROR(-20001,\n          --                                  'Nenhum registro foi encontrado para este processo!');\n          BEG_PCK_COB_COBRANCA.WCONT := 0;\n        end if;\n      else\n        BEG_PCK_COB_COBRANCA.PRC_BEG_TITULO_COBRADOR(BEG_PCK_COB_COBRANCA.PBEG_COB_LOTE_COBR_ID);\n      \n        :new.DOCSTATUS := case when BEG_PCK_COB_COBRANCA.WCONT > 0 then 'WC' end;\n        :new.VLR_LOTE  := NVL(BEG_PCK_COB_COBRANCA.VVLR_LOTE, 0);\n        :new.QTDE_TIT  := BEG_PCK_COB_COBRANCA.WCONT;\n        -- AOK -- 28/11/2008 - Qtde de clientes no lote\n        select count(distinct LTIT.BEG_PESSOA_ID) QTDE_CLI\n          into :new.QTDE_CLIENTES\n          from BEG_COB_LOTE_COBR_TIT LTIT\n         where LTIT.BEG_COB_LOTE_COBR_ID =\n               BEG_PCK_COB_COBRANCA.PBEG_COB_LOTE_COBR_ID\n           and LTIT.ISACTIVE = 'Y';\n      \n        -- :new.qtde_clientes := beg_pck_cob_cobranca.VN_QTDE_CLI; -- AOK - 28/11/2008\n      \n      end if;\n    \n    elsif BEG_PCK_COB_COBRANCA.VC_PROCESSO = 'B' -- Confirmacao do lote\n     then\n    \n      --  RAISE_APPLICATION_ERROR(-20001,\n      --                          BEG_PCK_COB_COBRANCA.PBEG_COB_LOTE_COBR_ID || ' ' ||\n      --                          BEG_PCK_COB_COBRANCA.RLOTE.BEG_COBRADOR_ID || ' ' ||\n      --                          BEG_PCK_COB_COBRANCA.VC_PROCESSO);\n    \n      BEG_PCK_COB_COBRANCA.BEG_PRC_CONFIRMA_LOTE(BEG_PCK_COB_COBRANCA.PBEG_COB_LOTE_COBR_ID,\n                                                 BEG_PCK_COB_COBRANCA.RLOTE.BEG_COBRADOR_ID);\n    \n      :new.VLR_LOTE      := NVL(BEG_PCK_COB_COBRANCA.VVLR_TIT, 0);\n      :new.QTDE_TIT      := BEG_PCK_COB_COBRANCA.VQTDE;\n      :new.QTDE_CLIENTES := BEG_PCK_COB_COBRANCA.VN_QTDE_CLI; -- AOK -- 28/11/2008\n      :new.DOCSTATUS     := 'CO';\n      :new.DT_MOVIMENTO  := TRUNC(sysdate); -- JT 11/12/2008 usada na validacao DIE_REABRE_LOTE_COBRANCA\n      :new.NOME_ARQUIVO  := BEG_PCK_COB_COBRANCA.ARQ_SAI;\n      -- AOK -- 28/11/2008 - Qtde de clientes no lote\n      select count(distinct LTIT.BEG_PESSOA_ID) QTDE_CLI\n        into :new.QTDE_CLIENTES\n        from BEG_COB_LOTE_COBR_TIT LTIT\n       where LTIT.BEG_COB_LOTE_COBR_ID =\n             BEG_PCK_COB_COBRANCA.PBEG_COB_LOTE_COBR_ID\n         and LTIT.ISACTIVE = 'Y';\n    else\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Faltou escolher uma opcao de processamento!!');\n    end if;\n  \n    -- Processo de geracao de historicos dos contatos baixados a mais de 15 dias -- AOK - 05/01/2007\n    BEG_PCK_COB_COBRANCA.BEG_PRC_TITULO_COBRADOR_HIST(BEG_PCK_COB_COBRANCA.RLOTE.BEG_COBRADOR_ID);\n    --\n  end if;\nend DIE_TRG_BIU_COB_LOTE_COBR;\n"}`;
    
    }
}
