
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_MONTAGEM_ITEM
    {
            [Required]
        /// <summary>
        /// Percentual paga ao cobrador para montagem externa ( OM gerada sobre venda)
        /// </summary>
        public int PERC_MON_EXTERNA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_MONTAGEM_ITEM_ID { get; set; }
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
        public int BEG_FAT_NFS_ITEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_UNITARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_MONTAGEM_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_DIE_FAT_MONTAGEM_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n\n  CURSOR C_PERC IS\n    SELECT F.PERC_MON_EXTERNA\n      FROM DIE_PARAMETROS_FIL F\n     WHERE F.AD_ORG_ID = :NEW.AD_ORG_ID;\n  R_PERC C_PERC%ROWTYPE;\n\nBEGIN\n\n  OPEN C_PERC;\n  FETCH C_PERC\n    INTO R_PERC;\n  CLOSE C_PERC;\n\n  :NEW.PERC_MON_EXTERNA := R_PERC.PERC_MON_EXTERNA;\n\nEND;\n"}`;
    
    }
}
