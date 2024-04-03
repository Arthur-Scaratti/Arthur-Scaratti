
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class R_REQUESTUPDATE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int R_REQUESTUPDATE_ID { get; set; }
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
        public int R_REQUEST_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CONFIDENTIALTYPEENTRY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string STARTTIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENDTIME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTYSPENT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTYINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int M_PRODUCTSPENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RESULT { get; set; }

    }
}
