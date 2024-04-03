
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_FAIXA_UOP
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string UOP_NU_SEQUENCIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FNC_NU_INICIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FNC_NU_FINAL { get; set; }
            [StringLength(255)]
        /// <summary>
        /// 
        /// </summary>
        public string FNC_IN_TIPO { get; set; }

    }
}
