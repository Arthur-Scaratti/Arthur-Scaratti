
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CEP_F52
    {
            [StringLength(44)]
        /// <summary>
        /// 
        /// </summary>
        public string N_LOGRADOU { get; set; }
            [StringLength(23)]
        /// <summary>
        /// 
        /// </summary>
        public string N_BAIRRO { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string N_LOCALIDA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string N_UF { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string N_CEP { get; set; }

    }
}
