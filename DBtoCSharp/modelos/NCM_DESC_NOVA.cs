
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class NCM_DESC_NOVA
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM_ENT { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_NCM { get; set; }

    }
}
