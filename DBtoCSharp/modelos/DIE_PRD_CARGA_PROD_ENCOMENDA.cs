
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRD_CARGA_PROD_ENCOMENDA
    {
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCIA { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string VOLTAGEM { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string COR { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string PRECO_LISTA { get; set; }

    }
}
