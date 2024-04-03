
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_WF_NODE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_WF_NODE_ID { get; set; }
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
        public int AD_WORKFLOW_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCENTRALLYMAINTAINED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_WINDOW_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int WORKFLOW_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TASK_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PROCESS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_FORM_ID { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int XPOSITION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int YPOSITION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_WF_BLOCK_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUBFLOWEXECUTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string STARTMODE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FINISHMODE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int LIMIT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRIORITY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DURATION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int COST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int WORKINGTIME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int WAITINGTIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_WF_RESPONSIBLE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_IMAGE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string JOINELEMENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SPLITELEMENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int WAITTIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ATTRIBUTENAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ATTRIBUTEVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCACTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DYNPRIORITYUNIT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DYNPRIORITYCHANGE { get; set; }

    }
}
