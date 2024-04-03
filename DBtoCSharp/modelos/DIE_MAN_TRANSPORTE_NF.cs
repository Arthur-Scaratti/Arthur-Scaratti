
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_MAN_TRANSPORTE_NF
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_MAN_TRANSPORTE_NF_ID { get; set; }
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
        /// Id do manifesto
        /// </summary>
        public int DIE_MAN_TRANSPORTE_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da nota de saida
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [Required]
        /// <summary>
        /// Valor total da NF
        /// </summary>
        public int VL_TOTAL_NFS { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// Data de Emissao da NF
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// WC,AP,CO, CA
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// Peso bruto total da NF
        /// </summary>
        public int PESO_BRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AIUD_MAN_TRANSPORTE_NF { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n\n  PRAGMA AUTONOMOUS_TRANSACTION;\n\nBEGIN\n\n  \n   \n  IF :NEW.ISACTIVE = 'Y' AND :OLD.ISACTIVE = 'N'  THEN\n\n    UPDATE DIE_MAN_TRANSPORTE A\n       SET A.VL_TOTAL_NFS = A.VL_TOTAL_NFS + :NEW.VL_TOTAL_NFS,\n           A.PESO_BRUTO =  A.PESO_BRUTO + :NEW.PESO_BRUTO\n     WHERE A.DIE_MAN_TRANSPORTE_ID = :NEW.DIE_MAN_TRANSPORTE_ID;\n\n    COMMIT;\n\n  END IF;\n  IF :NEW.ISACTIVE = 'N' AND :OLD.ISACTIVE= 'Y' THEN\n\n    UPDATE DIE_MAN_TRANSPORTE A\n       SET A.VL_TOTAL_NFS = A.VL_TOTAL_NFS - :NEW.VL_TOTAL_NFS,\n           A.PESO_BRUTO =  A.PESO_BRUTO - :NEW.PESO_BRUTO\n     WHERE A.DIE_MAN_TRANSPORTE_ID = :NEW.DIE_MAN_TRANSPORTE_ID;\n\n    COMMIT;\n\n  END IF;\n\nEND DIE_TRG_AIUD_MAN_TRANSPORTE_NF;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BI_MAN_TRANSPORTE_NF { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  CURSOR C1 IS\n    SELECT N.DIE_MAN_TRANSPORTE_ID, N.DT_EMISSAO, N.VL_TOTAL_NFS\n      FROM BEG_FAT_NFS N\n     WHERE N.BEG_FAT_NFS_ID = :NEW.BEG_FAT_NFS_ID;\n  R1 C1%rowtype;\n\n  CURSOR C2 IS\n    SELECT *\n      FROM DIE_MAN_TRANSPORTE T\n     WHERE T.DIE_MAN_TRANSPORTE_ID = :NEW.DIE_MAN_TRANSPORTE_ID;\n  R2 C2%rowtype;\n\nBEGIN\n  --\n\n  IF DELETING THEN\n  \n    IF :OLD.DOCSTATUS = 'CA' OR :OLD.DOCSTATUS = 'CO' OR\n       :OLD.DOCSTATUS = 'AP' THEN\n    \n      RAISE_APPLICATION_ERROR(-20502,\n                              'Manifesto em andamento nao pode ser excluido ');\n    \n    END IF;\n  END IF;\n\n  IF INSERTING THEN\n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n  \n    IF R1.DIE_MAN_TRANSPORTE_ID IS NOT NULL THEN\n    \n      RAISE_APPLICATION_ERROR(-20502,\n                              'NF/Cupom já manifestado não pode inserir. Verifique!! ');\n    \n    END IF;\n  \n    IF INSERTING AND :NEW.ISACTIVE = 'Y' THEN\n      \n      OPEN C2;\n      FETCH C2\n        INTO R2;\n      CLOSE C2;\n    \n      IF R2.DOCSTATUS IN ('AP') THEN\n      \n        RAISE_APPLICATION_ERROR(-20502,\n                                'Manifesto ja aprovado não permite incluir novas notas . Verifique!! ');\n      \n      END IF;\n    \n      IF R2.DOCSTATUS IN ('CO') THEN\n      \n        RAISE_APPLICATION_ERROR(-20502,\n                                'Manifesto ja concluido não permite incluir novas notas . Verifique!! ');\n      \n      END IF;\n    \n      IF R2.DOCSTATUS IN ('CA') THEN\n      \n        RAISE_APPLICATION_ERROR(-20502,\n                                'Manifesto cancelado não permite incluir novas notas . Verifique!! ');\n      \n      END IF;\n    END IF;\n  \n    :NEW.DT_EMISSAO   := R1.DT_EMISSAO;\n    :NEW.VL_TOTAL_NFS := R1.VL_TOTAL_NFS;\n  \n  END IF;\n\n  IF :OLD.BEG_FAT_NFS_ID <> :NEW.BEG_FAT_NFS_ID THEN\n  \n    RAISE_APPLICATION_ERROR(-20502,\n                            'Nao e permitido alterar numero da NF/cupom. Verifique!! ');\n  \n  END IF;\n\n  IF inserting and :NEW.ISACTIVE = 'Y' THEN\n  \n    UPDATE DIE_MAN_TRANSPORTE A\n       SET A.VL_TOTAL_NFS = A.VL_TOTAL_NFS + :NEW.VL_TOTAL_NFS,\n           A.PESO_BRUTO   = A.PESO_BRUTO + :NEW.PESO_BRUTO\n     WHERE A.DIE_MAN_TRANSPORTE_ID = :NEW.DIE_MAN_TRANSPORTE_ID;\n  \n  END IF;\n\nEND DIE_TRG_BI_MAN_TRANSPORTE_NF;\n"}`;
    
    }
}
