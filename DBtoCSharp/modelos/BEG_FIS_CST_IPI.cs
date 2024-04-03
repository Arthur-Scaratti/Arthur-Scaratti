
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIS_CST_IPI
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_IPI_ID { get; set; }
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
        /// codigo
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
    [StringLength(100)]
        /// <summary>
        /// descricao
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// indica (E)entrada ou (S)aida
        /// </summary>
        public string IND_ENTSAI { get; set; }
        
        /// <summary>
        /// indica calculo do imposto
        /// </summary>
        public string IND_CALCULA { get; set; }

    }
}
