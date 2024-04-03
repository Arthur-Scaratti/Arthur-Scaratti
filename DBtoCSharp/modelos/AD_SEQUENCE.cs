
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_SEQUENCE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_SEQUENCE_ID { get; set; }
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
    [StringLength(60)]
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
        public string VFORMAT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISAUTOSEQUENCE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INCREMENTNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int STARTNO { get; set; }
            [Required]
        /// <summary>
        /// Only used, if StartNewYear = N
        /// </summary>
        public int CURRENTNEXT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CURRENTNEXTSYS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISAUDITED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISTABLEID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PREFIX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SUFFIX { get; set; }
        
        /// <summary>
        /// Start new for each year with Start
        /// </summary>
        public string STARTNEWYEAR { get; set; }

    }
}
