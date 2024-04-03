
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DDD_MUNICIPIO
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string MUNICIPIO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD { get; set; }
            [Required]
    [StringLength(10)]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_LOCALIDADE { get; set; }

    }
}
