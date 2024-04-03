
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ITEPRO
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(7)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPRODUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTINICIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRPREST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLPREST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCEXTRA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALORFIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PLANOFIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRESTFIN { get; set; }

    }
}
