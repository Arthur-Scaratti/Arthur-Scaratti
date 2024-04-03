
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TOTAL_CARTEIRA_CDL
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO_TITULO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VECTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FILLER { get; set; }

    }
}
