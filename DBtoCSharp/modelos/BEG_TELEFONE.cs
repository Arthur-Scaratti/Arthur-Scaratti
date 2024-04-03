
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_TELEFONE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TELEFONE_ID { get; set; }
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
        public int DDD { get; set; }
            [Required]
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo do telefone  (R)esidencial, c(O)mercial, (F)ax ou (C)elular
        /// </summary>
        public string TP_TELEFONE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AD_BEG_TELEFONE { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  --  pragma autonomous_transaction;\nbegin\n  --\n  insert into DIE_LOG_TABELA\n    (DIE_LOG_TABELA_ID,\n     AD_CLIENT_ID,\n     AD_ORG_ID,\n     ISACTIVE,\n     value,\n     CREATED,\n     CREATEDBY,\n     UPDATED,\n     UPDATEDBY,\n     name,\n     USUARIO,\n     BEG_PESSOA_ID)\n  values\n    (BEG_FNC_AD_SEQUENCE('DIE_LOG_TABELA'),\n     NVL(:old.AD_CLIENT_ID, 1000000), -- AD_CLIENTE_ID\n     NVL(:old.AD_ORG_ID, 0), -- AD_ORG_ID\n     'Y',\n     'BEG_TELEFONE', -- VALUE,\n     sysdate, --CREATED,\n     0, --CREATEDBY,\n     sysdate, --UPDATED,\n     0, --UPDATEDBY,\n     'Telefone elimindo de - Tipo tel. / DDD / Fone : ' || :old.TP_TELEFONE || '(' ||\n     :old.DDD || ') ' || :old.value,\n     user,\n     :old.BEG_PESSOA_ID);\n  --\nend DIE_TRG_AD_BEG_TELEFONE;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_TELEFONE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  if NVL(:new.DDD, 0) > 99 then\n    /*    insert into DIE_LOG_TABELA\n          (DIE_LOG_TABELA_ID,\n           AD_CLIENT_ID,\n           AD_ORG_ID,\n           ISACTIVE,\n           value,\n           CREATED,\n           CREATEDBY,\n           UPDATED,\n           UPDATEDBY,\n           name,\n           USUARIO)\n        values\n          (BEG_FNC_AD_SEQUENCE('DIE_LOG_TABELA'),\n           :new.AD_CLIENT_ID,\n           :new.AD_ORG_ID,\n           'Y',\n           :new.BEG_PESSOA_ID,\n           sysdate, -- CREATED\n           0, --CREATEDBY,\n           sysdate, --UPDATED,\n           0, --UPDATEDBY,\n           'TELEFONE COM DDD MAIOR QUE 99', --NAME,\n           user);\n    */ --\n    :new.DDD := null;         --\n  end if;\n  \n      :new.DDD :=fnc_beg_remove_ce(:new.DDD);\n      :new.VALUE :=fnc_beg_remove_ce(:new.VALUE);\n  \nend DIE_TRG_BIU_BEG_TELEFONE;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_REPL_TELEFONE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"begin\n  --\n  if :new.ISACTIVE = :old.ISACTIVE then\n    if not DELETING then\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    else\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n    end if;\n  end if;\n\nend DIE_TRG_BIUD_REPL_TELEFONE;\n"}`;
    
    }
}
