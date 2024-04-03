
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TFLASHBACK
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_MENU_ID { get; set; }
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
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSUMMARY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSOTRX { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISREADONLY { get; set; }
        
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
        public int AD_WORKFLOW_ID { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_WORKBENCH_ID { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }

    }
}
