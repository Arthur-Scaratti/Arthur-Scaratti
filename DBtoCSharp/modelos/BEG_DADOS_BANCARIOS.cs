
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_DADOS_BANCARIOS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_DADOS_BANCARIOS_ID { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_AGENCIA_ID { get; set; }
            [Required]
    [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTA_BANCARIA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DIG_CONTA_BANCARIA { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AD_BEG_DADOS_BANCARIOS { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  --\n  pragma autonomous_transaction;\n  --\nbegin\n  --\n  insert into DIE_LOG_TABELA\n    (DIE_LOG_TABELA_ID,\n     AD_CLIENT_ID,\n     AD_ORG_ID,\n     ISACTIVE,\n     value,\n     CREATED,\n     CREATEDBY,\n     UPDATED,\n     UPDATEDBY,\n     name,\n     USUARIO,\n     BEG_PESSOA_ID)\n  values\n    (BEG_FNC_AD_SEQUENCE('DIE_LOG_TABELA'),\n     NVL(:old.AD_CLIENT_ID, 1000000), -- AD_CLIENTE_ID\n     NVL(:old.AD_ORG_ID, 0), -- AD_ORG_ID\n     'Y',\n     'BEG_DADOS_BANCARIOS', --VALUE,\n     sysdate, --CREATED,\n     0, --CREATEDBY,\n     sysdate, --UPDATED,\n     0, --UPDATEDBY,\n     :old.BEG_BANCO_ID || ' ' || :old.BEG_AGENCIA_ID || ' ' ||\n     :old.CONTA_BANCARIA || ' ' || :old.DIG_CONTA_BANCARIA,\n     user,\n     :old.BEG_PESSOA_ID);\n  --\n  commit;\n  --\nend DIE_TRG_AD_BEG_DADOS_BANCARIOS;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_REPL_DADOS_BAN { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"begin\n\n  if :new.ISACTIVE = :old.ISACTIVE then\n  \n    if not DELETING\n       and :new.ISACTIVE = :old.ISACTIVE then\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    else\n      update BEG_PESSOA\n         set NOME = NOME\n       where BEG_PESSOA_ID = :old.BEG_PESSOA_ID;\n    end if;\n  end if;\nend DIE_TRG_BIUD_REPL_DADOS_BAN;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BIU_DADOS_BANCARIOS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  cursor C_CC_PADRAO is\n    select BEG_DADOS_BANCARIOS_ID\n      from BEG_FIN_INF_PESSOA\n     where BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n  --\n  RCCPAD C_CC_PADRAO%rowtype;\n  --\nbegin\n  --\n  open C_CC_PADRAO;\n  fetch C_CC_PADRAO\n    into RCCPAD;\n  if C_CC_PADRAO%notfound then\n    insert into BEG_FIN_INF_PESSOA\n      (BEG_FIN_INF_PESSOA_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_PESSOA_ID,\n       LIMITE_CREDITO,\n       CREDIT_SCORE,\n       TOT_CRC_ABERTO,\n       TOT_CRC_VENCIDO,\n       MEDIA_ATRASO_CRC,\n       TOT_CPG_ABERTO,\n       TOT_CPG_VENCIDO,\n       TOT_PEDIDO_ABERTO,\n       VLR_LIMITE_INADIMPL,\n       RESTRINGE_TP_COBR,\n       TOT_CRC_ACOMPENSAR,\n       BEG_DADOS_BANCARIOS_ID)\n    values\n      (BEG_FNC_AD_SEQUENCE('BEG_FIN_INF_PESSOA'),\n       :new.AD_CLIENT_ID,\n       0, --:new.AD_ORG_ID,\n       :new.ISACTIVE,\n       :new.CREATED,\n       :new.CREATEDBY,\n       :new.UPDATED,\n       :new.UPDATEDBY,\n       :new.BEG_PESSOA_ID,\n       0,\n       0,\n       0,\n       0,\n       0,\n       0,\n       0,\n       0,\n       0,\n       null,\n       0,\n       :new.BEG_DADOS_BANCARIOS_ID);\n  else\n    -- Somente atualizar em beg_fin_inf_pessoa se nao existir dados bancarios\n    if RCCPAD.BEG_DADOS_BANCARIOS_ID is null then\n      update BEG_FIN_INF_PESSOA F\n         set F.BEG_DADOS_BANCARIOS_ID = :new.BEG_DADOS_BANCARIOS_ID\n       where F.BEG_PESSOA_ID = :new.BEG_PESSOA_ID;\n    end if;\n  end if;\nend BEG_TRG_BIU_DADOS_BANCARIOS;\n"}`;
    
    }
}
