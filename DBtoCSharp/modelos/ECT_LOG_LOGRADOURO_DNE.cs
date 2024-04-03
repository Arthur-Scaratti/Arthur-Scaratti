
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_LOGRADOURO_DNE
    {
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_STA_TLO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LOG_NU { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_SG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LOC_NU { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BAI_NU_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BAI_NU_FIM { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_NO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_COMPLEMENTO { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(36)]
        /// <summary>
        /// 
        /// </summary>
        public string TLO_TX { get; set; }

    }
}
