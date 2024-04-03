
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class SALDO_MOVEIS
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
        public int QTDE03 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CUSTO03 { get; set; }

    }
}
