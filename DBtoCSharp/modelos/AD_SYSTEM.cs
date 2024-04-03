
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_SYSTEM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_SYSTEM_ID { get; set; }
            [Required]
    [Key]
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
        public string USERNAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string INFO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VERSION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RELEASENO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SUPPORTUNITS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PASSWORD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string REPLICATIONTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IDRANGESTART { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IDRANGEEND { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LDAPHOST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CUSTOMPREFIX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISJUSTMIGRATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DBINSTANCE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DBADDRESS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NOPROCESSORS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUMMARY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENCRYPTIONKEY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LDAPDOMAIN { get; set; }

    }
}
