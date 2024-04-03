
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_XML_SITE_PAG
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_XML_SITE_PAG_ID { get; set; }
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
        public int PARCELAS { get; set; }
            [Required]
    [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string METODO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_XML_SITE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_TAXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VALE { get; set; }

    }
}
