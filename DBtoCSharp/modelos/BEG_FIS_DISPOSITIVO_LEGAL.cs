
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIS_DISPOSITIVO_LEGAL
    {
        
        /// <summary>
        /// percentual para calculo de diferimento do valor do icms
        /// </summary>
        public int PERC_DIF { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_DISPOSITIVO_LEGAL_ID { get; set; }
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
        /// 
        /// </summary>
        public string DESCR_DISP_LEGAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VALIDADE { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_TRIBUTACAO { get; set; }
            [Required]
        /// <summary>
        /// percentual para calculo da reducao da base do icms
        /// </summary>
        public int PERC_REDUCAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_INSCRITO { get; set; }

    }
}
