
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIS_NCM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_NCM_ID { get; set; }
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
        public int BEG_PRD_NCM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_MATRIZ_TRIBUTARIA_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FIS_NCM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\n  cursor C1 is\n    select 1\n      from BEG_PRD_CONTABIL C\n     where C.BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID\n       and C.BEG_PRD_NCM_ID = :new.BEG_PRD_NCM_ID;\n  --\n  WLIXO number;\n  --\nbegin\n  open C1;\n  fetch C1\n    into WLIXO;\n  if C1%notfound and :new.beg_produto_id is not null then\n    RAISE_APPLICATION_ERROR(-20000,\n                            'N?o existe  relacionamento da NCM com o Produto! - Verifique!'||:new.beg_produto_id);\n  end if;\nend TRG_BIU_BEG_FIS_NCM;\n"}`;
    
    }
}
