
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPR_PROJECAO
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMPRA_ORC_SUB { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CPR_PROJECAO_ID { get; set; }
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
        public int DIE_PRD_GRUPO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_SUBGRUPO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_META_SUBGR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMPRA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMPRA_ORC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_FINAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ESTOQUE_FL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_META_GRUPO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ESTOQUE { get; set; }

    }
}
