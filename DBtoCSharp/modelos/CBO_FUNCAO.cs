
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CBO_FUNCAO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int CBO_FUNCAO_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ITEM { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CBO { get; set; }

    }
}
