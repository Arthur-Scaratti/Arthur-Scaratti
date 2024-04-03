
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PESSOA_OBS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_OBS_ID { get; set; }
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
    [StringLength(2000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TP_OBS_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_PES_OBS_CE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n\n\n      :new.OBSERVACAO :=fnc_beg_remove_ce(:new.OBSERVACAO);\n\n\nend DIE_TRG_BIU_BEG_PES_OBS_CE;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AD_BEG_PESSOA_OBS { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  --\n  pragma autonomous_transaction;\n  --\n  VC_DESC BEG_TP_OBS.DESCRICAO%type;\n  --\nbegin\n  --\n  VC_DESC := null;\n  select A.DESCRICAO\n    into VC_DESC\n    from BEG_TP_OBS A\n   where A.BEG_TP_OBS_ID = :old.BEG_TP_OBS_ID;\n  --\n  insert into DIE_LOG_TABELA\n    (DIE_LOG_TABELA_ID,\n     AD_CLIENT_ID,\n     AD_ORG_ID,\n     ISACTIVE,\n     value,\n     CREATED,\n     CREATEDBY,\n     UPDATED,\n     UPDATEDBY,\n     name,\n     USUARIO,\n     BEG_PESSOA_ID)\n  values\n    (BEG_FNC_AD_SEQUENCE('DIE_LOG_TABELA'),\n     NVL(:old.AD_CLIENT_ID, 1000000), -- AD_CLIENTE_ID\n     NVL(:old.BEG_FILIAL_ID, 0), -- AD_ORG_ID\n     'Y',\n     'BEG_PESSOA_OBS', --VALUE,\n     sysdate, --CREATED,\n     0, --CREATEDBY,\n     sysdate, --UPDATED,\n     0, --UPDATEDBY,\n     VC_DESC || ' ' || :old.OBSERVACAO,\n     user,\n     :old.BEG_PESSOA_ID);\n  --\n  commit;\n  --\nend DIE_TRG_AD_BEG_PESSOA_OBS;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_REPL_PES_OBS { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"begin\n\n  -- Somente quando a situacao do registro não tiver sido alterada\n  if :new.ISACTIVE = :old.ISACTIVE then\n    if not DELETING\n       and :new.ISACTIVE = :old.ISACTIVE then\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    else\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n    end if;\n  end if;\n\nend DIE_TRG_BIUD_REPL_PES_OBS;\n"}`;
    
    }
}
