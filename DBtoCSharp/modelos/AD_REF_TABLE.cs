
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_REF_TABLE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_REFERENCE_ID { get; set; }
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
        public int AD_TABLE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_KEY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_DISPLAY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVALUEDISPLAYED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WHERECLAUSE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ORDERBYCLAUSE { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }

    }
}
