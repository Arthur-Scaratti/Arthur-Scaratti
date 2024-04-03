
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_TITULO_COBRADOR_JE
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TITULO_COBRADOR_ID { get; set; }
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
        /// 
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
        /// 
        /// </summary>
        public string DT_BAIXA_COBRANCA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_MOTIVO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FUNCIONARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TP_PESSOA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_RELATORIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TPMOV_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_BAIXA_CONTRATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PAGTO_ANT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_MOTIVO_ANT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COB_LOTE_ASSESSORIA_ID { get; set; }

    }
}
