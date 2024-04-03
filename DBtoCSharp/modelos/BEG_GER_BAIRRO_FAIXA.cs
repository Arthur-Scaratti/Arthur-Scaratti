
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_BAIRRO_FAIXA
    {
            [Required]
    [Key]
        /// <summary>
        /// ID da faixe de CEPs do bairro
        /// </summary>
        public int BEG_GER_BAIRRO_FAIXA_ID { get; set; }
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
        /// Seqüência da faixa
        /// </summary>
        public int SEQ_FAIXA { get; set; }
            [Required]
    [StringLength(9)]
        /// <summary>
        /// CEP final da localidade
        /// </summary>
        public string CEP_FIM { get; set; }
            [Required]
    [StringLength(9)]
        /// <summary>
        /// CEP inicial do bairro
        /// </summary>
        public string CEP_INICIO { get; set; }
            [Required]
        /// <summary>
        /// ID do bairro
        /// </summary>
        public int BEG_GER_BAIRRO_ID { get; set; }

    }
}
