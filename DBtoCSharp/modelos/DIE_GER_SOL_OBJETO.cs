
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_GER_SOL_OBJETO
    {
            [Required]
    [Key]
        /// <summary>
        /// Id da solicitacao x OBJETO
        /// </summary>
        public int DIE_GER_SOL_OBJETO_ID { get; set; }
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
        /// Id da Solicitacao
        /// </summary>
        public int DIE_GER_SOLICITACAO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do Objeto
        /// </summary>
        public int DIE_GER_OBJETO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Situacao (I)nclusao ou (A)lteracao
        /// </summary>
        public string IND_SITUACAO { get; set; }

    }
}
