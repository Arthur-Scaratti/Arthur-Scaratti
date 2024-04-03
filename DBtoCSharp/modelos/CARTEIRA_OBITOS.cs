
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CARTEIRA_OBITOS
    {
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(48)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Y  - encontrado,  N - nao encontrado
        /// </summary>
        public string STATUS { get; set; }

    }
}
