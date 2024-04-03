
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPR_NFS_VINC_CTE
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CPR_NFS_VINC_CTE_ID { get; set; }
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
        public int BEG_CPR_NFE_ID { get; set; }
            [StringLength(44)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_NFE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL_NOTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE_NOTA { get; set; }

    }
}
