
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PAIS_2LETRAS
    {
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }

    }
}
