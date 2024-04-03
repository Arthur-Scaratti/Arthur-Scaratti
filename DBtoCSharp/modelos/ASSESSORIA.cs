
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ASSESSORIA
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENTRADA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VECTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FIXO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTATO { get; set; }

    }
}
