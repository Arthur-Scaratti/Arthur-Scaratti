
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_BAIRRO
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string BAI_NU_SEQUENCIAL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_SG { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_NU_SEQUENCIAL { get; set; }
            [StringLength(72)]
        /// <summary>
        /// 
        /// </summary>
        public string BAI_NO { get; set; }
            [StringLength(36)]
        /// <summary>
        /// 
        /// </summary>
        public string BAI_NO_ABREV { get; set; }

    }
}
