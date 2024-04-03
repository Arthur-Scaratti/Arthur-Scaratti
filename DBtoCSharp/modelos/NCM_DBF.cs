
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class NCM_DBF
    {
            [StringLength(17)]
        /// <summary>
        /// 
        /// </summary>
        public string CEST { get; set; }
            [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM_SH { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }

    }
}
