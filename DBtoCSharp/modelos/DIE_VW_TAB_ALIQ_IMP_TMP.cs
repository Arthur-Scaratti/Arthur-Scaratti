
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VW_TAB_ALIQ_IMP_TMP
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESP1 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESP2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_NACIONAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ALIQ_IMPORTADO { get; set; }

    }
}
