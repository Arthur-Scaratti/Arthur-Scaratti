
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECF_REDUCOES_PRODUTOS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int PROD_VALOR_CANCELAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROD_VALOR_TOTAL_LIQUIDO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string PROD_TOTALIZADOR_FISCAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PROD_IND_CANCELAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROD_QUANTIDADE_CANCELADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROD_VALOR_CANCELADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROD_ACRESCIMO_CANCELADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROD_REGRA_CALCULO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int PROD_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int RED_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int RED_COO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RED_ITEM { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string PROD_CODIGO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string PROD_DESCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROD_QTDE { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string PROD_UNIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROD_VALOR_UNITARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROD_VALOR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PROD_VALOR_ACRESCIMO { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_ECF_REDUCOES_PRODUTOS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n:new.prod_id := beg_fnc_ad_sequence('ECF_REDUCOES_PRODUTOS');\n\nend;\n"}`;
    
    }
}
