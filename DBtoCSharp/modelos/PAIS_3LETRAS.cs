
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PAIS_3LETRAS
    {
            [StringLength(6)]
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
