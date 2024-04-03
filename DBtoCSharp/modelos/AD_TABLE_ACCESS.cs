
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_TABLE_ACCESS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ROLE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string ACCESSTYPERULE { get; set; }
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
        public int UPDATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISREADONLY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCANREPORT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCANEXPORT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISEXCLUDE { get; set; }

    }
}
