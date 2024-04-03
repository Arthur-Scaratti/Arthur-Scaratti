
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_LOTE_SPC_TIT
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_COB_SPC_RETORNO_ID { get; set; }
            [StringLength(200)]
        /// <summary>
        /// Descricao completa do retorno do SPC/CDL/POA
        /// </summary>
        public string DESC_RETORNO_CDL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do lote de titulo  SPC
        /// </summary>
        public int BEG_COB_LOTE_SPC_TIT_ID { get; set; }
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
        
        /// <summary>
        /// Sequencia de transacao de envio ao SPC
        /// </summary>
        public int SEQ_TRANSACAO { get; set; }
            [Required]
        /// <summary>
        /// Id do Lote de envio ao SPC
        /// </summary>
        public int BEG_COB_LOTE_SPC_ID { get; set; }
        
        /// <summary>
        /// Id do Retorno do Lote enviado ao SPC
        /// </summary>
        public int BEG_COB_SPC_RETORNO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do titulo no controle do SPC
        /// </summary>
        public int BEG_COB_TITULO_SPC_ID { get; set; }
            [Required]
        /// <summary>
        /// Indica a operacao realizada 1.Inclusao 2.Alteracao 3.Exclusao
        /// </summary>
        public int IND_OPERACAO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// Descricao completa do retorno do SPC/FCDL
        /// </summary>
        public string DESC_RETORNO_SPC { get; set; }

    }
}
