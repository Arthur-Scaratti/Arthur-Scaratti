
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class LOTE_CLIENTES
    {
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CELULAR { get; set; }
            [StringLength(25)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }

    }
}
