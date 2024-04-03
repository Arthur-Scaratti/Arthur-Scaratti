
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRD_CARGA_PRODUTO_NCM
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string PRODUTO { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUAÇÃO { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string GRUPO { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string SUBGRUPO { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM_CORRETO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }

    }
}
