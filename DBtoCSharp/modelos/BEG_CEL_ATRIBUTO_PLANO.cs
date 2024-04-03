
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CEL_ATRIBUTO_PLANO
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do atributo para o plano.
        /// </summary>
        public int BEG_CEL_ATRIBUTO_PLANO_ID { get; set; }
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
        /// Valor do atributo.
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// ID do atributo.
        /// </summary>
        public int BEG_CEL_ATRIBUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do plano.
        /// </summary>
        public int BEG_CEL_PLANO_ID { get; set; }

    }
}
