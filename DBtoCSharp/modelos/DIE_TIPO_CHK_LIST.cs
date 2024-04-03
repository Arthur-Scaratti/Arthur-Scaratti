
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_TIPO_CHK_LIST
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do tipo do check list
        /// </summary>
        public int DIE_TIPO_CHK_LIST_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
            [StringLength(400)]
        /// <summary>
        /// Descricao completa
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se é um cabeçalho 
        /// </summary>
        public string IND_PRINCIPAL { get; set; }
        
        /// <summary>
        /// Vinculo com cabeçalho principal
        /// </summary>
        public int DIE_VW_TIPO_CHK_LIST_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Nao utilizado
        /// </summary>
        public string IND_CAPA { get; set; }

    }
}
