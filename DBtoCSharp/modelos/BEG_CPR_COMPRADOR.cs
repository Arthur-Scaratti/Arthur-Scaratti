
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_COMPRADOR
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do comprador
        /// </summary>
        public int BEG_CPR_COMPRADOR_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// Codigo do comprador
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Nome do comprador
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se deve controlar alcada
        /// </summary>
        public string IND_CONTROLA_ALCADA { get; set; }
            [Required]
        /// <summary>
        /// Valor da alcada
        /// </summary>
        public int VLR_ALCADA { get; set; }
            [Required]
        /// <summary>
        /// Valor de ordens de compra aprovadas em aberto
        /// </summary>
        public int VLR_COMPRADO { get; set; }
            [Required]
        /// <summary>
        /// Valor de liberac?es recebidas em aberto
        /// </summary>
        public int VLR_LIBERADO { get; set; }
            [Required]
        /// <summary>
        /// Valor do saldo para compra
        /// </summary>
        public int VLR_SALDO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica supervisor
        /// </summary>
        public string IND_SUPERVISOR { get; set; }
        
        /// <summary>
        /// Data da ultima liberac?o recebida
        /// </summary>
        public string DT_LIBERADO { get; set; }
            [Required]
        /// <summary>
        /// Quantidade de liberac?es recebidas
        /// </summary>
        public int QTD_LIBERADO { get; set; }
            [Required]
        /// <summary>
        /// ID da pessoa
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// ID do supervisor
        /// </summary>
        public int BEG_VW_CPR_COMPRADOR_ID { get; set; }
        
        /// <summary>
        /// ID do usuario do compiere
        /// </summary>
        public int AD_USER_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_ST_BEG_CPR_COMPRADOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que alimenta a PL Table com as alcadas dos supervisores.\n  Modulo.......: CPR - Compras\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  05/09/2006  Tiago Gabriel  Criac?o.\n  ---------------------------------------------------------------------------------------------------*/\n  cursor CR_SUP is\n    select BEG_CPR_COMPRADOR_ID,\n           IND_CONTROLA_ALCADA,\n           VLR_ALCADA\n      from BEG_CPR_COMPRADOR\n     where IND_SUPERVISOR = 'Y';\n\nbegin\n  BEG_PCK_CPR_COMPRAS.VTB_ALCADA_SUP.delete;\n\n  for R_SUP in CR_SUP\n  loop\n    BEG_PCK_CPR_COMPRAS.VTB_ALCADA_SUP(R_SUP.BEG_CPR_COMPRADOR_ID).IND_CONTROLA_ALCADA := R_SUP.IND_CONTROLA_ALCADA;\n    BEG_PCK_CPR_COMPRAS.VTB_ALCADA_SUP(R_SUP.BEG_CPR_COMPRADOR_ID).VLR_ALCADA := R_SUP.VLR_ALCADA;\n  end loop;\n\nend TRG_BIU_ST_BEG_CPR_COMPRADOR;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_CPR_COMPRADOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /*---------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Manutenir a tabela de pessoas (BEG_PESSOA) quando um comprador for inserido.\n  Modulo.......: CPR - Comrpas\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor   Alterac?o\n  05/09/2006  Tiago Gabriel   Criac?o.\n  03/10/2006  Aroldo O. Krul  Inserido tratamento de when no_data_found.\n  12/10/2006  Tiago Gabriel   Ajuste na sincronia com pessoa.\n  ---------------------------------------------------------------------------------------------------*/\n  VC_VALUE    BEG_PESSOA.value%type;\n  VC_NAME     BEG_PESSOA.name%type;\n  VC_MSG_ERRO varchar2(200);\n  VN_DUMMY    number;\n\nbegin\n  if not BEG_PCK_CPR_COMPRAS.VB_PROC_PESSOA then\n  \n    BEG_PCK_CPR_COMPRAS.VB_PROC_COMPRADOR := true;\n  \n    -- Atualiza beg_pessoa\n    if DELETING\n       or :new.ISACTIVE = 'N' then\n      update BEG_PESSOA\n         set UPDATED   = sysdate,\n             UPDATEDBY = :new.UPDATEDBY,\n             COMPRADOR = 'N'\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n      goto FIM;\n    else\n      update BEG_PESSOA\n         set UPDATED   = sysdate,\n             UPDATEDBY = :new.UPDATEDBY,\n             ISACTIVE  = 'Y',\n             COMPRADOR = 'Y'\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    end if;\n  \n    -- Inicializa campos\n    if not DELETING then\n      select value,\n             name\n        into VC_VALUE,\n             VC_NAME\n        from BEG_PESSOA\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    \n      if INSERTING then\n        :new.value := NVL(:new.value, VC_VALUE);\n        :new.name  := NVL(:new.name, VC_NAME);\n      elsif UPDATING\n            and :old.BEG_PESSOA_ID <> :new.BEG_PESSOA_ID then\n        :new.value := VC_VALUE;\n        :new.name  := VC_NAME;\n      end if;\n    end if;\n  \n    BEG_PCK_CPR_COMPRAS.VB_PROC_COMPRADOR := false;\n  \n  end if;\n\n  -- Valida dados do supervisor\n  --if not deleting then\n  if :new.BEG_VW_CPR_COMPRADOR_ID is not null then\n    if :new.BEG_VW_CPR_COMPRADOR_ID = :new.BEG_CPR_COMPRADOR_ID then\n      VC_MSG_ERRO := 'Comprador n?o pode ser supervisor de si proprio!';\n      goto FIM;\n    end if;\n  \n    if :new.IND_CONTROLA_ALCADA = 'N' then\n      VC_MSG_ERRO := 'Supervisor informado para comprador que n?o controla alcada!';\n      goto FIM;\n    end if;\n  \n    -- Verifica a alcada do supervisor\n    if BEG_PCK_CPR_COMPRAS.VTB_ALCADA_SUP(:new.BEG_VW_CPR_COMPRADOR_ID)\n    .IND_CONTROLA_ALCADA = 'Y'\n       and :new.VLR_ALCADA >=\n       BEG_PCK_CPR_COMPRAS.VTB_ALCADA_SUP(:new.BEG_VW_CPR_COMPRADOR_ID)\n    .VLR_ALCADA then\n      VC_MSG_ERRO := 'Alcada do supervisor insuficiente!';\n      goto FIM;\n    end if;\n  \n  end if;\n\n  -- Valida informac?es se e um supervisor\n  if NVL(:old.IND_SUPERVISOR, '^') <> NVL(:new.IND_SUPERVISOR, '^')\n     and NVL(:old.IND_SUPERVISOR, 'N') = 'Y' then\n  \n    -- Verifica se existem liberac?es\n    select count(1)\n      into VN_DUMMY\n      from BEG_CPR_LIBERACAO\n     where BEG_VW_CPR_COMPRADOR_ID = :old.BEG_CPR_COMPRADOR_ID;\n  \n    if VN_DUMMY > 0 then\n      VC_MSG_ERRO := 'Supervisor com liberac?es efetuadas!';\n      goto FIM;\n    end if;\n  \n    /*\n        -- Desvincula os supervisionados\n        update BEG_CPR_COMPRADOR\n           set BEG_VW_CPR_COMPRADOR_ID = null\n         where BEG_VW_CPR_COMPRADOR_ID = :old.BEG_CPR_COMPRADOR_ID;\n    */\n  end if;\n\n  -- Se deixou de controlar alcada, valida o saldo\n  if NVL(:old.IND_CONTROLA_ALCADA, '^') <>\n     NVL(:new.IND_CONTROLA_ALCADA, '^')\n     and NVL(:old.IND_CONTROLA_ALCADA, 'N') = 'Y'\n     and :new.VLR_COMPRADO > 0 then\n    VC_MSG_ERRO := 'Comprador com ordens em aberto!';\n    goto FIM;\n  end if;\n\n  -- Valida campos informados\n  if :new.IND_CONTROLA_ALCADA = 'N' then\n    :new.VLR_ALCADA   := 0;\n    :new.VLR_COMPRADO := 0;\n    :new.VLR_LIBERADO := 0;\n    :new.VLR_SALDO    := 0;\n    :new.DT_LIBERADO  := null;\n    :new.QTD_LIBERADO := 0;\n  else\n    if NVL(:new.VLR_ALCADA, 0) <= 0 then\n      VC_MSG_ERRO := 'Valor de alcada deve ser informado!';\n      goto FIM;\n    end if;\n  \n    -- Atualiza o saldo de compras\n    :new.VLR_SALDO := :new.VLR_ALCADA - :new.VLR_COMPRADO;\n  \n    if :new.VLR_SALDO < 0 then\n      VC_MSG_ERRO := 'Saldo negativo!';\n      goto FIM;\n    end if;\n  \n  end if;\n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend TRG_BIUD_BEG_CPR_COMPRADOR;\n"}`;
    
    }
}
