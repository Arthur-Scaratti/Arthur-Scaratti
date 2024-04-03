
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PINSTANCE_PARA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string PARAMETERNAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string P_STRING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string P_STRING_TO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int P_NUMBER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int P_NUMBER_TO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string P_DATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string P_DATE_TO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string INFO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string INFO_TO { get; set; }
        
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
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PINSTANCE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }

    }
}
