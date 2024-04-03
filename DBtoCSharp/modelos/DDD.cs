
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DDD
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCALIDADE_ORIG { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string MUNICIPIO_ORIG { get; set; }
            [StringLength(250)]
        /// <summary>
        /// 
        /// </summary>
        public string LINHA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCALIDADE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string MUNICIPIO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD { get; set; }

    }
}
