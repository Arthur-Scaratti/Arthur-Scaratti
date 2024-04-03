
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_PGTO_MANUAL
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CC_HISTORICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CHEQUE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CARTAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_MARCAR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// USUARIO
        /// </summary>
        public string USUARIO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESTORNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CONTA_CORRENTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_REALIZADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_PGTO_MANUAL_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO_FINAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCACTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO_INICIAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_CADASTRO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_PREVISTA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_CPG_PGTO_MANUAL { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n\n  if :new.BEG_VW_FORNECEDOR_ID is null\n     and :new.DT_VCTO_INICIAL is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'FORNECEDOR OU VENCIMENTO DEVE SER INFORMADO !');\n  END IF;\n  IF :NEW.docaction IS NULL THEN\n    :NEW.docaction := 'PR';\n  end if;\n  \n   :NEW.DATA_CADASTRO := :NEW.DATA_REALIZADA;\n   \n  \n  \nend;\n"}`;
    
    }
}
