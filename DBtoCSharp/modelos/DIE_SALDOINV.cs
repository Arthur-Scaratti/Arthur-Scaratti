
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_SALDOINV
    {
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPRODUTO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE11 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CUSTO11 { get; set; }

    }
}
