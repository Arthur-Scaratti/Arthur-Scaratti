
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_ATRIBUTO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do atributo
        /// </summary>
        public int BEG_PRD_ATRIBUTO_ID { get; set; }
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
        /// Codigo do atributo
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Descricao do atributo
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o atributo é um número serial
        /// </summary>
        public string IND_SERIAL { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o atributo é um número seqüencial
        /// </summary>
        public string IND_SEQUENCIAL { get; set; }
            [StringLength(40)]
        /// <summary>
        /// Máscara do atributo
        /// </summary>
        public string DES_MASCARA { get; set; }

    }
}
