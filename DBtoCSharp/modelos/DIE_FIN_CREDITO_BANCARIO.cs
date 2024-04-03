
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_CREDITO_BANCARIO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CREDITO_BANCARIO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
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
        /// 
        /// </summary>
        public string DATA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_CONTA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_MOVIMENTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }

    }
}
