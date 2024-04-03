
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_PROCESS_PARA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PROCESS_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_REFERENCE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_REFERENCE_VALUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_VAL_RULE_ID { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string COLUMNNAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCENTRALLYMAINTAINED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int FIELDLENGTH { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMANDATORY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISRANGE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DEFAULTVALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DEFAULTVALUE2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VFORMAT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALUEMIN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string VALUEMAX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ELEMENT_ID { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PROCESS_PARA_ID { get; set; }
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

    }
}
