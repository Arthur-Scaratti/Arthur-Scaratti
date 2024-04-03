
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CEP_LOGRADOUROS
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO_MUN { get; set; }
            [StringLength(120)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CDBAIRRO_INI { get; set; }
            [StringLength(120)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO_INI { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CDBAIRRO_FIM { get; set; }
            [StringLength(120)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO_FIM { get; set; }
            [StringLength(150)]
        /// <summary>
        /// 
        /// </summary>
        public string LOGRADOURO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }

    }
}
