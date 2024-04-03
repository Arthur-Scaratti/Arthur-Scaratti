
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VW_F1_PEDIDOS
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_PEDIDO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRPEDIDO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NEPEDIDO_ERP { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_PEDIDO_B2W { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PAGAMENTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string QTDE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string RASTREAMENTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CUPOM_UTI { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string PRODUTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_PRODUTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_FRETE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCONTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_PEDIDO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string ENDERECO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NF { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string RES1 { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string RES2 { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string RES3 { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string RES4 { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string RES5 { get; set; }

    }
}
