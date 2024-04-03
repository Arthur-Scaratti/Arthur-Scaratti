
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PRINTPAPER
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTPAPER_ID { get; set; }
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
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISLANDSCAPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CODE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MARGINTOP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MARGINLEFT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MARGINRIGHT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MARGINBOTTOM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }

    }
}
