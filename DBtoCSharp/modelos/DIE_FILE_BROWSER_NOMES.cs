
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FILE_BROWSER_NOMES
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FILE_BROWSER_NOMES_ID { get; set; }
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
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string ARQUIVO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string PROBLEMA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OK { get; set; }

    }
}
