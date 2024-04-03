
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_LOCALIDADE
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_NU_SEQUENCIAL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_NOSUB { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_NO { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_SG { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_IN_SITUACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_IN_TIPO_LOCALIDADE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_NU_SEQUENCIAL_SUB { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_KEY_DNE { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string TEMP { get; set; }

    }
}
