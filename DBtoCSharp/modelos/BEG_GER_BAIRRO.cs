
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_BAIRRO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do bairro
        /// </summary>
        public int BEG_GER_BAIRRO_ID { get; set; }
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
        /// Código do bairro
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// Nome do bairro
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// Abreviatura do bairro
        /// </summary>
        public string ABREVIATURA { get; set; }
            [Required]
        /// <summary>
        /// ID da localidade
        /// </summary>
        public int BEG_GER_LOCALIDADE_ID { get; set; }

    }
}
