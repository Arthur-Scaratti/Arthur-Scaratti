
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_LOCALIDADE_DNE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int LOC_NU { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UFE_SG { get; set; }
            [StringLength(72)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_NO { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_IN_SIT { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC_IN_TIPO_LOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LOC_NU_SUB { get; set; }

    }
}
