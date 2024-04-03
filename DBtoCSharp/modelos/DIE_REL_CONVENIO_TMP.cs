
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_REL_CONVENIO_TMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION_ID { get; set; }

    }
}
