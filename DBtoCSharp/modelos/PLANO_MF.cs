
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PLANO_MF
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string VENDAS { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC1 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CLIENTES { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC2 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CAIXA { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC3 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPRAS { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC4 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string FORNEC { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC5 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPRAPROG { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC6 { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string DEVAVI { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DDEVAVI { get; set; }

    }
}
