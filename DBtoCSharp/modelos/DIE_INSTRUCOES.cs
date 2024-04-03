
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_INSTRUCOES
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_INSTRUCOES_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] DOCUMENTO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string FILENAME { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string MIMETYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ATUALIZACAO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string SETOR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_MATRIZ { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string RESUMO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Y - indica que somente usuario do gerente ira acessar
        /// </summary>
        public string IND_GERENCIAL { get; set; }

    }
}
