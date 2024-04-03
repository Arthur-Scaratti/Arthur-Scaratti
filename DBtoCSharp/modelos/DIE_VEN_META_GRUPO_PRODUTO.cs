
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VEN_META_GRUPO_PRODUTO
    {
            [Required]
        /// <summary>
        /// id do Grupo de produtos
        /// </summary>
        public int DIE_PRD_GRUPO_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do Grupo da Cota
        /// </summary>
        public int DIE_VEN_COTA_GRUPO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id da Meta dos Grupos de Produtos
        /// </summary>
        public int DIE_VEN_META_GRUPO_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// id do Grupo de Meta
        /// </summary>
        public int DIE_VEN_META_GRUPO_ID { get; set; }
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
        /// Valor de meta de venda
        /// </summary>
        public int VLR_META_VENDA { get; set; }

    }
}
