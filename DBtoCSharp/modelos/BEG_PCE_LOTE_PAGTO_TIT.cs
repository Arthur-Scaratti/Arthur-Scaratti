
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PCE_LOTE_PAGTO_TIT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PCE_LOTE_PAGTO_TIT_ID { get; set; }
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
        /// ID do titulo
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do lote de pagamento
        /// </summary>
        public int BEG_PCE_LOTE_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// parcela do titulo
        /// </summary>
        public int PARCELA { get; set; }
        
        /// <summary>
        /// data de vencimento
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// valor do titulo - valor em aberto
        /// </summary>
        public int VLR_TITULO { get; set; }
        
        /// <summary>
        /// Fornecedor
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// banco do boleto
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// Indica se o titulo possui codigo de barras
        /// </summary>
        public string IND_TIT_COD_BARRAS { get; set; }
        
        /// <summary>
        /// Se o fornecedor do titulo possui dados bancarios
        /// </summary>
        public int BEG_DADOS_BANCARIOS_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BD_PCE_LOTE_PAGTO_TIT { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  --\n  CURSOR C1 IS\n    SELECT *\n      FROM BEG_PCE_LOTE_PAGAMENTO P\n     WHERE P.BEG_PCE_LOTE_PAGAMENTO_ID = :OLD.BEG_PCE_LOTE_PAGAMENTO_ID\n       AND P.DOCSTATUS                 = 'WP';\n  --\n  R_C1 C1%ROWTYPE;\n  --\nBEGIN\n  --\n  OPEN C1;\n  FETCH C1 INTO R_C1;\n    IF C1%FOUND THEN\n      RAISE_APPLICATION_ERROR(-20001,'Não pode deletar movimentos quando lote estiver fechado!');\n    END IF;\n  CLOSE C1;\n  --\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BU_PCE_LOTE_PAGTO_TIT { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n  cursor C1(PID number) is\n    select DOCSTATUS\n      from BEG_PCE_LOTE_PAGAMENTO L\n     where L.BEG_PCE_LOTE_PAGAMENTO_ID = :NEW.BEG_PCE_LOTE_PAGAMENTO_ID;\n  --\n  VPID    number(10);\n  VSTATUS BEG_PCE_LOTE_PAGAMENTO.DOCSTATUS%type;\n  --\nbegin\n  --\n  -- Verificar se pode ser realizado alteracao de valores\n  --\n  open C1(VPID);\n  fetch C1\n    into VSTATUS;\n  close C1;\n  if NVL(VSTATUS, 'XX') = 'WP' then\n    RAISE_APPLICATION_ERROR(-20001\n                           ,'N?o mais e permitido realizar alterac?es');\n  end if;\n  --\n  --  Se naum existir a informacao de codigo de barras no titulo e naum for informado dados bancarios - o reg. naum \n  --  pode ser ativado, isto e, naum podera ser enviando para pagamento escritural\n  --\n  /* if :new.ISACTIVE <> :old.ISACTIVE then\n    if :new.IND_TIT_COD_BARRAS = 'N'\n       and :new.BEG_DADOS_BANCARIOS_ID is null then\n      :new.ISACTIVE := 'N';\n    end if;\n  end if;*/\n  --\n  if :NEW.ISACTIVE = 'N' then\n    update BEG_PCE_LOTE_PAGAMENTO LP\n       set LP.VLR_LOTE = LP.VLR_LOTE - :NEW.VLR_TITULO\n     where LP.BEG_PCE_LOTE_PAGAMENTO_ID = :NEW.BEG_PCE_LOTE_PAGAMENTO_ID;\n  else\n    update BEG_PCE_LOTE_PAGAMENTO LP\n       set LP.VLR_LOTE = LP.VLR_LOTE + :NEW.VLR_TITULO\n     where LP.BEG_PCE_LOTE_PAGAMENTO_ID = :NEW.BEG_PCE_LOTE_PAGAMENTO_ID;\n  end if;\n  --\nend BEG_TRG_BU_PCE_LOTE_PAGTO_TIT;\n"}`;
    
    }
}
