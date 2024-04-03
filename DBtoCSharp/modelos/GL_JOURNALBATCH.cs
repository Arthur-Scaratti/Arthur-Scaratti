
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class GL_JOURNALBATCH
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int GL_JOURNALBATCH_ID { get; set; }
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
        public string DOCUMENTNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string POSTINGTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int GL_CATEGORY_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEDOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATEACCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_PERIOD_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_CURRENCY_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TOTALDR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TOTALCR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTROLAMT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COPYFROM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_DOCTYPE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DOCACTION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISAPPROVED { get; set; }

    }
}
