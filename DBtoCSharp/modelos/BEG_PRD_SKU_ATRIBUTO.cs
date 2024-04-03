
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_SKU_ATRIBUTO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do atributo por SKU
        /// </summary>
        public int BEG_PRD_SKU_ATRIBUTO_ID { get; set; }
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
    [StringLength(1)]
        /// <summary>
        /// Indica obrigatoriedade da informação em notas de entrada
        /// </summary>
        public string IND_ENTRADA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica obrigatoriedade da informação em notas de saida
        /// </summary>
        public string IND_SAIDA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica obrigatoriedade da informação em ordens de compra
        /// </summary>
        public string IND_ORDEM_COMPRA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica de obrigatoriedade da informação em pedidos de venda
        /// </summary>
        public string IND_PEDIDO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que mantém histórico de movimentação
        /// </summary>
        public string IND_HISTORICO { get; set; }
            [Required]
        /// <summary>
        /// ID do atributo
        /// </summary>
        public int BEG_PRD_ATRIBUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do SKU
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }

    }
}
