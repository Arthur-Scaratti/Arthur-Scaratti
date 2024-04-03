
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_UNID_OPER
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string UOP_NU_SEQUENCIAL { get; set; }
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
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string UOP_NO { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string UOP_ENDERECO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string UOP_IN_CP { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string UOP_KEY_DNE { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string TEMP { get; set; }

    }
}
