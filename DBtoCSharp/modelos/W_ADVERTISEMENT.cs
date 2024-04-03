
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class W_ADVERTISEMENT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int W_ADVERTISEMENT_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSELFSERVICE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int W_CLICKCOUNT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int W_COUNTERCOUNT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALIDFROM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALIDTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMAGEURL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ADTEXT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBPARAM1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBPARAM2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBPARAM3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WEBPARAM4 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PUBLISHSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VERSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }

    }
}
