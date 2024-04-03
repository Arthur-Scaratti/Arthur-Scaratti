
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class T_AD_COLUMN
    {
            [Required]
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
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
        public int VERSION { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
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
        public int AD_TABLE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int FIELDLENGTH { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DEFAULTVALUE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISKEY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISPARENT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISMANDATORY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISUPDATEABLE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string READONLYLOGIC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISIDENTIFIER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTRANSLATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISENCRYPTED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CALLOUT { get; set; }
        
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSELECTIONCOLUMN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ELEMENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PROCESS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ISSYNCDATABASE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISALWAYSUPDATEABLE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COLUMNSQL { get; set; }

    }
}
