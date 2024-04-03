
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PROD_PROMO
    {
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO_LIST { get; set; }

    }
}
