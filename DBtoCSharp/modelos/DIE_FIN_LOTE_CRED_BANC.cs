
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_LOTE_CRED_BANC
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_LOTE_CRED_BANC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
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
        public int VLR_DEPOSITO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MOVIMENTO { get; set; }
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
        public string DT_INICIAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_FINAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_BAIXA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_BCO_CONTA_ID { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIUD_FIN_LOTE_CRED_BANC { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n  cursor C_FECH_CONT is\n    select MAX(C.DT_FINAL) DT_FINAL from BEG_FECH_CONTABIL C where c.ind_escrita = 'N';\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n\n  cursor C_FECH_CONT1 is\n     select       ind_escrita from BEG_FECH_CONTABIL C where c.dt_final = R_FECH_CONT.DT_FINAL;\n  R_FECH_CONT1 C_FECH_CONT1%rowtype;\nbegin\n\n   IF :NEW.DT_BAIXA > SYSDATE()THEN\n   RAISE_APPLICATION_ERROR(-20001,'Data da baixa nao pode ser maior que data a atual.!!');\n  END IF;\n\n\n\n  if (updating and :NEW.DT_BAIXA <> :OLD.DT_BAIXA) or inserting or deleting then\n    open C_FECH_CONT;\n    fetch C_FECH_CONT\n      into R_FECH_CONT;\n    close C_FECH_CONT;\n    open C_FECH_CONT1;\n    fetch C_FECH_CONT1\n      into R_FECH_CONT1;\n    close C_FECH_CONT1;\n    if R_FECH_CONT.DT_FINAL >= :NEW.DT_BAIXA AND\n       nvl(R_FECH_CONT1.IND_ESCRITA, 'N') = 'N' then\n      raise_application_error(-20501,\n                              'Movimento ja encerrado!' ||\n                              R_FECH_CONT.DT_FINAL);\n    end if;\n  end if;\nend trg_biud_FIN_LOTE_CRED_BANC;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AI_LOTE_CRED_BANC { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  cursor c1 is\n    select M.*\n      from beg_fin_bco_movto m, beg_fin_bco_saldo s\n     where m.beg_fin_bco_conta_id = 1000011\n       and m.beg_vw_fin_bco_conta_id is null\n       and m.data_identificacao is null\n       and m.beg_fin_bco_saldo_id = s.beg_fin_bco_saldo_id\n       and s.beg_fin_portador_id = :new.beg_fin_portador_id\n       AND S.DT_SALDO BETWEEN :NEW.DT_INICIAL AND :NEW.DT_FINAL;\n\nbegin\n\n if inserting then\n  for x in c1 loop\n    insert into DIE_FIN_DEP_CRED_BANC\n      (DIE_FIN_DEP_CRED_BANC_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_FIN_BCO_MOVTO_ID,\n       DATA_IDENTIFICACAO,\n       BEG_VW_FIN_BCO_CONTA_ID,\n       DIE_FIN_LOTE_CRED_BANC_ID,\n       VALOR,\n       DATA_LANC,\n       HISTORICO)\n    values\n      (BEG_FNC_AD_SEQUENCE('DIE_FIN_DEP_CRED_BANC'),\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       'N', --:NEW.ISACTIVE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       X.BEG_FIN_BCO_MOVTO_ID,\n       :NEW.DT_BAIXA, --DATA_IDENTIFICACAO      ,\n       :NEW.BEG_VW_FIN_BCO_CONTA_ID, --BEG_VW_FIN_BCO_CONTA_ID ,\n       :NEW.DIE_FIN_LOTE_CRED_BANC_ID,      \n       X.VALOR,\n       X.DATA_LANC,\n       X.HISTORICO);\n  \n  end loop;\n  \n  end if;\n  \n  if updating and :old.dt_baixa <> :new.dt_baixa then\n    \n  \n    update DIE_FIN_DEP_CRED_BANC b set\n     b.data_identificacao = :new.dt_baixa\n     where b.die_fin_lote_cred_banc_id= :NEW.DIE_FIN_LOTE_CRED_BANC_ID;\n  \n  end if;\n  \n  \n\nend DIE_TRG_AI_LOTE_CRED_BANC;\n"}`;
    
    }
}
