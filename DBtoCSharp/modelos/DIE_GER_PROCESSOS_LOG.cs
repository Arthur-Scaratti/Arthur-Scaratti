
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_GER_PROCESSOS_LOG
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_PROCESSOS_LOG_ID { get; set; }
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
    [StringLength(400)]
        /// <summary>
        /// Obs. do processamento
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// qtde de registros gerados pelo processo
        /// </summary>
        public int QTD_REG { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Nome do processo
        /// </summary>
        public string NAME { get; set; }

    }
}
