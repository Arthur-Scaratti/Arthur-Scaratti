
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRD_NCM
    {
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPRODUTO { get; set; }
            [StringLength(97)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASS_FISC { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string MVA { get; set; }

    }
}
