
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_TP_PES_REL
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do tipo de pessoa relacionada
        /// </summary>
        public int BEG_GER_TP_PES_REL_ID { get; set; }
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
        /// ativo - sim ou não
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data da criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Quem fez a criacao do registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao do registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Quem fez a ultima alteracao do registro
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// Identificador do tipo de pessoa - (3 posicoes)
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Descricao do tipo de pessoa relacionada
        /// </summary>
        public string NAME { get; set; }

    }
}
