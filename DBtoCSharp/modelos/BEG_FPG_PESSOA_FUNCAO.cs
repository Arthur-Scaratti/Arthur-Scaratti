
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FPG_PESSOA_FUNCAO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FPG_PESSOA_FUNCAO_ID { get; set; }
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
        /// ID do Funcionário.
        /// </summary>
        public int BEG_FPG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// ID da Função.
        /// </summary>
        public int BEG_FPG_FUNCAO_ID { get; set; }
            [Required]
        /// <summary>
        /// Data de início da função.
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// Data de término da função.
        /// </summary>
        public string DT_FINAL { get; set; }

    }
}
