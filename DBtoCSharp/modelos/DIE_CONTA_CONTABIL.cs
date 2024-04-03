
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONTA_CONTABIL
    {
            [Required]
    [StringLength(3)]
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
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF1 { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF2 { get; set; }

    }
}
