
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_LOGO_MARCA_IMAGEM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_LOGO_MARCA_IMAGEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] FOTO { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_LOGO_MARCA_ID { get; set; }

    }
}
