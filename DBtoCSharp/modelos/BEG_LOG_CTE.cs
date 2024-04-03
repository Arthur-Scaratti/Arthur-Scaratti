
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_LOG_CTE
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_LOG_CTE_ID { get; set; }
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
            [StringLength(45)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_ACESSO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_CONHECIMENTO { get; set; }
            [StringLength(280)]
        /// <summary>
        /// 
        /// </summary>
        public string MENSAGEM { get; set; }

    }
}
