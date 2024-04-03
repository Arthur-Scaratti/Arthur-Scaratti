
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class C_BPARTNER_LOCATION
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_LOCATION_ID { get; set; }
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
        public string ISBILLTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSHIPTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPAYFROM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISREMITTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PHONE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PHONE2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string FAX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISDN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_SALESREGION_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int C_BPARTNER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int C_LOCATION_ID { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string BEG_CPFCNPJ { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string BEG_IE { get; set; }

    }
}
