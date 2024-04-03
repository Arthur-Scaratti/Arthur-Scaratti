
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_IMPFORMAT_ROW
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_IMPFORMAT_ROW_ID { get; set; }
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
        public int AD_IMPFORMAT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int STARTNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ENDNO { get; set; }
            [Required]
        /// <summary>
        /// (S)tring, (N)umber, (D)ate
        /// </summary>
        public string DATATYPE { get; set; }
        
        /// <summary>
        /// ddMMyy - Java Date Format String
        /// </summary>
        public string DATAFORMAT { get; set; }
            [Required]
        /// <summary>
        /// Default .
        /// </summary>
        public string DECIMALPOINT { get; set; }
            [Required]
        /// <summary>
        /// If number - divide by 100
        /// </summary>
        public string DIVIDEBY100 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CONSTANTVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CALLOUT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SCRIPT { get; set; }

    }
}
