
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_TITULO_COBRADOR_HIST
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_BAIXA_COBRANCA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_MOTIVO { get; set; }
        
        /// <summary>
        /// Id do tipo de movimento da baixa
        /// </summary>
        public int BEG_CRC_TPMOV_ID { get; set; }
        
        /// <summary>
        /// Indica que é para baixar todo o contrato do cobrador ref. este titulo 
        /// </summary>
        public string IND_BAIXA_CONTRATO { get; set; }
        
        /// <summary>
        /// Data de pagamento anterior
        /// </summary>
        public string DT_PAGTO_ANT { get; set; }
        
        /// <summary>
        /// Id do motivo anterior - beg_crc_tpmov_id
        /// </summary>
        public int ID_MOTIVO_ANT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TITULO_COBRADOR_HIST_ID { get; set; }
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
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENVIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_COBRANCA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_BAIXA_COBRANCA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ENVIADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PAGTO { get; set; }
        
        /// <summary>
        /// Campo destivado - aok - 26/03/2007
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_RENEGOCIADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COB_LOTE_COBR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTRATO { get; set; }
        
        /// <summary>
        /// id do tipo do titulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// aoK - 30/03/2007
        /// </summary>
        public string IND_ABERTO { get; set; }
        
        /// <summary>
        /// Identifica que o titulo eh de um funcionario
        /// </summary>
        public string FUNCIONARIO { get; set; }
        
        /// <summary>
        /// Identifica o titpo da pessoa (F)isica ou (J)uridica
        /// </summary>
        public string TP_PESSOA { get; set; }
        
        /// <summary>
        /// Indica se a ficha do cobrador foi impressa
        /// </summary>
        public string IND_RELATORIO { get; set; }
        
        /// <summary>
        /// Id do Cobrador
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// Id da Cidade
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }

    }
}
