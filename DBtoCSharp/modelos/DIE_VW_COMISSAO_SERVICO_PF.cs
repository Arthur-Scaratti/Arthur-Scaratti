
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VW_COMISSAO_SERVICO_PF
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ELEGIVEIS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string QUANT_VENDIDA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PERC_ELEGIVEIS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string TOTAL_COMISSAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_REPOUSO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VLR_POR_GARANTIA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }

    }
}
