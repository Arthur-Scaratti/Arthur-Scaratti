
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class R_STATUS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int R_STATUS_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISOPEN { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCLOSED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NEXT_STATUS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATE_STATUS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TIMEOUTDAYS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISWEBCANUPDATE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISFINALCLOSE { get; set; }

    }
}
