
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class NCM_CONVERSAO
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM_SAIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NCM_SAIDA_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NCM_ENT_ID { get; set; }
            [StringLength(2000)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_NCM_ENT { get; set; }

    }
}
