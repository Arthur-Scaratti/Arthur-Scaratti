
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COBRADOR_FILIAL
    {
        
        /// <summary>
        /// Indica geração de lote novos devedores (Sim / Não)
        /// </summary>
        public string IND_GERA_LOTE_DEVEDOR { get; set; }
        
        /// <summary>
        /// Indica geração de lote de baixas de devedores (Sim / Não)
        /// </summary>
        public string IND_GERA_LOTE_BAIXAS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do cobrador filial
        /// </summary>
        public int BEG_COBRADOR_FILIAL_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
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
        /// id do cobrador
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da filial que o cobrador atende
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Codigo do cobrador na filial - temporario - apenas para as cargas
        /// </summary>
        public int CODFIL { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuário APEX.
        /// </summary>
        public string APP_USER { get; set; }
        
        /// <summary>
        /// Numero de dias minimo  de atraso a ser considerado para este cobrador
        /// </summary>
        public int NRO_DIAS_MIN { get; set; }
        
        /// <summary>
        /// Numero de dias maximo de atraso a ser considerado para este cobrador
        /// </summary>
        public int NRO_DIAS_MAX { get; set; }
        
        /// <summary>
        /// Indica geração de lote novos devedores automaticamente para esta filial (Sim / Não)
        /// </summary>
        public string IND_GERA_LOTE_AUTO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BI_COB_FILIAL { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  cursor C_COB is\n    select c.*\n      from beg_cobrador c\n     where c.beg_cobrador_id = :new.beg_cobrador_id;\n\n  R_COB C_COB%ROWTYPE;\n\n  --\nbegin\n  if updating then\n    open C_COB;\n    fetch C_COB\n      into R_COB;\n    close C_COB;\n    if R_COB.IND_ATUACAO IN ('A'/*, 'E'*/) THEN\n      if :NEW.ISACTIVE = 'N' AND :OLD.ISACTIVE = 'Y' then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Para não enviar mais cobranca desta filial apenas desmarcar Gerar lote novos Devedores !! ');\n      end if;\n    \n      if :NEW.BEG_FILIAL_ID <> :OLD.BEG_FILIAL_ID then\n        RAISE_APPLICATION_ERROR(-20001,\n                                'Não é permitido alterar filial !! ');\n      end if;\n    END IF;\n  end if;\n\nend BEG_TRG_IR_COB_FILIAL;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BI_COB_FILIAL_APEX { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  --\n  VB_APEX boolean;\n  --\nbegin\n  if :new.APP_USER is not null\n     and INSERTING then\n    --  :new.DOCSTATUS := 'CO';\n    VB_APEX       := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n                                                              'BEG_COBRADOR_FILIAL',\n                                                              :new.AD_CLIENT_ID,\n                                                              :new.AD_ORG_ID,\n                                                              :new.CREATED,\n                                                              :new.CREATEDBY,\n                                                              :new.UPDATED,\n                                                              :new.UPDATEDBY,\n                                                              :new.BEG_COBRADOR_FILIAL_ID);\n    :new.APP_USER := null;\n  end if;\nend BEG_TRG_IR_COB_FILIAL;\n"}`;
    
    }
}
