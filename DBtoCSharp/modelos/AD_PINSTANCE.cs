
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PINSTANCE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PINSTANCE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PROCESS_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int RECORD_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 0 = Error, 1 = Success
        /// </summary>
        public int RESULT { get; set; }
        
        /// <summary>
        /// Not just Error Messages
        /// </summary>
        public string ERRORMSG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }

    }
}
