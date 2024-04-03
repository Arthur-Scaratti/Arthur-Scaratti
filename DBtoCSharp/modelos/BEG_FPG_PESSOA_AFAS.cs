
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FPG_PESSOA_AFAS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FPG_PESSOA_AFAS_ID { get; set; }
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
        /// ID do funcionário.
        /// </summary>
        public int BEG_FPG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do afastamento.
        /// </summary>
        public int BEG_FPG_AFASTAMENTO_ID { get; set; }
            [Required]
        /// <summary>
        /// Data de início do afastamento.
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// Data de término do afastamento.
        /// </summary>
        public string DT_FINAL { get; set; }
        
        /// <summary>
        /// Situação do funcionário após o afastamento.
        /// </summary>
        public int BEG_FPG_SITUACAO_ID { get; set; }
        
        /// <summary>
        /// Número de dias do afastamento.
        /// </summary>
        public int NRO_DIAS { get; set; }

    }
}
