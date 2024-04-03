
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_CONV_REC_LOT_I_LOG
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do registro
        /// </summary>
        public int BEG_VEN_CONV_REC_LOT_I_LOG_ID { get; set; }
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
        /// Ativo (Y/ N)
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data de criacao
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// QUem criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data ultima alteracao registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario ultima alteracao registro
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Id da conveniada
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// Id do titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// Id da pessoa (Cliente)
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Valor titulo
        /// </summary>
        public int VLR_TITULO { get; set; }
        
        /// <summary>
        /// Data emissao titulo
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// Data vecto titulo
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// Id do hearder do lote
        /// </summary>
        public int BEG_VEN_CONV_REC_LOT_ID { get; set; }
        
        /// <summary>
        /// Data de referecia
        /// </summary>
        public string DT_REFERENCIA { get; set; }
        
        /// <summary>
        /// Contrato
        /// </summary>
        public int CONTRATO { get; set; }
        
        /// <summary>
        /// parcela
        /// </summary>
        public int PARCELA { get; set; }

    }
}
