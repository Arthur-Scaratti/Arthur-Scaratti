
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class MVA_NOVO
    {
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CEST { get; set; }
            [StringLength(21)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MVA { get; set; }

    }
}
