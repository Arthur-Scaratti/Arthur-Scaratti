
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECT_LOG_CONTROLE
    {
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string Versao { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Data { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string Compl1 { get; set; }

    }
}
