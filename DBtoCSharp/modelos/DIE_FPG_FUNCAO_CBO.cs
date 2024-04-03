
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FPG_FUNCAO_CBO
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do relacionamento da funcao com o CBO
        /// </summary>
        public int DIE_FPG_FUNCAO_CBO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Filial
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
        /// Data da criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao do registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que efetuou a ultima alteracao no registro
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Id do CBO
        /// </summary>
        public int BEG_CBO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da Funcao
        /// </summary>
        public int BEG_FPG_FUNCAO_ID { get; set; }

    }
}
