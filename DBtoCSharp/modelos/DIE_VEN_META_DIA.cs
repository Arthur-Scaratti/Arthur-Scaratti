
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VEN_META_DIA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_VEN_META_DIA_ID { get; set; }
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
        public int VLR_META_VENDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_META { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIUD_DIE_VEN_META_DIA { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"DECLARE\n\n  V_DATA DATE;\n\n  CURSOR C1 IS\n    SELECT SUM(M.VLR_META_VENDA) VLR_META\n      FROM DIE_VEN_META M\n     WHERE M.DT_FINAL = LAST_DAY(V_DATA);\n  R1 C1%ROWTYPE;\n\nBEGIN\n\n  IF INSERTING OR UPDATING THEN\n  \n    V_DATA := :NEW.DATA;\n  \n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n    IF R1.VLR_META > 0 THEN\n    \n      raise_application_error(-20001,\n                              'Valores de metas já lançados não permite inclusão ou alteração de registros');\n    \n    END IF;\n  ELSE\n  \n    V_DATA := :OLD.DATA;\n  \n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n    IF R1.VLR_META > 0 THEN\n    \n      raise_application_error(-20001,\n                              'Valores de metas já lançados não permite exclusão de registros');\n    \n    END IF;\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
