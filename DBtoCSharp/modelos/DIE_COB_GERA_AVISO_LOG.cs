
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_COB_GERA_AVISO_LOG
    {
            [Required]
    [Key]
        /// <summary>
        /// Id da geracao dos avisos LOG
        /// </summary>
        public int DIE_COB_GERA_AVISO_LOG_ID { get; set; }
            [Required]
        /// <summary>
        /// Diementz
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Filial Diementz
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
        /// Nro aviso
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Data da criacao
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Quem Criou
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data ultima alteracao
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Ultimo de alterou
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// qyde de avisos
        /// </summary>
        public int QTDE_AVISO { get; set; }
            [Required]
        /// <summary>
        /// id do aviso
        /// </summary>
        public int BEG_COB_AVISO_ID { get; set; }

    }
}
