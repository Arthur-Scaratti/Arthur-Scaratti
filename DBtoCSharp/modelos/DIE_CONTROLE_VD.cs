
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONTROLE_VD
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CONTROLE_VD_ID { get; set; }
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
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VP_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SALDO_VP { get; set; }
            [StringLength(400)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_VEN_REGIAO_ID { get; set; }

    }
}
