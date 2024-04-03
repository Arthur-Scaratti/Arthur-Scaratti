
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PLANOCONTAS0091
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string ACESSO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIFICADOR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_CONTA { get; set; }

    }
}
