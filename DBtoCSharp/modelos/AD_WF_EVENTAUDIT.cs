
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_WF_EVENTAUDIT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_WF_EVENTAUDIT_ID { get; set; }
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
        public string EVENTTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string WFSTATE { get; set; }
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
            [Required]
        /// <summary>
        /// AD_Table_ID Definition
        /// </summary>
        public int AD_TABLE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int RECORD_ID { get; set; }
            [Required]
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
        public int ELAPSEDTIMEMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ATTRIBUTENAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OLDVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NEWVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TEXTMSG { get; set; }

    }
}
