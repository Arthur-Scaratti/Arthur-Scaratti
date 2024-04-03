
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PLANOCAIXA_DBF
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CDGRUPO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCONTA { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRAPAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string GERAREZA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRATEIO { get; set; }

    }
}
