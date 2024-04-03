
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_AD_IDX
    {
            [Required]
    [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string COLUMNS { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_AD_IDX_ID { get; set; }
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
    [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_NAME { get; set; }

    }
}
