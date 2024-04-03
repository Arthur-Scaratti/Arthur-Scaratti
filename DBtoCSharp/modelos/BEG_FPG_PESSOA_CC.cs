
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FPG_PESSOA_CC
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FPG_PESSOA_CC_ID { get; set; }
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
        /// ID do funcionário.
        /// </summary>
        public int BEG_FPG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// ID do Centro de Custo.
        /// </summary>
        public int BEG_FPG_CENTRO_CUSTO_ID { get; set; }
            [Required]
        /// <summary>
        /// Data de início no centro de custo.
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// Data de término no centro de custo.
        /// </summary>
        public string DT_FINAL { get; set; }

    }
}
