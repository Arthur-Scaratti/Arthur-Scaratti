
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class NEW_CEP
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LOGRADOURO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }

    }
}
