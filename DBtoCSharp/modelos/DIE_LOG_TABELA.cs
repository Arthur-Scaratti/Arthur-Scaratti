
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_LOG_TABELA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID DO LOG DE TABELAS
        /// </summary>
        public int DIE_LOG_TABELA_ID { get; set; }
            [Required]
        /// <summary>
        /// EMPRESA
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// FILIAL
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// ATIVO
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// TABELA
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// DATA DE CRIACAO
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// QUEM CRIOU
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// DATA DE ALTERACAO
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// QUEM ALTEROU
        /// </summary>
        public int UPDATEDBY { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// DESCRICAO DO LOG (MENSAGEM)
        /// </summary>
        public string NAME { get; set; }
            [StringLength(30)]
        /// <summary>
        /// Usuario
        /// </summary>
        public string USUARIO { get; set; }

    }
}
