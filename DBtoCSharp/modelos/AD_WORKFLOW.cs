
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_WORKFLOW
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_WORKFLOW_ID { get; set; }
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
        public string ACCESSLEVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_WF_NODE_ID { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DURATIONUNIT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string AUTHOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VERSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALIDFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALIDTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRIORITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIMIT { get; set; }
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
            [Required]
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PUBLISHSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_WORKFLOWPROCESSOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALIDATEWORKFLOW { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string WORKFLOWTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCVALUELOGIC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVALID { get; set; }

    }
}
