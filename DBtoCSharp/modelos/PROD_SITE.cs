
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PROD_SITE
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }

    }
}
