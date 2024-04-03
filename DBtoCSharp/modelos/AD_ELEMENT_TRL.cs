
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_ELEMENT_TRL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ELEMENT_ID { get; set; }
            [Required]
    [StringLength(6)]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string AD_LANGUAGE { get; set; }
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
        public string PRINTNAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PO_NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PO_PRINTNAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PO_DESCRIPTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PO_HELP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTRANSLATED { get; set; }

    }
}
