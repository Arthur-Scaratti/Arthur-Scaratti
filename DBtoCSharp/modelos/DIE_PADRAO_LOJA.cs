
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PADRAO_LOJA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PADRAO_LOJA_ID { get; set; }
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
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SIGLA { get; set; }
            [Required]
    [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_PADRAO_LOJA_UPPER { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n\n\n  :new.sigla := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.sigla));\n  if NVL(:new.descricao, '^') != '^' then\n    :new.descricao := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.descricao));\n  end if;\n\nend DIE_TRG_BIU_PADRAO_LOJA_UPPER;\n"}`;
    
    }
}
