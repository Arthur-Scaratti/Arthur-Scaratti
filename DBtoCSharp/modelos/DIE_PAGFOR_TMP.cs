
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PAGFOR_TMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PAGTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_RECEBIDO { get; set; }

    }
}
