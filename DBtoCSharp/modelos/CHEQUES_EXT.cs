
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CHEQUES_EXT
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_CLI { get; set; }

    }
}
