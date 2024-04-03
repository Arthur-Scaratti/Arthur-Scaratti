
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PROTEA_DEVOLUCAO
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_DEVEDOR { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_FILIAL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_DOCUMENTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR_DIVIDA { get; set; }

    }
}
