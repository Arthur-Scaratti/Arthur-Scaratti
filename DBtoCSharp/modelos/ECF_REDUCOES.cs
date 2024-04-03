
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECF_REDUCOES
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int RED_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ECF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RED_DATA_MOVIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RED_DATA_EMISSAO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string RED_HORA_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RED_CRZ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RED_CRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RED_COO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RED_VENDA_BRUTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RED_TOTAL_MOVIMENTO { get; set; }
        
        /// <summary>
        /// IMPORTADO DO ARQUIVO NO MOMENTO DA LEITURA DA ECF
        /// </summary>
        public int RED_GRANDE_TOTAL { get; set; }
        
        /// <summary>
        /// O APLICATIVO CALCULA PELO PRIMEIRO
        /// </summary>
        public int RED_GRANDE_CALCULADO { get; set; }
        
        /// <summary>
        /// INFORMAR O VALOR DO PRIMEIRO DIA. 
        /// </summary>
        public int RED_GRANDE_TOTAL_INFORMADO { get; set; }
        
        /// <summary>
        /// 1-PENDENTE, 6-CONCLUIDO
        /// </summary>
        public int RED_STATUS { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string RED_STATUS_MENSAGEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int XML_STATUS { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string XML_DADOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string XML_DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int XML_ENVIO_STATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string XML_ENVIO_DATA { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string XML_ENVIO_MSG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RECIBO_STATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RECIBO_DATA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string RECIBO_NUMERO { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string RECIBO_DADOS { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_ECF_REDUCOES { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n:new.red_id := beg_fnc_ad_sequence('ECF_REDUCOES');\n\nend;\n"}`;
    
    }
}
