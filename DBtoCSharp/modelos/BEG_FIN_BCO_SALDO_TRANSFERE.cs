
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_BCO_SALDO_TRANSFERE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_SALDO_TRANSFERE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_SALDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_AGENCIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_TRANFERENCIA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_TITULO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_CONTA_CORRENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_AGENCIA_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_SALDO_TRANSFERE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  CURSOR C1 IS\n    SELECT *\n      FROM beg_fin_portador C\n     WHERE C.beg_fin_portador_id = :NEW.beg_fin_portador_id;\n  --\n  R_C1 C1%ROWTYPE;\n  \n    CURSOR C2 IS\n    SELECT *\n      FROM beg_fin_portador C\n     WHERE C.beg_fin_portador_id = :NEW.beg_vw_fin_portador_id;\n  --\n  R_C2 C2%ROWTYPE;\n  --\nBEGIN\n  --\n  OPEN C1;\n  FETCH C1 INTO R_C1;\n  CLOSE C1;\n  --\n  OPEN C2;\n  FETCH C2 INTO R_C2;\n  CLOSE C2;\n  ---\n  :NEW.BEG_BANCO_ID              := R_C1.BEG_BANCO_ID;\n  :NEW.BEG_AGENCIA_ID            := R_C1.BEG_AGENCIA_ID;\n  :NEW.BEG_FIN_CONTA_CORRENTE_ID := R_C1.BEG_FIN_CONTA_CORRENTE_ID;\n  --\n  :NEW.BEG_VW_BANCO_ID              := R_C2.BEG_BANCO_ID;\n  :NEW.BEG_VW_AGENCIA_ID            := R_C2.BEG_AGENCIA_ID;\n  :NEW.BEG_VW_FIN_CONTA_CORRENTE_ID := R_C2.BEG_FIN_CONTA_CORRENTE_ID;\n  \nEND;\n"}`;
    
    }
}
