
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECF_ESTOQUES
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int EST_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LOJA_ID { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string EST_ANOMES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EST_QUANTIDADE_PRODUTOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EST_VALOR_ESTOQUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EST_STATUS { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string EST_STATUS_MENSAGEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int XML_STATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] XML_DADOS { get; set; }
        
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
            [StringLength(1000)]
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
        
        /// <summary>
        /// 
        /// </summary>
        public string RECIBO_DADOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] DADOS { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_ECF_ESTOQUES { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n:new.est_id := beg_fnc_ad_sequence('ECF_ESTOQUES');\n\nend;\n"}`;
    
    }
}
