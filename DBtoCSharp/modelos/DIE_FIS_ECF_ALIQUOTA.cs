
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIS_ECF_ALIQUOTA
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do registro
        /// </summary>
        public int DIE_FIS_ECF_ALIQUOTA_ID { get; set; }
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
        /// Ativo
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data criação
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Quem Criou
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data alteração
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Quem Alterou
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// Codigo do ecf - posicao da memoria fiscal
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Aliquota de ICMS
        /// </summary>
        public int ALIQUOTA_ICMS { get; set; }

    }
}
