
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_SOL_FECH_CAIXA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_SOL_FECH_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DINHEIRO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MOEDAS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CHEQUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESPESA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_DIE_FIN_SOL_FECH_CAIXA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  -- LOCAL VARIABLES HERE\nBEGIN\n  IF INSERTING THEN\n    :NEW.DOCSTATUS := 'WC';\n  END IF;\n\n  :NEW.VLR_TOTAL := NVL(:NEW.VLR_DINHEIRO, 0) + NVL(:NEW.VLR_MOEDAS, 0) +\n                    NVL(:NEW.VLR_CHEQUE, 0) + NVL(:NEW.VLR_DESPESA, 0);\n\n  IF UPDATING THEN\n    :NEW.UPDATED := SYSDATE;\n  END IF;\n  \n  IF NVL(:NEW.VLR_TOTAL,0) >= 500.01 and trim(:new.observacao) is null THEN\n     RAISE_APPLICATION_ERROR(-20002,\n                            'Valor total superior a R$500,00 obrigatorio informar motivo!');\n  \n  END IF; \n\nEND TRG_BIU_DIE_FIN_SOL_FECH_CAIXA;\n"}`;
    
    }
}
