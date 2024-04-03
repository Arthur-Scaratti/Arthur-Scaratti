
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COBRADOR_FILIAL_BKP
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COBRADOR_FILIAL_ID { get; set; }
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
        /// 
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CODFIL { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string APP_USER { get; set; }

    }
}
