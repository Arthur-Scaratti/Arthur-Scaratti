
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PEDIDO_ITEM_TEMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_PROMOCAO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TF { get; set; }
            [StringLength(1)]
        /// <summary>
        /// D = Disponivel no CD, P = Previsão de chegada
        /// </summary>
        public string TP_RESERVA { get; set; }
        
        /// <summary>
        /// Data de previsao de chegada do produto no cd quando tp_reserva for P
        /// </summary>
        public string DT_PREV_CHEGADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PREV_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PREV_FIM { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_ITEM_TEMP_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_TEMP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTDEATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLUNITARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_DETALHADA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPGARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_GARANTIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CDVENDAGAR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECOGAR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string MONTAGEM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VALORDESC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERCDESC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRECOFINAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPOPRECO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TPENTREGA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PREVENTREG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTMONTAGEM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_LINHA_PEDIDO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PLANO_CEL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DIE_COD_ESTRUTURADO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BI_PED_ITEM_TEMP { get; set; } = `{"triggering_event":"INSERT","trigger_body":"BEGIN\n\n  IF :NEW.DIE_PEDIDO_ITEM_TEMP_ID IS NULL THEN\n  \n    :NEW.DIE_PEDIDO_ITEM_TEMP_ID := BEG_FNC_AD_SEQUENCE('DIE_PEDIDO_ITEM_TEMP');\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
