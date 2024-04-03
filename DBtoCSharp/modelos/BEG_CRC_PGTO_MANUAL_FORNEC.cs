
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_PGTO_MANUAL_FORNEC
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_PGTO_MANUAL_FORNEC_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_PGTO_MANUAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
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
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DEVOLVIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_DEP_VINC_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIUD_PGTO_MANUAL_FOR { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\n  CURSOR C1 IS\n    SELECT COUNT(T.BEG_CRC_PGTO_MANUAL_TITULO_ID) QTDE\n      FROM BEG_CRC_PGTO_MANUAL_TITULO T\n     WHERE T.BEG_CRC_PGTO_MANUAL_FORNEC_ID =\n           :NEW.BEG_CRC_PGTO_MANUAL_FORNEC_ID\n       AND T.ISACTIVE = 'Y';\n  R1 C1%ROWTYPE;\n\n  --\nBEGIN\n  --\n  IF UPDATING AND :NEW.ISACTIVE = 'N' AND :OLD.ISACTIVE = 'Y' THEN\n  \n    open C1;\n    fetch C1\n      into R1;\n    close C1;\n    IF NVL(R1.QTDE, 0) > 0 THEN\n      raise_application_error(-20001,\n                              'Parceiro Comercial com titulos ativos, nao permite inativar.');\n    END IF;\n  END IF;\n\n  UPDATE BEG_CRC_PGTO_MANUAL M\n     SET M.VLR_TOTAL = NVL(M.VLR_TOTAL, 0) - NVL(:OLD.VLR_TITULO, 0) +\n                       NVL(:NEW.VLR_TITULO, 0)\n   WHERE M.BEG_CRC_PGTO_MANUAL_ID = :NEW.BEG_CRC_PGTO_MANUAL_ID;\n  --\nEND;\n"}`;
    
    }
}
