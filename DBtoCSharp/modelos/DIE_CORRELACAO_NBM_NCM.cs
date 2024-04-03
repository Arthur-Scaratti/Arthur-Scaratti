
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CORRELACAO_NBM_NCM
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_NCM { get; set; }
            [StringLength(55)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_NCM { get; set; }
            [StringLength(12)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_NBM { get; set; }
            [StringLength(55)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_NBM { get; set; }

    }
}
