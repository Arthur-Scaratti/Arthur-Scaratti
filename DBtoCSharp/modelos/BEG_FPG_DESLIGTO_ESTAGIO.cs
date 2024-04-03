
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FPG_DESLIGTO_ESTAGIO
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do motivo desligamento estagiario
        /// </summary>
        public int BEG_FPG_DESLIGTO_ESTAGIO_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Filial 
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
    [StringLength(5)]
        /// <summary>
        /// Codigo desligamento conforme tab.CIEE
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(60)]
        /// <summary>
        /// Descricao desligto conforme tab. CIEE
        /// </summary>
        public string NAME { get; set; }

    }
}
