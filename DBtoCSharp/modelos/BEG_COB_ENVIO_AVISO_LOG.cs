
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_ENVIO_AVISO_LOG
    {
            [Required]
        /// <summary>
        /// Id do log de envio de arquivos
        /// </summary>
        public int BEG_COB_ENVIO_AVISO_LOG_ID { get; set; }
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
        /// ativo
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Numero do aviso
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// Data de criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// ?
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data de alteracao do registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// ?
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Quantidade de avisos
        /// </summary>
        public int QTDE_AVISO { get; set; }
            [Required]
        /// <summary>
        /// Data de envio Biro
        /// </summary>
        public string DT_ENVIO { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// nome do usuario que processou
        /// </summary>
        public string USUARIO { get; set; }
            [Required]
        /// <summary>
        /// Id do aviso
        /// </summary>
        public int BEG_COB_AVISO_ID { get; set; }
            [Required]
        /// <summary>
        /// Indicador de re geracao do arquivo
        /// </summary>
        public string IND_REGERACAO { get; set; }
            [Required]
        /// <summary>
        /// Quantidade de registros com erro
        /// </summary>
        public int QTDE_ERRO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// Observacao sobre o processo
        /// </summary>
        public string OBS { get; set; }

    }
}
