
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PEDPARC
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDPARC_ID { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string PARCELA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLPARC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLGARANT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLSEGURO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLTF { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DTVENC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLTF_ORIG { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLPARC_ORIG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDPARC_LOJA_ID { get; set; }

    }
}
