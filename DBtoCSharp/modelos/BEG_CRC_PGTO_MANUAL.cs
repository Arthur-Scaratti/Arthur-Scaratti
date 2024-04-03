
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_PGTO_MANUAL
    {
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_BANCO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_HISTORICO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_CONTA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESTORNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DIGITADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// Indica o banco onde foi efetuado o depósito referente aos pagamentos.
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_PGTO_MANUAL_ID { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PGTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TPMOV_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQ_PGTO_MENOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEQ_PGTO_MAIOR { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se a data do lote deve ser inicializada nos titulos
        /// </summary>
        public string IND_INICIALIZA_DATA { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AI_CRC_PGTO_MANUAL { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n\n  cursor c1 is\n    select M.*\n      from beg_fin_bco_movto m, beg_fin_bco_saldo s\n     where m.beg_fin_bco_conta_id = 1000011\n       and m.beg_vw_fin_bco_conta_id is null\n       and m.data_identificacao is null\n       and m.beg_fin_bco_saldo_id = s.beg_fin_bco_saldo_id\n       and s.beg_fin_portador_id = :new.beg_fin_portador_id\n       AND S.DT_SALDO BETWEEN :NEW.DT_INI AND :NEW.DT_FIM;\n\n  cursor c2 is\n    select M.DATA_LANC,\n           M.BEG_FIN_BCO_MOVTO_ID,\n           M.HISTORICO,\n           o.valor vlr_origem,\n           o.beg_fin_bco_movto_origem_id\n      from beg_fin_bco_movto        m,\n           beg_fin_bco_saldo        s,\n           beg_fin_bco_movto_origem o\n     where m.beg_fin_bco_conta_id = 1000104\n       and o.beg_crc_pgto_manual_id is null\n       and m.beg_fin_bco_movto_id = o.beg_fin_bco_movto_id\n       and o.beg_fin_bco_conta_id = 1000014\n       and m.beg_fin_bco_saldo_id = s.beg_fin_bco_saldo_id\n       and s.beg_fin_portador_id = :new.beg_fin_portador_id\n       AND S.DT_SALDO BETWEEN :NEW.DT_INI AND :NEW.DT_FIM;\n\nbegin\n\n  if :new.ind_banco = 'Y' then\n    for x in c1 loop\n      insert into DIE_FIN_DEP_VINC\n        (DIE_FIN_DEP_VINC_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VALUE,\n         BEG_FIN_BCO_MOVTO_ID,\n         DATA_IDENTIFICACAO,\n         BEG_VW_FIN_BCO_CONTA_ID,\n         BEG_CRC_PGTO_MANUAL_ID,\n         VALOR,\n         DATA_LANC,\n         HISTORICO)\n      values\n        (BEG_FNC_AD_SEQUENCE('DIE_FIN_DEP_VINC'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'N', --:NEW.ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.VALUE,\n         X.BEG_FIN_BCO_MOVTO_ID,\n         :NEW.DT_PGTO, --DATA_IDENTIFICACAO      ,\n         :NEW.BEG_VW_FIN_BCO_CONTA_ID, --BEG_VW_FIN_BCO_CONTA_ID ,\n         :NEW.BEG_CRC_PGTO_MANUAL_ID,\n         X.VALOR,\n         X.DATA_LANC,\n         X.HISTORICO);\n    \n    end loop;\n  \n    for Y in c2 loop\n    \n      insert into DIE_FIN_DEP_VINC\n        (DIE_FIN_DEP_VINC_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VALUE,\n         BEG_FIN_BCO_MOVTO_ID,\n         DATA_IDENTIFICACAO,\n         BEG_VW_FIN_BCO_CONTA_ID,\n         BEG_CRC_PGTO_MANUAL_ID,\n         VALOR,\n         DATA_LANC,\n         HISTORICO,\n         BEG_FIN_BCO_MOVTO_ORIGEM_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('DIE_FIN_DEP_VINC'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'N', --:NEW.ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.VALUE,\n         Y.BEG_FIN_BCO_MOVTO_ID,\n         :NEW.DT_PGTO, --DATA_IDENTIFICACAO      ,\n         :NEW.BEG_VW_FIN_BCO_CONTA_ID, --BEG_VW_FIN_BCO_CONTA_ID ,\n         :NEW.BEG_CRC_PGTO_MANUAL_ID,\n         Y.VLR_ORIGEM,\n         Y.DATA_LANC,\n         Y.HISTORICO,\n         Y.BEG_FIN_BCO_MOVTO_ORIGEM_ID);\n    \n    end loop;\n  \n  else \n    insert into DIE_FIN_DEP_VINC\n        (DIE_FIN_DEP_VINC_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         VALUE,\n         BEG_FIN_BCO_MOVTO_ID,\n         DATA_IDENTIFICACAO,\n         BEG_VW_FIN_BCO_CONTA_ID,\n         BEG_CRC_PGTO_MANUAL_ID,\n         VALOR,\n         DATA_LANC,\n         HISTORICO,\n         BEG_FIN_BCO_MOVTO_ORIGEM_ID)\n      values\n        (BEG_FNC_AD_SEQUENCE('DIE_FIN_DEP_VINC'),\n         :NEW.AD_CLIENT_ID,\n         :NEW.AD_ORG_ID,\n         'Y', --:NEW.ISACTIVE,\n         :NEW.CREATED,\n         :NEW.CREATEDBY,\n         :NEW.UPDATED,\n         :NEW.UPDATEDBY,\n         :NEW.VALUE,\n         null, --Y.BEG_FIN_BCO_MOVTO_ID,\n         :NEW.DT_PGTO, --DATA_IDENTIFICACAO      ,\n         null, --BEG_VW_FIN_BCO_CONTA_ID ,\n         :NEW.BEG_CRC_PGTO_MANUAL_ID,\n         :new.vlr_digitado, -- VLR_ORIGEM,\n         null, -- DATA_LANC,\n         null, -- HISTORICO,\n         null -- BEG_FIN_BCO_MOVTO_ORIGEM_ID);\n         );\n  end if;\n\nend BEG_TRG_AI_CRC_PGTO_MANUAL;\n"}`;
    
        [NotMapped]
        public string Trigger_TRG_BIUD_LOT_MANUAL_ENCER { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n \n  v_count number :=0;\n\n  cursor C_FECH_CONT is\n    select MAX(C.DT_FINAL) DT_FINAL from BEG_FECH_CONTABIL C;  \n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n  \n  cursor C_FECH_CONT1 is  \n     select       ind_escrita from BEG_FECH_CONTABIL C where c.dt_final = R_FECH_CONT.DT_FINAL;\n  R_FECH_CONT1 C_FECH_CONT1%rowtype;\nbegin\n\n   IF :NEW.DT_PGTO > SYSDATE()THEN\n   RAISE_APPLICATION_ERROR(-20001,'Data da baixa nao pode ser maior que data a atual.!!'); \n  END IF;\n    \n  IF UPDATING AND :NEW.DT_PGTO <> :OLD.DT_PGTO THEN\n    \n     UPDATE DIE_FIN_DEP_VINC D SET \n      D.DATA_IDENTIFICACAO = :NEW.DT_PGTO\n      WHERE D.BEG_CRC_PGTO_MANUAL_ID = :NEW.BEG_CRC_PGTO_MANUAL_ID;\n  \n  END IF;\n\n  if (updating and :new.dt_pgto <> :old.dt_pgto) or inserting or deleting then\n    open C_FECH_CONT;\n    fetch C_FECH_CONT\n      into R_FECH_CONT;\n    close C_FECH_CONT;\n    open C_FECH_CONT1;\n    fetch C_FECH_CONT1\n      into R_FECH_CONT1;\n    close C_FECH_CONT1;\n    if R_FECH_CONT.DT_FINAL >= :new.dt_pgto AND\n       nvl(R_FECH_CONT1.IND_ESCRITA, 'N') = 'N' then\n      raise_application_error(-20501,\n                              'Movimento ja encerrado!' ||\n                              R_FECH_CONT.DT_FINAL);\n    end if;\n  end if;\n  \n  if updating and :new.isactive = 'N' and :old.isactive='Y' then\n    \n     select count(1)\n       into v_count\n      from DIE_FIN_DEP_VINC d\n      where d.beg_crc_pgto_manual_id = :new.beg_crc_pgto_manual_id\n        and d.isactive='Y';\n      \n      if v_count >0 then\n        raise_application_error(-20501,'Lote com deposito vinculado ativo. Verifique!');\n      end if;\n  \n  end if;\n  \nend trg_biud_lot_manual_encer;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_BI_CRC_PGTO_MANUAL { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n  -- Verifica filial\n  if NVL(:new.AD_ORG_ID, 0) = 0 then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Deve ser selecionada uma filial para o lote!');\n  end if;\nend BEG_TRG_BI_CRC_PGTO_MANUAL;\n"}`;
    
    }
}
