
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIS_COD_MODELO
    {
            [Required]
        /// <summary>
        /// Indica que imposto possui processo diferenciado - informado
        /// </summary>
        public string IND_IMPOSTO_DIFERENCIADO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// id cod.modelo documento fiscal
        /// </summary>
        public int BEG_FIS_COD_MODELO_ID { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// codigo do modelo
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
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [Required]
    [StringLength(80)]
        /// <summary>
        /// descricao do modelo de doc.fiscal
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// indica a obrigatoriedade da chave de acesso
        /// </summary>
        public string IND_CHAVE_ACESSO { get; set; }
        
        /// <summary>
        /// Id do tipo de nota entrada
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }

    }
}
