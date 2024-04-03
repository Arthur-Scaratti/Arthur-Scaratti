
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class LISTAPRECO
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }

    }
}
