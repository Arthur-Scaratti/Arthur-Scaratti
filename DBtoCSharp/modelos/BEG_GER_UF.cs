
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_UF
    {
            [Required]
    [Key]
        /// <summary>
        /// ID da UF
        /// </summary>
        public int BEG_GER_UF_ID { get; set; }
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
        /// Código da UF
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Nome da UF
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(9)]
        /// <summary>
        /// CEP inicial da UF
        /// </summary>
        public string CEP_INICIO { get; set; }
            [Required]
    [StringLength(9)]
        /// <summary>
        /// CEP final da UF
        /// </summary>
        public string CEP_FIM { get; set; }
            [Required]
        /// <summary>
        /// ID do país
        /// </summary>
        public int BEG_GER_PAIS_ID { get; set; }

    }
}
