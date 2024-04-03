
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_AD_RELATORIO_CA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int APP_SESSION { get; set; }
            [StringLength(255)]
        /// <summary>
        /// 
        /// </summary>
        public string FILENAME { get; set; }
            [StringLength(255)]
        /// <summary>
        /// 
        /// </summary>
        public string MIMETYPE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_AD_RELATORIO_CA_ID { get; set; }
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
    [StringLength(1)]
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
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PINSTANCE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_PROCESS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RELATORIO_CLOB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] RELATORIO_BLOB { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string IMPRESSORA { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string APP_USER { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BI_APEX_RELATORIO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n\n  VB_APEX boolean;\n\nbegin\n\n  if :new.APP_USER is not null\n     and INSERTING then\n    --  :new.DOCSTATUS := 'CO';\n    VB_APEX := BEG_PCK_APEX.BEG_FNC_COMPIERE_APEX_TABLE(:new.APP_USER,\n                                                        'BEG_AD_RELATORIO_CA',\n                                                        :new.AD_CLIENT_ID,\n                                                        :new.AD_ORG_ID,\n                                                        :new.CREATED,\n                                                        :new.CREATEDBY,\n                                                        :new.UPDATED,\n                                                        :new.UPDATEDBY,\n                                                        :new.BEG_AD_RELATORIO_CA_ID);\n  end if;\n\nend;\n"}`;
    
    }
}
