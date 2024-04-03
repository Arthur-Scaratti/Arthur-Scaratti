
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRD_AVARIA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_AVARIA_ID { get; set; }
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
        /// Data em que ocorreu a avaria
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
    [StringLength(500)]
        /// <summary>
        /// Detalhamento de como ocorreu a avaria
        /// </summary>
        public string DESC_AVARIA { get; set; }
        
        /// <summary>
        /// Data em que foi resolvido a avaria
        /// </summary>
        public string DT_FIM { get; set; }
            [StringLength(500)]
        /// <summary>
        /// Detalhamento da solucao da avaria
        /// </summary>
        public string DESC_SOLUCAO { get; set; }
        
        /// <summary>
        /// id motivo da avaria
        /// </summary>
        public int DIE_PRD_MOTIVO_AVARIA_ID { get; set; }

    }
}
