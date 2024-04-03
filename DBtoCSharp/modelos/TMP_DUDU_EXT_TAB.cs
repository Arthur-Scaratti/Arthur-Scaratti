
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TMP_DUDU_EXT_TAB
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
