
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TIPO_RUA
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string ABREV { get; set; }

    }
}
