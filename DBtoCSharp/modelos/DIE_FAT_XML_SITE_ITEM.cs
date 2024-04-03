
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_XML_SITE_ITEM
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_XML_SITE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOC_STATUS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_XML_SITE_ITEM_ID { get; set; }
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
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_PEDIDO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ID_ITEM_F1 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ID_PRODUTO_F1 { get; set; }
            [Required]
    [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO_PROD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PRODUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QUANTIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRESENTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VIGENTE_DE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VIGENTE_POR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VIGENTE_AVISTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_GARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRAZO_GARANTIA { get; set; }

    }
}
