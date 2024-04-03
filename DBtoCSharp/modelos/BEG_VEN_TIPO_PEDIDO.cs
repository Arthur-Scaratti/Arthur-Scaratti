
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_TIPO_PEDIDO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_ACEITA_AGRUPAMENTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string DIFAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indica se cliente e consumidor ou nao
        /// </summary>
        public string IND_FINAL { get; set; }
        
        /// <summary>
        /// Tipo de nota para poder determinar o tipo especie
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_USO_LOJA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indica se aceita emissao da filial para ela mesma
        /// </summary>
        public string IND_ACEITA_MESMA_FL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// indica qual o tipo de preco que sera utilizado pela operacao. (1) - Custo Medio, (2) - Preco de Venda
        /// </summary>
        public string TIPO_PRECO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
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
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_TIPO_PEDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string RESERVA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que pedidos deste tipo devem ser considerados para o calculo de necessidade
        /// </summary>
        public string IND_NECESSIDADE_COMPRA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica que pedidos deste tipo devem ser considerados como venda (fora transferencia)
        /// </summary>
        public string IND_VENDA { get; set; }

    }
}
