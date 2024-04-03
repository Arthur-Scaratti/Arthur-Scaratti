
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_CPC
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CPC_NU_SEQUENCIAL { get; set; }
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
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(96)]
        /// <summary>
        /// 
        /// </summary>
        public string CPC_NO { get; set; }
            [StringLength(108)]
        /// <summary>
        /// 
        /// </summary>
        public string CPC_ENDERECO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CPC_TIPO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CPC_ABRANGENCIA { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string CPC_KEY_DNE { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string TEMP { get; set; }

    }
}
