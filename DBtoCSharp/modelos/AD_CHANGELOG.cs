
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_CHANGELOG
    {
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
        public int RECORD_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OLDVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string NEWVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UNDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string REDO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCUSTOMIZATION { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string TRXNAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DESCRIPTION { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CHANGELOG_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMN_ID { get; set; }
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

    }
}
