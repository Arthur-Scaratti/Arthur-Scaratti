
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_FAIXA_LOCALIDADE
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_NU_SEQUENCIAL { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_RAD1_INI { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_SUF1_INI { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_RAD1_FIM { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_SUF1_FIM { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_RAD2_INI { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_SUF2_INI { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_RAD2_FIM { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_SUF2_FIM { get; set; }

    }
}
