
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARTAO_CR_COMPRAS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_COMPRAS_ID { get; set; }
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
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_PARCELA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PARCELA { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_FATURA_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CANCELADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CANCELAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS_SAQUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int IOF { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TAC { get; set; }

        [NotMapped]
        public string Trigger_DIE_BIUD_CARTAO_CR_COMPRAS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"BEGIN\n\n  IF INSERTING THEN\n  \n    UPDATE DIE_CARTAO_CR_FATURA A\n       SET A.VLR_FATURA = A.VLR_FATURA + :NEW.VLR_PARCELA,\n           A.VLR_ABERTO = A.VLR_ABERTO + :NEW.VLR_PARCELA\n     WHERE A.DIE_CARTAO_CR_FATURA_ID = :NEW.DIE_CARTAO_CR_FATURA_ID;\n  \n  END IF;\n\n  IF DELETING THEN\n  \n    UPDATE DIE_CARTAO_CR_FATURA A\n       SET A.VLR_FATURA = A.VLR_FATURA - :OLD.VLR_PARCELA,\n           A.VLR_ABERTO = A.VLR_ABERTO - :OLD.VLR_PARCELA\n     WHERE A.DIE_CARTAO_CR_FATURA_ID = :OLD.DIE_CARTAO_CR_FATURA_ID;\n  \n  END IF;\n\n  IF UPDATING AND :NEW.IND_CANCELADO = 'Y' AND :OLD.IND_CANCELADO = 'N' THEN\n  \n    UPDATE DIE_CARTAO_CR_FATURA A\n       SET A.VLR_FATURA = A.VLR_FATURA - :NEW.VLR_PARCELA,\n           A.VLR_ABERTO = A.VLR_ABERTO - :NEW.VLR_PARCELA\n     WHERE A.DIE_CARTAO_CR_FATURA_ID = :NEW.DIE_CARTAO_CR_FATURA_ID;\n  \n  END IF;\n\n  IF UPDATING AND :NEW.IND_CANCELADO = 'N' AND :OLD.IND_CANCELADO = 'Y' AND\n     :NEW.DT_CANCELAMENTO IS NOT NULL THEN\n  \n    RAISE_APPLICATION_ERROR(-20001,\n                            'Data de cancelamento preenchida, não pode reativar registro.');\n  \n  END IF;\n\n  IF UPDATING AND :NEW.IND_CANCELADO = 'N' AND :OLD.IND_CANCELADO = 'Y' AND\n     :NEW.DT_CANCELAMENTO IS NULL THEN\n  \n    UPDATE DIE_CARTAO_CR_FATURA A\n       SET A.VLR_FATURA = A.VLR_FATURA + :NEW.VLR_PARCELA,\n           A.VLR_ABERTO = A.VLR_ABERTO + :NEW.VLR_PARCELA\n     WHERE A.DIE_CARTAO_CR_FATURA_ID = :NEW.DIE_CARTAO_CR_FATURA_ID;\n  \n  END IF;\n\n  IF UPDATING AND :NEW.VLR_PARCELA <> :OLD.VLR_PARCELA THEN\n  \n    UPDATE DIE_CARTAO_CR_FATURA A\n       SET A.VLR_FATURA = A.VLR_FATURA - :OLD.VLR_PARCELA + :NEW.VLR_PARCELA,\n           A.VLR_ABERTO = A.VLR_ABERTO - :OLD.VLR_PARCELA + :NEW.VLR_PARCELA\n     WHERE A.DIE_CARTAO_CR_FATURA_ID = :NEW.DIE_CARTAO_CR_FATURA_ID;\n  \n  END IF;\n\nEND DIE_BIU_CARTAO_CR_COMPRAS;\n"}`;
    
    }
}
