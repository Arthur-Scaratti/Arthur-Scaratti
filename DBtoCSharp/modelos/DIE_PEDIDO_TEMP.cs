
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PEDIDO_TEMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PROTECAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_FINANCEIRA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEGVEND_ID { get; set; }
            [StringLength(400)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRASSOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLMERC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLGARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CUSTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCEXTRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPOFI { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_TEMP_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPOPESSOA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }

    }
}
