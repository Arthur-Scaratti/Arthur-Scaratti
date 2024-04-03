
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_LOGRADOURO
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_NU_SEQUENCIAL { get; set; }
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
            [StringLength(70)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_NO { get; set; }
            [StringLength(125)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_NOME { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string BAI_NU_SEQUENCIAL_INI { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string BAI_NU_SEQUENCIAL_FIM { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_COMPLEMENTO { get; set; }
            [StringLength(72)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_TIPO_LOGRADOURO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_STATUS_TIPO_LOG { get; set; }
            [StringLength(70)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_NO_SEM_ACENTO { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_KEY_DNE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_UOP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_GRU { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string TEMP { get; set; }

    }
}
