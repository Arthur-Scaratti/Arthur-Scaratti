
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class SMS
    {
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }

    }
}
