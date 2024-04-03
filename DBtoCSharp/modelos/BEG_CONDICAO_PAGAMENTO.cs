
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CONDICAO_PAGAMENTO
    {
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string FORA_MES { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
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
    [StringLength(100)]
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
        public int PERC_DESCONTO2 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_PAGTO_FIXO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAS_ACRESCIMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_DESCONTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PROXIMO_DIA_UTIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIA_SEMANA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAS_DESCONTO2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAS_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ACRESCIMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ACEITA_RENEG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENTRADA { get; set; }
        
        /// <summary>
        /// Dia de pagamento
        /// </summary>
        public int DIA_PAGAMENTO { get; set; }
        
        /// <summary>
        /// multa
        /// </summary>
        public int MULTA { get; set; }
        
        /// <summary>
        /// Id do tipo de titulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// ???
        /// </summary>
        public int CODIGO { get; set; }
            [Required]
        /// <summary>
        /// Indicativo de destino 
        /// </summary>
        public string IND_DESTINO { get; set; }
        
        /// <summary>
        /// Botao para validacao da condicao de pagamento
        /// </summary>
        public string BTN_VALIDA { get; set; }

    }
}
