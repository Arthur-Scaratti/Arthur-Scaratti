
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NOTION
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_NOTION_ID { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string AD_ORG_ID { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATEDBY { get; set; }
            [Required]
    [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string LINK { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_DEPTO_ADM_ID { get; set; }

    }
}
