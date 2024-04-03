
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NFE_CONV_NOTAS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Tabela com as notas relacionada a emissao das notas CFOP5929 para conveniada
        /// </summary>
        public int DIE_NFE_CONV_NOTAS_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_NFE_CONVENIO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_NF { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BU_NFE_CONV_NOTAS { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"DECLARE\n\n  CURSOR C1 IS \n  \n  SELECT N.QTDE\n    FROM DIE_NFE_CONVENIO N\n   WHERE N.DIE_NFE_CONVENIO_ID = :NEW.DIE_NFE_CONVENIO_ID;\n  R1 C1%ROWTYPE;\n  \n\nBEGIN\n\n  IF :NEW.ISACTIVE ='Y' AND :OLD.ISACTIVE ='N' THEN\n    \n    OPEN C1;\n    FETCH C1\n    INTO R1;\n    CLOSE C1;\n    IF R1.QTDE = 20 THEN\n     raise_application_error(-20001, 'Numero de nfs vinculadas ja atingiu o máximo de 20.');  \n    \n    END IF;\n  \n  \n  END IF;\n\n\n\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AU_NFE_CONV_NOTAS { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"BEGIN\n\n\n   IF :NEW.ISACTIVE ='Y' AND :OLD.ISACTIVE = 'N' THEN\n     \n     UPDATE DIE_NFE_CONVENIO N SET \n       N.VLR_TOTAL = N.VLR_TOTAL + :NEW.VALOR ,\n       N.QTDE      = N.QTDE + 1,\n       N.VLR_DESCONTO = N.VLR_DESCONTO + :NEW.VLR_DESCONTO\n     WHERE N.DIE_NFE_CONVENIO_ID = :NEW.DIE_NFE_CONVENIO_ID;  \n   \n   END IF; \n\n   IF :NEW.ISACTIVE ='N' AND :OLD.ISACTIVE = 'Y' THEN\n     \n     UPDATE DIE_NFE_CONVENIO N SET \n       N.VLR_TOTAL = N.VLR_TOTAL - :NEW.VALOR ,\n       N.QTDE      = N.QTDE - 1,\n       N.VLR_DESCONTO = N.VLR_DESCONTO - :NEW.VLR_DESCONTO\n     WHERE N.DIE_NFE_CONVENIO_ID = :NEW.DIE_NFE_CONVENIO_ID;  \n   \n   END IF;\n\nEND;\n"}`;
    
    }
}
