
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CBO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CBO_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
        public string DESCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CBO_PRINCIPAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CBO_CONTATO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_COMEMORATIVA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_CBO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n--  :new.ISACTIVE  := BEG_REMOVE_CE(:new.ISACTIVE);\n  :new.value     := BEG_REMOVE_CE(:new.value);\n  :new.DESCRICAO := BEG_REMOVE_CE(:new.DESCRICAO);\n\nend TRG_BIU_BEG_CBO;\n"}`;
    
    }
}
