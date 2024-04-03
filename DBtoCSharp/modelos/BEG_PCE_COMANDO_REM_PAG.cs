
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PCE_COMANDO_REM_PAG
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do comando de remssa de pagamento
        /// </summary>
        public int BEG_PCE_COMANDO_REM_PAG_ID { get; set; }
            [Required]
        /// <summary>
        /// Client
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Organization
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo s/n
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// Codigo secundario - referente ao banco
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Data criacao
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// criado por
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// alterado em
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Alterado por
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Descricao do comando de remessa de pagaento
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// ID do banco
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// Tipo do valor - nullo, (E)missao ou valor (A)berto
        /// </summary>
        public string TP_VALOR { get; set; }

    }
}
