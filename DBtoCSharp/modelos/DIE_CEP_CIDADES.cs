
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CEP_CIDADES
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
        public string CEP { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO_SUB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CODIGO_IBGE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_LOCAL { get; set; }

    }
}
