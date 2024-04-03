
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VW_COMISSAO_AP
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string QTDE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_VENDA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_BASE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string REPOUSO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR_REP { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR_COMISS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FL { get; set; }
            [StringLength(150)]
        /// <summary>
        /// 
        /// </summary>
        public string VENDEDOR { get; set; }

    }
}
