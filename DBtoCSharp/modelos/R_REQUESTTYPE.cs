
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class R_REQUESTTYPE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int R_REQUESTTYPE_ID { get; set; }
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
        public string ISDEFAULT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSELFSERVICE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DUEDATETOLERANCE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISEMAILWHENOVERDUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISEMAILWHENDUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISINVOICED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AUTODUEDATEDAYS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CONFIDENTIALTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISAUTOCHANGEREQUEST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCONFIDENTIALINFO { get; set; }

    }
}
