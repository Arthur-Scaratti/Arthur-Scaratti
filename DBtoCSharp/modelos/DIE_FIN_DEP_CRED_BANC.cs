
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_DEP_CRED_BANC
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_DEP_CRED_BANC_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_MOVTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_IDENTIFICACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_LOTE_CRED_BANC_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_LANC { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AI_DEP_CRED_BANC { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"declare\n\n  cursor c1 is\n    select M.* \n      from DIE_FIN_CREDITO_BANCARIO M\n     where m.vlr_aberto > 0\n      AND  M.BEG_FIN_CAIXA_CONTA_ID IN (SELECT C.BEG_FIN_CAIXA_CONTA_ID FROM BEG_FIN_BCO_CONTA C WHERE C.BEG_FIN_BCO_CONTA_ID = :NEW.BEG_VW_FIN_BCO_CONTA_ID);\n\nbegin\n\n  IF :NEW.ISACTIVE = 'Y' AND :OLD.ISACTIVE = 'N' THEN\n    for x in c1 loop\n      insert into DIE_FIN_BAIXA_CRED_BANC\n        (DIE_FIN_BAIXA_CRED_BANC_ID,\n         AD_ORG_ID,\n         AD_CLIENT_ID,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         ISACTIVE,\n         VLR_CREDITO,\n         DT_CREDITO,\n         DIE_FIN_DEP_CRED_BANC_ID,\n         OBSERVACAO,\n         DIE_FIN_CREDITO_BANCARIO_ID,\n         DIE_FIN_LOTE_CRED_BANC_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('DIE_FIN_BAIXA_CRED_BANC'),\n         X.AD_ORG_ID,\n         :NEW.AD_CLIENT_ID,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         'N', --:NEW.ISACTIVE,\n         X.VLR_ABERTO, --VLR_CREDITO                ,\n         X.DATA, --DT_CREDITO                 ,\n         :NEW.DIE_FIN_DEP_CRED_BANC_ID,\n         X.OBSERVACAO,\n         X.DIE_FIN_CREDITO_BANCARIO_ID,\n         :NEW.DIE_FIN_LOTE_CRED_BANC_ID);\n    \n    end loop;\n    \n    UPDATE DIE_FIN_LOTE_CRED_BANC L SET\n     L.VLR_DEPOSITO = L.VLR_DEPOSITO + :NEW.VALOR\n     WHERE L.DIE_FIN_LOTE_CRED_BANC_ID = :NEW.DIE_FIN_LOTE_CRED_BANC_ID;\n  END IF;\n  \n   IF :NEW.ISACTIVE = 'N' AND :OLD.ISACTIVE = 'Y' THEN\n     UPDATE DIE_FIN_LOTE_CRED_BANC L SET\n     L.VLR_DEPOSITO = L.VLR_DEPOSITO - :NEW.VALOR\n     WHERE L.DIE_FIN_LOTE_CRED_BANC_ID = :NEW.DIE_FIN_LOTE_CRED_BANC_ID;\n   \n   END IF;\n\nend DIE_TRG_AI_DEP_CRED_BANC;\n"}`;
    
    }
}
