
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIS_MTZ_DISPOSITIVO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_MTZ_DISPOSITIVO_ID { get; set; }
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
        /// 
        /// </summary>
        public int BEG_VW_FIS_DISP_ICMS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIS_DISP_IPI_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_MATRIZ_TRIBUTARIA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUFRAMA { get; set; }

    }
}
