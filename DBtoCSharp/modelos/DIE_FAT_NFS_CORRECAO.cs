
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_NFS_CORRECAO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_NFS_CORRECAO_ID { get; set; }
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
        
        /// <summary>
        /// Nr de Sequencia do evento
        /// </summary>
        public int NR_EVENTO { get; set; }
        
        /// <summary>
        /// Data da Emissao da Carta
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// Descritivo da correcao
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// ID da nota
        /// </summary>
        public int DIE_FAT_NFS_RET_ID { get; set; }

    }
}
