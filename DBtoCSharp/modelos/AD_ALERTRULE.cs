
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_ALERTRULE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ALERTRULE_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ALERT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SELECTCLAUSE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string FROMCLAUSE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WHERECLAUSE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PREPROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string POSTPROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVALID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ERRORMSG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OTHERCLAUSE { get; set; }

    }
}
