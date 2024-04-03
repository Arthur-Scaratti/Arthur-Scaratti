
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_LOCALIDADE
    {
            [StringLength(12)]
        /// <summary>
        /// CEP criptografado da base dos correios (coluna temporária)
        /// </summary>
        public string CEP_CRIPTO_ECT { get; set; }
            [Required]
    [StringLength(5)]
        /// <summary>
        /// Código DDD da localidade
        /// </summary>
        public string DDD { get; set; }
            [Required]
        /// <summary>
        /// ID da UF
        /// </summary>
        public int BEG_GER_UF_ID { get; set; }
        
        /// <summary>
        /// ID da localidade de subordinação
        /// </summary>
        public int BEG_VW_GER_LOCALIDADE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da localidade
        /// </summary>
        public int BEG_GER_LOCALIDADE_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// Código da localidade
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Nome da localidade
        /// </summary>
        public string NAME { get; set; }
            [StringLength(4)]
        /// <summary>
        /// Sigla da localidade
        /// </summary>
        public string SIGLA { get; set; }
            [StringLength(9)]
        /// <summary>
        /// CEP geral da localidade
        /// </summary>
        public string CEP { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo da localidade: M - Município / D - Distrito / R - Região Administrativa / P - Povoado
        /// </summary>
        public string IND_TIPO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Situação da localidade: G - CEP geral para localidade / L - CEP por logradouro / I - Distrito ou povoado inserido no CEP por logradouro
        /// </summary>
        public string IND_SITUACAO { get; set; }
            [StringLength(9)]
        /// <summary>
        /// CEP inicial da localidade
        /// </summary>
        public string CEP_INICIO { get; set; }
            [StringLength(9)]
        /// <summary>
        /// CEP final da localidade
        /// </summary>
        public string CEP_FIM { get; set; }

    }
}
