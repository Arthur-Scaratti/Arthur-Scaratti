
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_LOTE_ASSESSORIA_TIT
    {
            [Required]
    [Key]
        /// <summary>
        /// Id dos titulos lote assessoria - remessa
        /// </summary>
        public int BEG_COB_LOTE_ASSESSORIA_TIT_ID { get; set; }
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
            [Required]
        /// <summary>
        /// Id do lote assessoria
        /// </summary>
        public int BEG_COB_LOTE_ASSESSORIA_ID { get; set; }
            [Required]
        /// <summary>
        /// id do parceiro comercial
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// Id do tipo de movimento  de contas
        /// </summary>
        public int BEG_CRC_TPMOV_ID { get; set; }
        
        /// <summary>
        /// Valor do titulo - em aberto
        /// </summary>
        public int VLR_TITULO { get; set; }
        
        /// <summary>
        /// valor do movimento
        /// </summary>
        public int VLR_MOVTO { get; set; }
        
        /// <summary>
        /// data do pagamento
        /// </summary>
        public string DT_PGTO { get; set; }
        
        /// <summary>
        /// id do codigo de retorno da cobranca
        /// </summary>
        public int BEG_COB_COBR_RETORNO_ID { get; set; }
            [StringLength(200)]
        /// <summary>
        /// descricao completa do retorno da cobranca
        /// </summary>
        public string DESC_RETORNO_COBR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Reflexo esperado na Cobrança
        /// </summary>
        public string REFLEXO_COBR { get; set; }

    }
}
