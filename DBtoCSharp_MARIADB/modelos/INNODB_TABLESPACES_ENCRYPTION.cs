
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_TABLESPACES_ENCRYPTION
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SPACE { get; set; }
            [StringLength(655)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ENCRYPTION_SCHEME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int KEYSERVER_REQUESTS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int MIN_KEY_VERSION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CURRENT_KEY_VERSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long KEY_ROTATION_PAGE_NUMBER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long KEY_ROTATION_MAX_PAGE_NUMBER { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CURRENT_KEY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ROTATING_OR_FLUSHING { get; set; }

}
}
