
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPR_TIPO_ORDEM
    {
            [Required]
    [Key]
        /// <summary>
        /// ID do tipo de ordem
        /// </summary>
        public int BEG_CPR_TIPO_ORDEM_ID { get; set; }
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
        /// <summary>
        /// Codigo do tipo de ordem
        /// </summary>
        public int VALUE { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// Descric?o do tipo de ordem
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// ID do almoxarifado de destino
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }

    }
}
