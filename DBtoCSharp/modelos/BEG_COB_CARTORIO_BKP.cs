
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_CARTORIO_BKP
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COB_CARTORIO_ID { get; set; }
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
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PROTOCOLO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INTIMACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_SAI_CARTORIO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_PROTOCOLO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_EMOLUMENTO { get; set; }
            [StringLength(600)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DECLARADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string TITULO_PARCELA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TP_DOCUMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_AGENCIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOTIVO_BAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_PROTESTAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CORRIGIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_ALIQUOTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CONTRATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CONTRATO_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string APP_USER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENVIO_LIBERACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENVIO_JURIDICO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string BT_IMPRIME { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_INSTRUMENTO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_LIVRO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_FOLHA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_MICROFILME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_APROV_PROTESTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_DEVOLVIDO { get; set; }

    }
}
