
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_COB_PESQUISA_CDL
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do comparativo da pesquisa SPC/CDL com a base
        /// </summary>
        public int DIE_COB_PESQUISA_CDL_ID { get; set; }
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
        /// Ativo - sim ou não
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data de criação do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Id do usuario que fez a criacao do registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao do registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Id do usuario que fez a ultima alteracao do registro
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da pesquisa SPC / CDL
        /// </summary>
        public string DT_PESQUISA { get; set; }
            [Required]
        /// <summary>
        /// Id da pesquisa 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Id do titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [Required]
    [StringLength(500)]
        /// <summary>
        /// Descricao da divergencia
        /// </summary>
        public string DESC_DIVERGENCIA { get; set; }

    }
}
