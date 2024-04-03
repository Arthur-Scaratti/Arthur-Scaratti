
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ARQUIVO_COMISSAO
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CD_FILIAL_CONTABIL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_EZA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO_EVENTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }

    }
}
