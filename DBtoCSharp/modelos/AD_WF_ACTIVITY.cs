
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_WF_ACTIVITY
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_WF_ACTIVITY_ID { get; set; }
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
        public int AD_WF_PROCESS_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_WF_NODE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_WF_RESPONSIBLE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string WFSTATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_MESSAGE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TEXTMSG { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_WORKFLOW_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int RECORD_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRIORITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENDWAITTIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATELASTALERT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DYNPRIORITYSTART { get; set; }

    }
}
