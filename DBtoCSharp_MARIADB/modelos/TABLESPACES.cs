
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TABLESPACES
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLESPACE_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string ENGINE { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLESPACE_TYPE { get; set; }
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string LOGFILE_GROUP_NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long EXTENT_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long AUTOEXTEND_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long MAXIMUM_SIZE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public long NODEGROUP_ID { get; set; }
            [StringLength(2048)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLESPACE_COMMENT { get; set; }

}
}
