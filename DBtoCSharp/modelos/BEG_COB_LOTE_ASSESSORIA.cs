
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_LOTE_ASSESSORIA
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do lote para assessoria
        /// </summary>
        public int BEG_COB_LOTE_ASSESSORIA_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Filial (*)
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
        /// id do cobrador - assessoria
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// Nome arquivo de remessa
        /// </summary>
        public string NOME_ARQUIVO { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Status IP - Em prgresso COmpleto
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// Valor das entradas
        /// </summary>
        public int VLR_ENTRADA { get; set; }
        
        /// <summary>
        /// Valor dos pagamentos
        /// </summary>
        public int VLR_PAGAMENTO { get; set; }
        
        /// <summary>
        /// Quantidade total de titulos
        /// </summary>
        public int QTD_TITULOS { get; set; }
        
        /// <summary>
        /// Valor da baixas
        /// </summary>
        public int VLR_BAIXAS { get; set; }
        
        /// <summary>
        /// Valor de cancelamento
        /// </summary>
        public int VLR_CANCELAMENTO { get; set; }

    }
}
