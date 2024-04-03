
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_FAIXA_UF
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_SG { get; set; }
            [StringLength(72)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_NO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_RAD1_INI { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_SUF1_INI { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_RAD1_FIM { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_SUF1_FIM { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_RAD2_INI { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_SUF2_INI { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_RAD2_FIM { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_SUF2_FIM { get; set; }

    }
}
