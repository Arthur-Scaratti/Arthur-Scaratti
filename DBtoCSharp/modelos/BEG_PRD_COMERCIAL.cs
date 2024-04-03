
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_COMERCIAL
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CATEGORIA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_COMERCIAL_ID { get; set; }
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
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ALTERA_DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_COMERCIAL_CLASS_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// Descric?o resumida
        /// </summary>
        public string DESC_RESUMIDA { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Descric?o detalhada
        /// </summary>
        public string DESC_DETALHADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GPR_DADOS_VENDA_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_PRD_COMERCIAL { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"BEGIN\n\n  :NEW.CATEGORIA := UPPER(:NEW.CATEGORIA);\n\n  IF :NEW.CATEGORIA NOT IN ('A','B','C') THEN\n    \n    RAISE_APPLICATION_ERROR(-20003,'Somente permitido categorias : A, B e C. ');\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
