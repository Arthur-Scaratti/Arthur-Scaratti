
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_TABLE
    {
            [Required]
    [Key]
        /// <summary>
        /// AD_Table_ID Definition
        /// </summary>
        public int AD_TABLE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string HELP { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLENAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISVIEW { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ACCESSLEVEL { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_WINDOW_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_VAL_RULE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LOADSEQ { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSECURITYENABLED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDELETEABLE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISHIGHVOLUME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMPORTTABLE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISCHANGELOG { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string REPLICATIONTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PO_WINDOW_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BI_AD_TABLE { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n  select Nvl( :new.description, SubStr( comments, 1,  255 ) )\n       , Nvl( :new.help,        SubStr( comments, 1, 2000 ) )\n    into :new.description\n       , :new.help\n    from user_tab_comments\n   where table_name = Upper( :new.tablename );\n\nexception\n  when no_data_found then\n    null;\n  \nend TRG_BI_AD_TABLE;\n"}`;
    
    }
}
