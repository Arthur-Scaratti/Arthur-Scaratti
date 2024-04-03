
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VW_CONCILIACAO_CIELO
    {
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTAB_MATRIZ { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string EC_SUBMISS { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_OPERACAO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CD_AUT { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string CARTAO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_DEPOS { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string PC { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string TPC { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_RO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_TRANS { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string VL_PARC { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string VL_TOTAL { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string VL_ANTEC { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_PREV { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string VL_BRUTO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string VL_LIQ { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string VL_ANT_BRU { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string VL_ANT_LIQ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NSU { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string BAN { get; set; }

    }
}
