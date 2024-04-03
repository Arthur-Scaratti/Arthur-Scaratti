
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CARGA_DIARIO_TMP
    {
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DT_LAN { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_DIARIO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_CLI { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTRAPARTIDA { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DEB_CRE { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_LANCAMENTO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }

    }
}
