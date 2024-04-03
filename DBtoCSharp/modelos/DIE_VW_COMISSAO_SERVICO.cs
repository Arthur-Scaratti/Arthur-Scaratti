
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VW_COMISSAO_SERVICO
    {
            [StringLength(150)]
        /// <summary>
        /// 
        /// </summary>
        public string VENDEDOR { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR_REP { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string FL { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }

    }
}
