
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VENDA_POR_EVENTO
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_VEND { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO_EVENTO { get; set; }

    }
}
