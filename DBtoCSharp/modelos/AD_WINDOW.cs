
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AD_WINDOW
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_WINDOW_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string WINDOWTYPE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISSOTRX { get; set; }
            [Required]
    [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTITYTYPE { get; set; }
        
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
        public int AD_COLOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISDEFAULT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int WINHEIGHT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int WINWIDTH { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ISBETAFUNCTIONALITY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string BEG_STATUS_APLICACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_STATUS_APLICACAO { get; set; }

        [NotMapped]
        public string Trigger_TRG_BI_AD_WINDOW { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n  select Nvl( :new.description, SubStr( comments, 1,  255 ) )\n       , Nvl( :new.help,        SubStr( comments, 1, 2000 ) )\n    into :new.description\n       , :new.help\n    from user_tab_comments\n   where table_name = Upper( :new.name );\n\nexception\n  when no_data_found then\n    null;\n  \nend TRG_BI_AD_WINDOW;\n"}`;
    
    }
}
