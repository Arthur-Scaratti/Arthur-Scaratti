
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PESSOA_ENDERECO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ENDERECO_ID { get; set; }
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
    [StringLength(50)]
        /// <summary>
        /// Endereco da pesso pode ser cobranca, entrega
        /// </summary>
        public string ENDERECO { get; set; }
            [Required]
        /// <summary>
        /// Bairro
        /// </summary>
        public string BAIRRO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string COBRANCA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string TP_ENDERECO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string PONTO_REFERENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_LOGRADOURO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_BEG_PES_EN_CE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n\n\n      :new.BAIRRO :=fnc_beg_remove_ce(:new.BAIRRO);\n      :new.ENDERECO :=fnc_beg_remove_ce(:new.ENDERECO);\n      :new.COMPLEMENTO :=fnc_beg_remove_ce(:new.COMPLEMENTO);\n      :new.PONTO_REFERENCIA :=fnc_beg_remove_ce(:new.PONTO_REFERENCIA);\n\n\n\nend DIE_TRG_BIU_BEG_PES_EN_CE;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AD_BEG_PESSOA_END { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  --\n  --  pragma autonomous_transaction;\n  --\nbegin\n  --\n  insert into DIE_LOG_TABELA\n    (DIE_LOG_TABELA_ID,\n     AD_CLIENT_ID,\n     AD_ORG_ID,\n     ISACTIVE,\n     value,\n     CREATED,\n     CREATEDBY,\n     UPDATED,\n     UPDATEDBY,\n     name,\n     USUARIO,\n     BEG_PESSOA_ID)\n  values\n    (BEG_FNC_AD_SEQUENCE('DIE_LOG_TABELA'),\n     NVL(:old.AD_CLIENT_ID, 1000000), -- AD_CLIENTE_ID\n     NVL(:old.AD_ORG_ID, 0), -- AD_ORG_ID\n     'Y',\n     'BEG_PESSOA_ENDERECO', --VALUE,\n     sysdate, --CREATED,\n     0, --CREATEDBY,\n     sysdate, --UPDATED,\n     0, --UPDATEDBY,\n     :old.BEG_CIDADE_ID || ' ' || :old.CEP || ' ' || :old.TP_ENDERECO || ' ' ||\n     :old.NUMERO || ' ' || :old.COMPLEMENTO || ' ' || :old.PONTO_REFERENCIA || ' ' ||\n     :old.BEG_LOGRADOURO_ID,\n     user,\n     :old.BEG_PESSOA_ID);\n  --\n -- commit;\n  --\nend DIE_TRG_AD_BEG_PESSOA_END;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_REPL_PESS_END { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"begin\n\n  -- Somente quando a situacao não tiver sido alterada\n  if :new.ISACTIVE = :old.ISACTIVE then\n    if not DELETING\n       and :new.ISACTIVE = :old.ISACTIVE then\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    else\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n    end if;\n  end if;\nend DIE_TRG_BIUD_REPL_PESS_END;\n"}`;
    
    }
}
