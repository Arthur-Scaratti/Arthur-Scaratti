
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_RENEG_PARCELA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IOF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_JUROS_REAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDOR { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da parcela da renegociac?o
        /// </summary>
        public int BEG_CPG_RENEG_PARCELA_ID { get; set; }
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
        /// Sequencial da parcela
        /// </summary>
        public int VALUE { get; set; }
            [Required]
        /// <summary>
        /// Data de vencimento da parcela
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// Taxa de juros real calculada pelo prazo
        /// </summary>
        public int TAX_JUROS_REAL { get; set; }
            [Required]
        /// <summary>
        /// Valor original da parcela
        /// </summary>
        public int VLR_ORIGINAL { get; set; }
            [Required]
        /// <summary>
        /// Valor renegociado da parcela aplicada a taxa de juros
        /// </summary>
        public int VLR_RENEG { get; set; }
            [Required]
        /// <summary>
        /// Valor dos encargos
        /// </summary>
        public int VLR_ENCARGOS { get; set; }
            [Required]
        /// <summary>
        /// Valor em aberto da parcela
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// Numero de dias de prazo
        /// </summary>
        public int NRO_DIAS_PRAZO { get; set; }
            [Required]
        /// <summary>
        /// ID da renegociac?o
        /// </summary>
        public int BEG_CPG_RENEG_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIUD_BEG_CPG_RENEG_PARCELA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  /* ---------------------------------------------------------------------------------------------------\n   Objetivo(s)..: Trigger que atualiza os somatorios das parcelas.\n   Modulo.......: CPG - Contas a Pagar\n   Analista.....: Tiago Gabriel\n   Alterac?es:\n   Data        Desenvolvedor  Alterac?o\n   06/10/2006  Tiago Gabriel  Criac?o.\n  --------------------------------------------------------------------------------------------------- */\n  VC_MSG_ERRO  varchar2(200);\n  VC_ISACTIVE  BEG_CPG_RENEG.ISACTIVE%type;\n  VC_DOCSTATUS BEG_CPG_RENEG.DOCSTATUS%type;\n  VN_ENCARGOS  NUMBER(18,4) := 0;\n  VN_VENDOR    NUMBER(18,4) := 0;\n  VN_IOF       NUMBER(18,4) := 0;\nbegin\n   --\n  IF INSERTING THEN\n  :NEW.VLR_ABERTO := NVL(:NEW.VLR_ABERTO,0) \n                   + NVL(:NEW.VLR_ENCARGOS,0) \n                   + NVL(:NEW.VLR_VENDOR,0) \n                   + NVL(:NEW.VLR_IOF,0);\n  ELSIF UPDATING THEN\n    VN_ENCARGOS := VN_ENCARGOS + NVL(:NEW.VLR_ENCARGOS,0) - NVL(:OLD.VLR_ENCARGOS,0);\n    VN_VENDOR   := VN_VENDOR   + NVL(:NEW.VLR_VENDOR,0) - NVL(:OLD.VLR_VENDOR,0);\n    VN_IOF      := VN_IOF      + NVL(:OLD.VLR_IOF,0) - NVL(:OLD.VLR_IOF,0);\n    --\n    :NEW.VLR_ABERTO := :NEW.VLR_ABERTO + VN_ENCARGOS + VN_VENDOR + VN_IOF;\n  END IF;\n  --\n  -- Se n?o esta processando da renegociac?o, valida-a\n  if not BEG_PCK_CPG_CONTAS_PAGAR.VB_PROC_RENEG then\n  \n    begin\n      select ISACTIVE,\n             DOCSTATUS\n        into VC_ISACTIVE,\n             VC_DOCSTATUS\n        from BEG_CPG_RENEG\n       where BEG_CPG_RENEG_ID =\n             NVL(:new.BEG_CPG_RENEG_ID, :old.BEG_CPG_RENEG_ID);\n    \n      if VC_ISACTIVE = 'N' then\n        VC_MSG_ERRO := 'Renegociac?o inativa!';\n        goto FIM;\n      end if;\n    \n/*      if VC_DOCSTATUS = 'WP' then\n        VC_MSG_ERRO := 'Renegociac?o aguardando pagamento!';\n        goto FIM;\n      els*/if VC_DOCSTATUS = 'PA' then\n        VC_MSG_ERRO := 'Renegociac?o ja paga (liquidada)!';\n        goto FIM;\n      elsif VC_DOCSTATUS = 'CA' then\n        VC_MSG_ERRO := 'Renegociac?o cancelada!';\n        goto FIM;\n      end if;\n    \n    exception\n      when NO_DATA_FOUND then\n        VC_MSG_ERRO := 'Renegociac?o n?o encontrada!';\n        goto FIM;\n      \n      when TOO_MANY_ROWS then\n        VC_MSG_ERRO := 'Renegociac?o duplicada!';\n        goto FIM;\n      \n    end;\n  \n  end if;\n\n  <<FIM>>\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend TRG_BIUD_BEG_CPG_RENEG_PARCELA;\n"}`;
    
    }
}
