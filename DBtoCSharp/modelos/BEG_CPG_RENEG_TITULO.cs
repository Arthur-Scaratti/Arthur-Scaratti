
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_RENEG_TITULO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID dos titulos de uma renegociac?o
        /// </summary>
        public int BEG_CPG_RENEG_TITULO_ID { get; set; }
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
        /// Valor original do titulos
        /// </summary>
        public int VLR_ORIGINAL { get; set; }
            [Required]
        /// <summary>
        /// ID da renegociac?o
        /// </summary>
        public int BEG_CPG_RENEG_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do titulo
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_CPG_RENEG_TITULO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que valida os fornecedores de uma renegociac?o.\n   Modulo.......: CPG - Contas a Pagar\n   Analista.....: Tiago Gabriel\n   Alterac?es:\n   Data        Desenvolvedor  Alterac?o\n   05/10/2006  Tiago Gabriel  Criac?o.\n  --------------------------------------------------------------------------------------------------- */\n  VC_MSG_ERRO  varchar2(200);\n  VC_ISACTIVE  BEG_CPG_RENEG.ISACTIVE%type;\n  VC_DOCSTATUS BEG_CPG_RENEG.DOCSTATUS%type;\n\nbegin\n  -- Se n?o esta processando da renegociac?o, valida-a\n  if not BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG\n     /*and not BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG_FORN*/ then\n  \n    begin\n      select ISACTIVE,\n             DOCSTATUS\n        into VC_ISACTIVE,\n             VC_DOCSTATUS\n        from BEG_CPG_RENEG\n       where BEG_CPG_RENEG_ID =\n             NVL(:new.BEG_CPG_RENEG_ID, :old.BEG_CPG_RENEG_ID);\n    \n      if VC_ISACTIVE = 'N' then\n        VC_MSG_ERRO := 'Renegociac?o inativa!';\n        goto FIM;\n      end if;\n    \n      if VC_DOCSTATUS = 'WP' then\n        VC_MSG_ERRO := 'Renegociac?o aguardando pagamento!';\n        goto FIM;\n      elsif VC_DOCSTATUS = 'PA' then\n        VC_MSG_ERRO := 'Renegociac?o ja paga (liquidada)!';\n        goto FIM;\n      elsif VC_DOCSTATUS = 'CA' then\n        VC_MSG_ERRO := 'Renegociac?o cancelada!';\n        goto FIM;\n      end if;\n    \n    exception\n      when NO_DATA_FOUND then\n        VC_MSG_ERRO := 'Renegociac?o n?o encontrada!';\n        goto FIM;\n      \n      when TOO_MANY_ROWS then\n        VC_MSG_ERRO := 'Renegociac?o duplicada!';\n        goto FIM;\n      \n    end;\n  \n    if not BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_INCLUI_TITULO then\n      -- Verifica o titulo\n      begin\n        select TIT.VLR_ABERTO,\n               TIT.DOCSTATUS\n          into :new.VLR_ORIGINAL,\n               VC_DOCSTATUS\n          from BEG_CPG_TITULO           TIT,\n               BEG_CPG_RENEG_FORNECEDOR RN_FOR\n         where TIT.BEG_VW_FORNECEDOR_ID = RN_FOR.BEG_VW_FORNECEDOR_ID\n           and TIT.BEG_CPG_TITULO_ID = :new.BEG_CPG_TITULO_ID\n           and TIT.ISACTIVE = 'Y'\n           and RN_FOR.BEG_CPG_RENEG_ID = :new.BEG_CPG_RENEG_ID;\n      \n        if VC_DOCSTATUS = 'WC' then\n          VC_MSG_ERRO := 'Titulo aguardando confirmac?o!';\n          goto FIM;\n        elsif VC_DOCSTATUS = 'PA' then\n          VC_MSG_ERRO := 'Titulo pago!';\n          goto FIM;\n        elsif VC_DOCSTATUS = 'CA' then\n          VC_MSG_ERRO := 'Titulo cancelado!';\n          goto FIM;\n        end if;\n      \n      exception\n        when NO_DATA_FOUND then\n          null;\n/*          VC_MSG_ERRO := 'Titulo n?o pertence a fornecedores cadastrados para a renegociac?o!';\n          goto FIM;\n*/        \n        when TOO_MANY_ROWS then\n          VC_MSG_ERRO := 'Titulo duplicado!';\n          goto FIM;\n        \n      end;\n    \n    end if;\n  \n    -- Atualiza valores\n    update BEG_CPG_RENEG_FORNECEDOR F\n       set VLR_TOTAL_ORIGINAL = VLR_TOTAL_ORIGINAL -\n                                NVL(:old.VLR_ORIGINAL, 0) +\n                                NVL(:new.VLR_ORIGINAL, 0)\n     where BEG_CPG_RENEG_ID = :new.BEG_CPG_RENEG_ID\n       AND F.BEG_VW_FORNECEDOR_ID = :NEW.BEG_PESSOA_ID;\n  \n  end if;\n  IF DELETING THEN \n    update BEG_CPG_RENEG_FORNECEDOR\n       set VLR_TOTAL_ORIGINAL = VLR_TOTAL_ORIGINAL -\n                                NVL(:old.VLR_ORIGINAL, 0) \n     where BEG_CPG_RENEG_ID = :OLD.BEG_CPG_RENEG_ID;\n  \n  END IF;\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend TRG_BIUD_BEG_CPG_RENEG_TITULO;\n"}`;
    
    }
}
