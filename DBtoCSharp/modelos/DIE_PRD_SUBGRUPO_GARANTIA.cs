
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRD_SUBGRUPO_GARANTIA
    {
            [Required]
        /// <summary>
        /// tempo da garantia expresso em anos
        /// </summary>
        public int TEMPO_GARANTIA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do relacionamento entre os subgrupos e garantias estendidas.
        /// </summary>
        public int DIE_PRD_SUBGRUPO_GARANTIA_ID { get; set; }
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
        /// ID do subgrupo.
        /// </summary>
        public int DIE_PRD_SUBGRUPO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID da garantia.
        /// </summary>
        public int DIE_PRD_GARANTIA_ID { get; set; }

    }
}
