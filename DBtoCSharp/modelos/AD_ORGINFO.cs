
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_ORGINFO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCATION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DUNS { get; set; }
            [Required]
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string TAXID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PA_GOAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SUPERVISOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARENT_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORGTYPE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_WAREHOUSE_ID { get; set; }

    }
}
