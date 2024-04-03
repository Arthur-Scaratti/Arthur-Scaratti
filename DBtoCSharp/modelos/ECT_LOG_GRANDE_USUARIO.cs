
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_GRANDE_USUARIO
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string GRU_NU_SEQUENCIAL { get; set; }
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
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOG_NU_SEQUENCIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string BAI_NU_SEQUENCIAL { get; set; }
            [StringLength(96)]
        /// <summary>
        /// 
        /// </summary>
        public string GRU_NO { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string GRU_ENDERECO { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string GRU_KEY_DNE { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string TEMP { get; set; }

    }
}
