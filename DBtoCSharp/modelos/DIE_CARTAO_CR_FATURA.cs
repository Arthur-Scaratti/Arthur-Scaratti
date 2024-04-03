
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARTAO_CR_FATURA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_FATURA_ID { get; set; }
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
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FATURA { get; set; }
            [Required]
        /// <summary>
        /// NAO UTILIZA. PORQUE FICA NO HISTORICO
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// data quitacao da fatura
        /// </summary>
        public string DT_PAGTO { get; set; }
            [Required]
        /// <summary>
        /// NAO UTILIZA. PORQUE FICA NO HISTORICO
        /// </summary>
        public int VLR_MULTA { get; set; }
            [Required]
        /// <summary>
        /// NAO UTILIZA. PORQUE FICA NO HISTORICO
        /// </summary>
        public int VLR_JUROS { get; set; }
            [Required]
        /// <summary>
        /// NAO UTILIZA. PORQUE FICA NO HISTORICO
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// NAO UTILIZA. PORQUE FICA NO HISTORICO
        /// </summary>
        public int VLR_TAXAS { get; set; }

    }
}
