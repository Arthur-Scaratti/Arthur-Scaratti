
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_AVISO_PESSOA
    {
        
        /// <summary>
        /// Id do cliente Avalisado - quando registro for do avalista
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// Id do avalista do contrato
        /// </summary>
        public int DIE_CRC_CONTRATO_AVALISTA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do Aviso por pessoa
        /// </summary>
        public int BEG_COB_AVISO_PESSOA_ID { get; set; }
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
            [Required]
        /// <summary>
        /// Codigo do cliente
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Nome do cliente -  - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string NOME { get; set; }
            [StringLength(60)]
        /// <summary>
        /// Endereco - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Bairro - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// Cidade - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Estado (UF) - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string ESTADO { get; set; }
            [StringLength(9)]
        /// <summary>
        /// Codigo de enderecamento postal - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string CEP { get; set; }
            [StringLength(600)]
        /// <summary>
        /// Contratos
        /// </summary>
        public string CONTRATOS { get; set; }
            [Required]
        /// <summary>
        /// Id do aviso
        /// </summary>
        public int BEG_COB_AVISO_ID { get; set; }
        
        /// <summary>
        /// Id da filial - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Numero do aviso gerado para a pessoa 
        /// </summary>
        public int NRO_AVISO { get; set; }
        
        /// <summary>
        /// Dia inicial para validacao do aviso - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public int DIAS_INI { get; set; }
        
        /// <summary>
        /// Dia final   para validacao do aviso - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public int DIAS_FIN { get; set; }
            [Required]
        /// <summary>
        /// indica que o aviso foi impresso (y/n)
        /// </summary>
        public string IND_IMPRESSO { get; set; }
        
        /// <summary>
        /// Data de impressao do aviso
        /// </summary>
        public string DT_IMPRESSAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Complemento do endereco - desativado - ver beg_vw_cob_aviso_pessoa
        /// </summary>
        public string COMPLEMENTO { get; set; }
        
        /// <summary>
        /// Id da pessoa na filial
        /// </summary>
        public int BEG_VW_GER_PESSOA_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Indicativo para enviar o aviso ao cliente
        /// </summary>
        public string IND_ENVIAR { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Observacao refente a  alteracao do indicativo de não enviar o aviso ao cliente
        /// </summary>
        public string OBS { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BD_COB_AVISO_PESSOA { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  --\nbegin\n  -- Não pode ter sido impresso e processar apenas quando aviso for o 1\n  if NVL(:old.IND_IMPRESSO, 'N') = 'N'\n    and :old.ind_enviar = 'Y'\n     and :old.BEG_COB_AVISO_ID = 1000001 then\n    --\n    update DIE_COB_GERA_AVISO_LOG X\n       set X.QTDE_AVISO = X.QTDE_AVISO - 1\n     where X.AD_ORG_ID = :old.AD_ORG_ID\n       and X.BEG_COB_AVISO_ID = :old.BEG_COB_AVISO_ID\n       and TRUNC(X.CREATED) = TRUNC(:old.CREATED);\n    --\n    update BEG_CRC_TITULO T\n       set T.BEG_COB_AVISO_ID        = null,\n           T.BEG_COB_AVISO_PESSOA_ID = null,\n           T.DT_GERA_AVISO           = case when (sysdate - :old.created) > 9 then  trunc(sysdate) else TRUNC(:old.created) end\n     where T.BEG_COB_AVISO_PESSOA_ID = :old.BEG_COB_AVISO_PESSOA_ID\n       and T.BEG_COB_AVISO_ID = :old.BEG_COB_AVISO_ID\n       AND T.IND_ABERTO = 'Y';\n    --\n  else\n    RAISE_APPLICATION_ERROR(-20001, 'Não é permitido eliminar este aviso');\n  end if;\n  --\nend DIE_TRG_BD_COB_AVISO_PESSOA;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_COB_AVISO_PESSOA { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  --  VB_APEX boolean; -- 04/11/2008 - AOK\nbegin\n  if NVL(:new.IND_ENVIAR, '^') != NVL(:old.IND_ENVIAR, '^') then\n    if NVL(:new.OBS, '^') = NVL(:old.OBS, '^') then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'E necessario observar o motivo da alteração!');\n    end if;\n    -- JT 07/03/2008\n  else\n    if NVL(:new.OBS, '^') != NVL(:old.OBS, '^') then\n      RAISE_APPLICATION_ERROR(-20002,\n                              'E necessario alterar o indicativo de enviar! (Sim / Não)');\n    end if;\n  end if;\n\n  -- JT 07/04/2009\n  if NVL(:new.OBS, '^') != NVL(:old.OBS, '^') then\n    :new.OBS := UPPER(BEG_PCK_UTIL.CONVERTE_ACENTOS(:new.OBS));\n  end if;\n\n  -- AOK -- 21/04/2008\n  if NVL(:new.IND_ENVIAR, '^') != NVL(:old.IND_ENVIAR, '^') then\n    if NVL(:new.IND_ENVIAR, '^') = 'N' then\n      update DIE_COB_GERA_AVISO_LOG X\n         set X.QTDE_AVISO = X.QTDE_AVISO - 1\n       where X.AD_ORG_ID = :new.AD_ORG_ID\n         and X.BEG_COB_AVISO_ID = :new.BEG_COB_AVISO_ID\n         and TRUNC(X.CREATED) = TRUNC(:new.CREATED); -- AOK - 12/08/2008\n      --  and trunc(x.created) = trunc(sysdate);\n    else\n      update DIE_COB_GERA_AVISO_LOG X\n         set X.QTDE_AVISO = X.QTDE_AVISO + 1\n       where X.AD_ORG_ID = :new.AD_ORG_ID\n         and X.BEG_COB_AVISO_ID = :new.BEG_COB_AVISO_ID\n         and TRUNC(X.CREATED) = TRUNC(:new.CREATED); -- AOK - 12/08/2008\n      --and trunc(x.created) = trunc(sysdate);\n    end if;\n  end if;\n  -- AOK -- 04/11/2008\n  --if :new.APP_USER is not null\n  --   and UPDATING then\n  --  VB_APEX       := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TAB_UPD(:new.APP_USER,\n  --                                                              :new.UPDATED,\n  --                                                              :new.UPDATEDBY);\n  --  :new.APP_USER := null;\n  --end if;\n\nend BEG_TRG_BU_COB_AVISO_PESSOA;\n"}`;
    
    }
}
