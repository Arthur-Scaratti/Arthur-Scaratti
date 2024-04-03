
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_INSTRUCOES_IMAGENS
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_INSTRUCOES_IMAGENS_ID { get; set; }
            [Required]
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

    }
}
