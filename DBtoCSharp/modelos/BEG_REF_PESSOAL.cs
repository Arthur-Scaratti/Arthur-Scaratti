
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_REF_PESSOAL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_REF_PESSOAL_ID { get; set; }
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
    [StringLength(200)]
        /// <summary>
        /// Nome da pessoa que sera referencia
        /// </summary>
        public string NOME { get; set; }
            [Required]
    [StringLength(15)]
        /// <summary>
        /// Fone da pessoa
        /// </summary>
        public string FONE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_PESSOAL_CE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n\n\n      :new.nome :=fnc_beg_remove_ce(:new.nome);\n      :new.fone :=fnc_beg_remove_ce(:new.fone);\n\n\n\nend DIE_TRG_BIU_BEG_PESSOAL_CE;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_REPL_REF_PESS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"begin\n\n  -- Somente quando a situacao do registro não tiver sido alterada\n  if :new.ISACTIVE = :old.ISACTIVE then\n    if not DELETING\n       and :new.ISACTIVE = :old.ISACTIVE then\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    else\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n    end if;\n  end if;\n\nend DIE_TRG_BIUD_REPL_REF_PESS;\n"}`;
    
    }
}
