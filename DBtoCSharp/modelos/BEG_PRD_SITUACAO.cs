
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_SITUACAO
    {
            [Required]
    [StringLength(10)]
        /// <summary>
        /// Código da situação
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que será gerado arquivo de catálogo para produtos nessa situação
        /// </summary>
        public string GERA_CATALOGO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID da situação
        /// </summary>
        public int BEG_PRD_SITUACAO_ID { get; set; }
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
    [StringLength(30)]
        /// <summary>
        /// Descrição da situação
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// Indica que serão geradas compras para produtos nessa situação
        /// </summary>
        public string GERA_COMPRA { get; set; }
            [Required]
        /// <summary>
        /// Indica que será gerado arquivo para o Palm para produtos nessa situação
        /// </summary>
        public string GERA_PALM { get; set; }
            [Required]
        /// <summary>
        /// Indica que será gerado arquivo de faltas para produtos nessa situação
        /// </summary>
        public string GERA_FALTA { get; set; }
            [Required]
        /// <summary>
        /// Indica que será gerado inventário para produtos nessa situação
        /// </summary>
        public string GERA_INVENTARIO { get; set; }

    }
}
