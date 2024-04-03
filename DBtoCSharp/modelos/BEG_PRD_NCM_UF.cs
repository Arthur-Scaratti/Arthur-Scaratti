
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_NCM_UF
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do registro
        /// </summary>
        public int BEG_PRD_NCM_UF_ID { get; set; }
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
        /// % margem valor agregado original do estado de destino
        /// </summary>
        public int PERC_MVAO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// Protocolo do MVA
        /// </summary>
        public string PROTOCOLO_MVAO { get; set; }
            [Required]
        /// <summary>
        /// Id do estado de destino
        /// </summary>
        public int BEG_UF_ID { get; set; }
            [Required]
        /// <summary>
        /// id da NCM relacionada
        /// </summary>
        public int BEG_PRD_NCM_ID { get; set; }
        
        /// <summary>
        /// Data do protocolo do MVA
        /// </summary>
        public string DT_PROTOCOLO { get; set; }
        
        /// <summary>
        /// Aliquota interna do estado de destino
        /// </summary>
        public int ALIQ_ICMS_INTERNA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }

    }
}
