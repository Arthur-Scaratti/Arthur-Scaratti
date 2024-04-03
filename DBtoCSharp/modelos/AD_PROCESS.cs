
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PROCESS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PROCESS_ID { get; set; }
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
        public string VALUE { get; set; }
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
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCEDURENAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISREPORT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISDIRECTPRINT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_REPORTVIEW_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CLASSNAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int STATISTIC_COUNT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int STATISTIC_SECONDS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PRINTFORMAT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WORKFLOWVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_WORKFLOW_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISBETAFUNCTIONALITY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSERVERPROCESS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string JASPERREPORT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BEG_STATUS_APLICACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_STATUS_APLICACAO { get; set; }

    }
}
