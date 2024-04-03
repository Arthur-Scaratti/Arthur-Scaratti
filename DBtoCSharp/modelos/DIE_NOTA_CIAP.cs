
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NOTA_CIAP
    {
            [Required]
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CFOP { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_CFOP { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string HIST_PADR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_PROD { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string FIL_DEST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALOR_INF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }

    }
}
