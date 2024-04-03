
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BANCO
    {
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }

    }
}
