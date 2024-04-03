
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_FILIAL
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// ID da filial geral (*)
        /// </summary>
        public int AD_ORG_ID_GERAL { get; set; }
            [Required]
        /// <summary>
        /// ID da filial Rio Grande do Sul
        /// </summary>
        public int AD_ORG_ID_RS { get; set; }
        
        /// <summary>
        /// ID da filial Santa Catarina
        /// </summary>
        public int AD_ORG_ID_SC { get; set; }

    }
}
