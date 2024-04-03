
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_SPC_RETORNO
    {
        
        /// <summary>
        /// Indicativo para gerar divergencia
        /// </summary>
        public string IND_GERA_DIVERGENCIA { get; set; }
        
        /// <summary>
        /// Indicativo para gerar rejeicao
        /// </summary>
        public string IND_GERA_REJEICAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do retorno do SPC
        /// </summary>
        public int BEG_COB_SPC_RETORNO_ID { get; set; }
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
        /// Codigo de retorno do SPC
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
        /// Descricao do rertorno
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// Indicativo de aceito manutenção no SPC
        /// </summary>
        public string IND_ACEITO_SPC { get; set; }

    }
}
