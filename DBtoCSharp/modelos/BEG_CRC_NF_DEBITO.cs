
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_NF_DEBITO
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_NF_DEBITO_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CLIENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_PREPOSTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FATURAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_PARCELAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOTAL_NFS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_TITULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IMPRIMIR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_MENSAGEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_GER_MSG_EX_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_GER_MSG_JRS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAS_PROTESTO { get; set; }

    }
}
