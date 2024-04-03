
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_FAIXA_CPC
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CPC_NU_SEQUENCIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CPC_NU_INICIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CPC_NU_FINAL { get; set; }

    }
}
