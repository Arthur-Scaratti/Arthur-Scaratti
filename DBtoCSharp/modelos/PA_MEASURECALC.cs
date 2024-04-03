
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PA_MEASURECALC
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int PA_MEASURECALC_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string SELECTCLAUSE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string WHERECLAUSE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATECOLUMN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ORGCOLUMN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BPARTNERCOLUMN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PRODUCTCOLUMN { get; set; }

    }
}
