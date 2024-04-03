
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_TITULO_SPC
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do titulo no SPC
        /// </summary>
        public int BEG_COB_TITULO_SPC_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Filial (Igual a do titulo)
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo - Sim ou Não
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// Indica se o registro foi inserido a partir de carga de dados (Y/N)
        /// </summary>
        public string IND_CARGA { get; set; }
            [Required]
        /// <summary>
        /// Data da criação do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que fez a criação
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteração
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que fez a ultima alteração
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Id do titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// Data de envio para o SPC
        /// </summary>
        public string DT_ENVIO_SPC { get; set; }
        
        /// <summary>
        /// Data de baixa no SPC
        /// </summary>
        public string DT_BAIXA_SPC { get; set; }
        
        /// <summary>
        /// Indica que será enviado para o SPC
        /// </summary>
        public string IND_ENVIAR_SPC { get; set; }
        
        /// <summary>
        /// Id do Cliente
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Indica que o título esta em aberto
        /// </summary>
        public string IND_ABERTO { get; set; }
            [Required]
        /// <summary>
        /// Indica que a baixa do SPC, foi ou será manual
        /// </summary>
        public string IND_BAIXA_MANUAL { get; set; }
            [StringLength(200)]
        /// <summary>
        /// Observação
        /// </summary>
        public string OBS { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuário Apex
        /// </summary>
        public string APP_USER { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Documento registrado na carga
        /// </summary>
        public string DOC_CARGA { get; set; }
        
        /// <summary>
        /// Data da divida
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// Id do contrato referente ao avalista
        /// </summary>
        public int DIE_CRC_CONTRATO_AVALISTA_ID { get; set; }
        
        /// <summary>
        /// id do codigo de retorno do SPC
        /// </summary>
        public int BEG_COB_SPC_RETORNO_ID { get; set; }
        
        /// <summary>
        /// Indica que o titulo foi devolvido
        /// </summary>
        public string IND_DEVOLVIDO { get; set; }
        
        /// <summary>
        /// Indica titulo com prazo expirado para o SPC
        /// </summary>
        public string IND_PRAZO_EXPIRADO { get; set; }
        
        /// <summary>
        /// (C)omprador / (F)iador
        /// </summary>
        public string IND_REGISTRO { get; set; }
        
        /// <summary>
        /// Id do cliente
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// Valor da divida
        /// </summary>
        public int VLR_DIVIDA { get; set; }
            [Required]
        /// <summary>
        /// Indica que a ultima manutenco foi rejeitada
        /// </summary>
        public string IND_REJEITADO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AU_COB_TITULO_SPC { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n\n  VN_BEG_PESSOA_ID BEG_PESSOA.BEG_PESSOA_ID%type;\n  cursor CAVAL is\n    select CA.BEG_PESSOA_ID AVALISTA,\n           TCA.BEG_PESSOA_ID CLIENTE\n      from BEG_CRC_TITULO            T, -- Titulo da pesquisa\n           DIE_CRC_CONTRATO_AVALISTA CA, -- Avalista\n           BEG_CRC_TITULO            TCA -- Comprador\n     where T.BEG_CRC_TITULO_ID = BEG_PCK_COB_SPC.VN_BEG_CRC_TITULO_ID\n       and CA.BEG_CRC_TITULO_ID = TCA.BEG_CRC_TITULO_ID\n       and CA.ISACTIVE = 'Y'\n       and TCA.AD_ORG_ID = T.AD_ORG_ID\n       and TCA.BEG_PESSOA_ID = T.BEG_PESSOA_ID\n       and TCA.value = T.value\n       and TCA.SRDUP = T.SRDUP\n       and TCA.CLASSIF = T.CLASSIF\n       and TCA.BEG_TIPO_TITULO_ID = T.BEG_TIPO_TITULO_ID;\n  RAVAL CAVAL%rowtype;\n\n  -- pragma autonomous_transaction;\n\nbegin\n  --\n  if NVL(BEG_PCK_COB_SPC.VC_EXECUTA_TRIGGER, 'Y') = 'Y' -- aok -- 30/01/2009\n   then\n    if BEG_PCK_COB_SPC.VC_PROCESSA = 'Y' then\n      BEG_PCK_COB_SPC.VC_PROCESSA := 'N';\n      -- Verifica se existe avalista para o titulo\n      open CAVAL;\n      fetch CAVAL\n        into RAVAL;\n      if CAVAL%found then\n        if BEG_PCK_COB_SPC.VC_IND_REGISTRO = 'F' -- Avalista\n         then\n          VN_BEG_PESSOA_ID := RAVAL.CLIENTE;\n        else\n          VN_BEG_PESSOA_ID := RAVAL.AVALISTA;\n        end if;\n        update BEG_COB_TITULO_SPC X\n           set X.IND_BAIXA_MANUAL = BEG_PCK_COB_SPC.VC_IND_BAIXA_MANUAL,\n               X.OBS              = BEG_PCK_COB_SPC.VC_OBS\n         where X.BEG_CRC_TITULO_ID = BEG_PCK_COB_SPC.VN_BEG_CRC_TITULO_ID\n           and X.BEG_PESSOA_ID = VN_BEG_PESSOA_ID\n           and X.BEG_COB_TITULO_SPC_ID <>\n               BEG_PCK_COB_SPC.VN_BEG_COB_TITULO_SPC_ID\n           and X.ISACTIVE = 'Y'\n           and X.IND_ENVIAR_SPC = 'Y'\n           and X.DT_ENVIO_SPC is not null\n           and X.DT_BAIXA_SPC is null;\n      end if;\n      close CAVAL;\n      -- commit;\n    end if; --\n  end if;\nend DIE_TRG_AU_COB_TITULO_SPC;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BU_BEG_COB_TITULO_SPC { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n\n  --  pragma autonomous_transaction;\n\nbegin\n  -- Verifica se existe avalista para o titulo\n  --  if NVL(:new.IND_BAIXA_MANUAL, 'N') = 'Y' and  -- AOK - 29/01/2009\n  --     NVL(:old.IND_BAIXA_MANUAL, 'N') = 'N' or\n  if NVL(BEG_PCK_COB_SPC.VC_EXECUTA_TRIGGER, 'Y') = 'Y' -- AOK - 30/01/2009\n   then\n    -- Consistencia para saber se o titulo foi forcado baixa por devolucao\n    if (NVL(:new.IND_BAIXA_MANUAL, 'N') = 'N' and\n       NVL(:old.IND_BAIXA_MANUAL, 'N') = 'Y')\n       and nvl(:new.IND_DEVOLVIDO,'N') = 'Y' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Não pode ser desmarcado! Forcado baixa devido devolução de mercadoria.');\n    end if;\n    --\n    if ((NVL(:new.IND_BAIXA_MANUAL, 'N') = 'Y' and\n       NVL(:old.IND_BAIXA_MANUAL, 'N') = 'N') or\n       (NVL(:new.IND_BAIXA_MANUAL, 'N') = 'N' and\n       NVL(:old.IND_BAIXA_MANUAL, 'N') = 'Y'))\n       and NVL(BEG_PCK_COB_SPC.VC_PROCESSA, 'N') = 'N' then\n      BEG_PCK_COB_SPC.VC_PROCESSA              := 'Y';\n      BEG_PCK_COB_SPC.VC_IND_REGISTRO          := :new.IND_REGISTRO;\n      BEG_PCK_COB_SPC.VC_IND_BAIXA_MANUAL      := :new.IND_BAIXA_MANUAL; --'Y';\n      BEG_PCK_COB_SPC.VC_OBS                   := :new.OBS;\n      BEG_PCK_COB_SPC.VN_BEG_CRC_TITULO_ID     := :new.BEG_CRC_TITULO_ID;\n      BEG_PCK_COB_SPC.VN_BEG_COB_TITULO_SPC_ID := :new.BEG_COB_TITULO_SPC_ID;\n    end if;\n  end if;\n\nend DIE_TRG_BU_BEG_COB_TITULO_SPC;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_COB_TITULO_SPC { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  cursor CTITULO is\n    select T.VLR_ABERTO\n      from BEG_CRC_TITULO T\n     where T.BEG_CRC_TITULO_ID = :new.BEG_CRC_TITULO_ID;\n  VB_APEX boolean;\n\n  VC_OK varchar2(3) := null;\n\nbegin\n\n  if INSERTING then\n    open CTITULO;\n    fetch CTITULO\n      into :new.VLR_DIVIDA;\n    close CTITULO;\n  else\n    --if :new.ind_aberto = 'Y' then\n    if :new.DT_ENVIO_SPC is not null then\n      if :new.DT_ENVIO_SPC <> :old.DT_ENVIO_SPC then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Data de envio para o SPC não pode ser alterado! ');\n      end if;\n    end if;\n    if :new.DT_BAIXA_SPC is not null then\n      if :new.DT_BAIXA_SPC <> :old.DT_BAIXA_SPC then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Data de baixa para o SPC não pode ser alterado! ');\n      end if;\n    end if;\n  \n    if :new.IND_ENVIAR_SPC <> :old.IND_ENVIAR_SPC then\n      if :new.IND_ABERTO = 'Y' then\n        if NVL(:new.OBS, '^') = NVL(:old.OBS, '^') then\n          RAISE_APPLICATION_ERROR(-20001,\n                                  'Faltou informar uma justificativo do não enviar  ');\n        end if;\n      else\n        :new.OBS := 'MSG. AUTOMATICA - Desmarcado enviar, pois documento foi quitado';\n      end if;\n    end if;\n  \n    -- AOK - 17/04/2009\n    if UPDATING('beg_pessoa_id') then\n      if :new.BEG_PESSOA_ID <> :old.BEG_PESSOA_ID then\n        RAISE_APPLICATION_ERROR(-20002,\n                                'Não é permitido alterar o cliente!! ');\n      end if;\n    end if;\n    --\n    -- AOK - 11/08/2008 - Baixar a restricao do Cliente referente SPC\n    if :new.DT_ENVIO_SPC is not null\n       and :new.IND_ABERTO = 'N' then\n    \n      VC_OK := DIE_FNC_CRIA_RESTRICAO('S', -- SPC\n                                      3, -- 1.inclusao 3.exclusao\n                                      :new.AD_CLIENT_ID, --\n                                      :new.AD_ORG_ID, -- Filial\n                                      :new.BEG_PESSOA_ID, -- Cliente\n                                      :new.BEG_CRC_TITULO_ID, -- Id do titulo\n                                      :new.BEG_COB_TITULO_SPC_ID, --\n                                      'T', -- (T)itulo (C)heque (N)ota Promissoria\n                                      null, -- PNRODOC \n                                      null, -- PBEG_AGENCIA_ID \n                                      BEG_FNC_RETORNA_PARAM_GERAL('Cobranca',\n                                                                  null,\n                                                                  'BAIXA_PADRAO'));\n    end if;\n  \n  end if;\n  if :new.APP_USER is not null\n     and UPDATING then\n    -- AOK - 04/11/2008\n    VB_APEX := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TAB_UPD(:new.APP_USER,\n                                                          :new.UPDATED,\n                                                          :new.UPDATEDBY);\n    --VB_APEX       := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n    --                                                          :new.AD_CLIENT_ID,\n    --                                                          :new.AD_ORG_ID,\n    --                                                          :new.CREATED,\n    --                                                          :new.CREATEDBY,\n    --                                                          :new.UPDATED,\n    --                                                          :new.UPDATEDBY);\n    :new.APP_USER := null;\n  end if;\n\nend DIE_TRG_BIU_BEG_COB_TITULO_SPC;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BD_BEG_COB_TITULO_SPC { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  ---\nbegin\n\n  if :old.DT_ENVIO_SPC is not null\n    and :old.DT_BAIXA_SPC is null then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Cliente negativado, não pode ser eliminado');\n  end if;\n\n  if :old.DT_ENVIO_SPC is not null \n    and :old.DT_BAIXA_SPC is not null \n    --and :old.ind_aberto = 'N'\n    then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Historico do cliente no SPC, não pode ser eliminado');\n  end if;\n\nend DIE_TRG_BD_BEG_COB_TITULO_SPC;\n"}`;
    
    }
}
