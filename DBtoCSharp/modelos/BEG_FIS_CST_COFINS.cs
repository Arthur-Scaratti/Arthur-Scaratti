
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIS_CST_COFINS
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do CST COFINS
        /// </summary>
        public int BEG_FIS_CST_COFINS_ID { get; set; }
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
    [StringLength(20)]
        /// <summary>
        /// Codigo
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
            [Required]
    [StringLength(150)]
        /// <summary>
        /// Descricao
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// Indica que é para calcular o imposto
        /// </summary>
        public string IND_CALCULA { get; set; }
        
        /// <summary>
        /// Indica (E)ntrada ou (S)aida
        /// </summary>
        public string IND_ENTSAI { get; set; }

    }
}
