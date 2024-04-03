
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CFOP_ENT_SAI
    {
            [Required]
    [Key]
        /// <summary>
        /// ID da relac?o entre CFOP de entrada e CFOP de saida
        /// </summary>
        public int BEG_CFOP_ENT_SAI_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// ID do CFOP (Codigo Fiscal de Operac?es e Prestac?es) de entrada
        /// </summary>
        public int BEG_VW_CFOP_ENT_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do CFOP (Codigo Fiscal de Operac?es e Prestac?es) de saida
        /// </summary>
        public int BEG_VW_CFOP_SAI_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PADRAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }

    }
}
