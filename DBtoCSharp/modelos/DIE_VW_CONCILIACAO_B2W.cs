
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VW_CONCILIACAO_B2W
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_FANTASIA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_PEDIDO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_PAGTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ESTORNO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_LIBERACAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_PREVISTA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string LANCAMENTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PEDIDO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PARCELA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string MEIO_PAGTO { get; set; }

    }
}
