
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PLANOEZA_DBF
    {
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string GERAREZA { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRAPAR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string GERAFORNEC { get; set; }

    }
}
