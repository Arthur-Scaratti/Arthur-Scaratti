
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_REPLICATION
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_REPLICATION_ID { get; set; }
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
        public string HOSTADDRESS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int HOSTPORT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_REPLICATIONSTRATEGY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISRMIOVERHTTP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IDRANGESTART { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IDRANGEEND { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REMOTE_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int REMOTE_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PREFIX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUFFIX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATELASTRUN { get; set; }

    }
}
