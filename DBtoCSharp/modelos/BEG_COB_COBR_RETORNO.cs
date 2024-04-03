
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_COBR_RETORNO
    {
            [Required]
    [Key]
        /// <summary>
        /// Id retornos da cobranca
        /// </summary>
        public int BEG_COB_COBR_RETORNO_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
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
    [StringLength(200)]
        /// <summary>
        /// Descrição do retorno
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// Indicativo que foi aceito pela cobranca
        /// </summary>
        public string IND_ACEITO_COBR { get; set; }
        
        /// <summary>
        /// id do cobrador
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }

    }
}
