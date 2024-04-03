
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIS_CFOP
    {
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string DIFAL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do codigo fiscal operacional
        /// </summary>
        public int BEG_FIS_CFOP_ID { get; set; }
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
    [StringLength(1)]
        /// <summary>
        /// Indicador de consumidor final
        /// </summary>
        public string IND_CONSUMIDOR { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indicador de inscrito
        /// </summary>
        public string IND_INSCRITO { get; set; }
            [Required]
        /// <summary>
        /// id cod codigo fiscal operacional
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
            [Required]
        /// <summary>
        /// Id da matriza tributaria
        /// </summary>
        public int BEG_FIS_MATRIZ_TRIBUTARIA_ID { get; set; }

    }
}
