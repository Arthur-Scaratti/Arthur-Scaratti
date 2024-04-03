
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_PREPOSTO_FILIAL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_PREPOSTO_FILIAL_ID { get; set; }
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
        public int BEG_VW_PREPOSTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TELEVENDA_ID { get; set; }

    }
}
