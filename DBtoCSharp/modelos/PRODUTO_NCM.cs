
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PRODUTO_NCM
    {
            [StringLength(7)]
        /// <summary>
        /// 
        /// </summary>
        public string PRODUTO { get; set; }
            [StringLength(69)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string GRUPO { get; set; }
            [StringLength(31)]
        /// <summary>
        /// 
        /// </summary>
        public string SUBGRUPO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM_NOVO { get; set; }

    }
}
