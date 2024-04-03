
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_SUPRIMENTO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do produto suprimento
        /// </summary>
        public int BEG_PRD_SUPRIMENTO_ID { get; set; }
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
        /// Numero de meses de garantia do fabricante
        /// </summary>
        public int NRO_MESES_GARANTIA { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Descric?o detalhada
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// Descric?o resumida
        /// </summary>
        public string DESC_RESUMIDA { get; set; }
        
        /// <summary>
        /// ID do comprador
        /// </summary>
        public int BEG_CPR_COMPRADOR_ID { get; set; }
        
        /// <summary>
        /// ID da unidade do produto
        /// </summary>
        public int BEG_PRD_UNIDADE_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID da classificac?o de suprimento
        /// </summary>
        public int BEG_PRD_SUPRIMENTO_CLASS_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_PRD_SUPRIMENTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n  -- Atualiza a descric?o do produto SUPRIMENTO\n  select NVL(:new.DESC_RESUMIDA, DESC_RESUMIDA),\n         NVL(:new.name, name)\n    into :new.DESC_RESUMIDA,\n         :new.name\n    from BEG_PRODUTO\n   where BEG_PRODUTO_ID = :new.BEG_PRODUTO_ID;\n\nend TRG_BIU_BEG_PRD_SUPRIMENTO;\n"}`;
    
    }
}
