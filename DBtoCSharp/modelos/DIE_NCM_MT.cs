
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NCM_MT
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_ESTRUTURADO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }

    }
}
