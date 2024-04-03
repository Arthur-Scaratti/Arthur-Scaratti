
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONT_TRANSP_SITE_MOV
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CONT_TRANSP_SITE_MOV_ID { get; set; }
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
    [StringLength(10)]
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
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CONTROLE_TRANSP_SITE_ID { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_PEDIDO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_RASTREIO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SEPARADO_DEP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_SEPARADO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CARREGADO_TRANSP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_TRANSP { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGUE_CLI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CLIENTE { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }

    }
}
