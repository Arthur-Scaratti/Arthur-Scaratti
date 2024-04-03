
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_PERIODCONTROL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_PERIODCONTROL_ID { get; set; }
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
        public int C_PERIOD_ID { get; set; }
            [Required]
        /// <summary>
        /// C_Reference_ID=183
        /// </summary>
        public string DOCBASETYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PERIODSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PERIODACTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }

    }
}
