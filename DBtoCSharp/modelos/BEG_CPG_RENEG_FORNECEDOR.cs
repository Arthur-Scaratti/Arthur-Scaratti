
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_RENEG_FORNECEDOR
    {
            [Required]
    [Key]
        /// <summary>
        /// ID de fornecedores de uma renegociac?o
        /// </summary>
        public int BEG_CPG_RENEG_FORNECEDOR_ID { get; set; }
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
        /// Valor total original dos titulos deste fornecedor
        /// </summary>
        public int VLR_TOTAL_ORIGINAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Bot?o auxiliar para o Compiere que processa a inclus?o de titulos na renegociac?o
        /// </summary>
        public string BTN_INCLUI_TITULOS { get; set; }
            [Required]
        /// <summary>
        /// ID do fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// ID da renegociac?o
        /// </summary>
        public int BEG_CPG_RENEG_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_CPG_RENEG_FORN { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que valida os fornecedores de uma renegociac?o.\n   Modulo.......: CPG - Contas a Pagar\n   Analista.....: Tiago Gabriel\n   Alterac?es:\n   Data        Desenvolvedor  Alterac?o\n   05/10/2006  Tiago Gabriel  Criac?o.\n  --------------------------------------------------------------------------------------------------- */\n  VC_MSG_ERRO  varchar2(200);\n  VC_ISACTIVE  BEG_CPG_RENEG.ISACTIVE%type;\n  VC_DOCSTATUS BEG_CPG_RENEG.DOCSTATUS%type;\n\nbegin\n  if not BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG then\n  \n    begin\n      select ISACTIVE,\n             DOCSTATUS\n        into VC_ISACTIVE,\n             VC_DOCSTATUS\n        from BEG_CPG_RENEG\n       where BEG_CPG_RENEG_ID =\n             NVL(:new.BEG_CPG_RENEG_ID, :old.BEG_CPG_RENEG_ID);\n    \n      if VC_ISACTIVE = 'N' then\n        VC_MSG_ERRO := 'Renegociac?o inativa!';\n        goto FIM;\n      end if;\n    \n      if VC_DOCSTATUS = 'WP' then\n        VC_MSG_ERRO := 'Renegociac?o aguardando pagamento!';\n        goto FIM;\n      elsif VC_DOCSTATUS = 'PA' then\n        VC_MSG_ERRO := 'Renegociac?o ja paga (liquidada)!';\n        goto FIM;\n      elsif VC_DOCSTATUS = 'CA' then\n        VC_MSG_ERRO := 'Renegociac?o cancelada!';\n        goto FIM;\n      end if;\n    \n    exception\n      when NO_DATA_FOUND then\n        VC_MSG_ERRO := 'Renegociac?o n?o encontrada!';\n        goto FIM;\n      \n      when TOO_MANY_ROWS then\n        VC_MSG_ERRO := 'Renegociac?o duplicada!';\n        goto FIM;\n      \n    end;\n  \n--    BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG_FORN := true;\n  \n    -- Se esta excluindo um fornecedor, exclui tambem os titulos.\n    if DELETING then\n    \n      -- Exclui titulos vinculados\n      delete from BEG_CPG_RENEG_TITULO RN_TIT\n       where exists\n       (select 1\n                from BEG_CPG_TITULO TIT\n               where TIT.BEG_CPG_TITULO_ID = RN_TIT.BEG_CPG_TITULO_ID\n                 and TIT.BEG_VW_FORNECEDOR_ID = :new.BEG_VW_FORNECEDOR_ID)\n         and RN_TIT.BEG_CPG_RENEG_ID = :new.BEG_CPG_RENEG_ID;\n    \n    end if;\n  \n    -- Atualiza valores\n    update BEG_CPG_RENEG C\n       set VLR_TOTAL_ORIGINAL = VLR_TOTAL_ORIGINAL -\n                                NVL(:old.VLR_TOTAL_ORIGINAL, 0) +\n                                NVL(:new.VLR_TOTAL_ORIGINAL, 0),\n           C.VLR_TOTAL_RENEG  = C.VLR_TOTAL_RENEG -\n                                NVL(:OLD.VLR_TOTAL_ORIGINAL, 0) +\n                                NVL(:NEW.VLR_TOTAL_ORIGINAL, 0),\n           C.VLR_ABERTO       = C.VLR_ABERTO -\n                                NVL(:OLD.VLR_TOTAL_ORIGINAL, 0) +\n                                NVL(:NEW.VLR_TOTAL_ORIGINAL, 0)                                \n     where BEG_CPG_RENEG_ID = :new.BEG_CPG_RENEG_ID;\n  \n--    BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG_FORN := false;\n  \n  end if;\n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend TRG_BIUD_BEG_CPG_RENEG_FORN;\n"}`;
    
    }
}
