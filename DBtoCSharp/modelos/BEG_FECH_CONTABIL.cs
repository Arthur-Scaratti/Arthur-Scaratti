
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FECH_CONTABIL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FECH_CONTABIL_ID { get; set; }
        
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FINAL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESCRITA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BID_FECH_FORN { get; set; } = `{"triggering_event":"INSERT OR DELETE","trigger_body":"DECLARE\n  --\n  pragma autonomous_transaction;\n  --\n  CURSOR C1 IS\n    SELECT NVL(C.VALUE,0) VALUE\n      FROM BEG_FECH_CONTABIL C\n     WHERE C.BEG_FECH_CONTABIL_ID = :NEW.BEG_FECH_CONTABIL_ID;\n  --\n  R_C1 C1%ROWTYPE;\n  --\n  CURSOR C2 IS\n    SELECT NVL(C.VALUE,0) VALUE\n      FROM BEG_FECH_CONTABIL C\n     WHERE C.BEG_FECH_CONTABIL_ID = :OLD.BEG_FECH_CONTABIL_ID;\n  --\n  R_C2 C2%ROWTYPE;\n  --\n  VN_VALUE NUMBER(10);\n  --\nBEGIN\n  --\n  OPEN C1;\n  FETCH C1 INTO R_C1;\n  CLOSE C1;\n  --\n  IF INSERTING THEN\n    --\n    :NEW.VALUE := NVL(:NEW.VALUE,0) + 1;\n    --\n  ELSIF DELETING THEN\n    --\n    OPEN C2;\n    FETCH C2 INTO R_C2;\n    CLOSE C2;\n    --\n    SELECT MAX(VALUE)\n      INTO VN_VALUE\n      FROM BEG_FECH_CONTABIL;\n    --\n    IF R_C2.VALUE < VN_VALUE THEN\n      RAISE_APPLICATION_ERROR(-20001,'Não pode deletar, possui dias a frente!');\n    END IF;\n    --\n  END IF;\n  --\nEND;\n"}`;
    
    }
}
