
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CHQ_DESTINO_REMESSA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_DESTINO_REMESSA_ID { get; set; }
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
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CAIXA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CONTA_CORRENTE { get; set; }

    }
}
