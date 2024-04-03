
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_WF_NEXTCONDITION
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_WF_NEXTCONDITION_ID { get; set; }
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
        public int AD_WF_NODENEXT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ANDOR { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMN_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string OPERATION { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALUE2 { get; set; }

    }
}
