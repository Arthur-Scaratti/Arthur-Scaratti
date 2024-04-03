
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONTA_CONTABIL_BKP
    {
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CD_FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTA1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTA2 { get; set; }

    }
}
