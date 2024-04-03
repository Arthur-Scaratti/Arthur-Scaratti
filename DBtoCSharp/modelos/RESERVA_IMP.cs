
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class RESERVA_IMP
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPRODUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }

    }
}
