
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_DEPTO_ADM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_DEPTO_ADM_ID { get; set; }
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
        public int VALUE { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }

        [NotMapped]
        public string Trigger_BI_DIE_DEPTO_ADM { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin   \n  if :NEW.\"DIE_DEPTO_ADM_ID\" is null then \n    select \"DIE_DEPTO_ADM_SEQ\".nextval into :NEW.\"DIE_DEPTO_ADM_ID\" from sys.dual; \n    select trim(UPPER(:NEW.\"DESCRICAO\")) into :NEW.\"DESCRICAO\" from sys.dual;\n  end if; \nend; \n"}`;
    
    }
}
