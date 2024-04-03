
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_TAB
    {
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
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_WINDOW_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int SEQNO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TABLEVEL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSINGLEROW { get; set; }
        
        /// <summary>
        /// Accounting Info
        /// </summary>
        public string ISINFOTAB { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISTRANSLATIONTAB { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISREADONLY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMN_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string HASTREE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string WHERECLAUSE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ORDERBYCLAUSE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string COMMITWARNING { get; set; }
        
        /// <summary>
        /// Process (Report) to start when hitting the Print Button
        /// </summary>
        public int AD_PROCESS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_IMAGE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IMPORTFIELDS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMNSORTORDER_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMNSORTYESNO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSORTTAB { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int INCLUDED_TAB_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string READONLYLOGIC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DISPLAYLOGIC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISINSERTRECORD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISADVANCEDTAB { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_TAB_ID { get; set; }
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

        [NotMapped]
        public string Trigger_TRG_BI_AD_TAB { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n  select Nvl( :new.description, SubStr( c.comments, 1,  255 ) )\n       , Nvl( :new.help,        SubStr( c.comments, 1, 2000 ) )\n    into :new.description\n       , :new.help\n    from user_tab_comments c\n   where c.table_name  = ( select t.tablename\n                             from ad_table t\n                            where t.ad_table_id = :new.ad_table_id );\n\nexception\n  when no_data_found then\n    null;\n  \nend TRG_BI_AD_TAB;\n"}`;
    
    }
}
