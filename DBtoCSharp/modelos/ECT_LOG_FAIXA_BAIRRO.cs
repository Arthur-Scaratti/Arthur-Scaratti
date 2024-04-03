
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_FAIXA_BAIRRO
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string BAI_NU_SEQUENCIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FCB_NU_ORDEM { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string FCB_RAD_INI { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string FCB_SUF_INI { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string FCB_RAD_FIM { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string FCB_SUF_FIM { get; set; }

    }
}
