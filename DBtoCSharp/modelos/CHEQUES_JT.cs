
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CHEQUES_JT
    {
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }

    }
}
