
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_EXTRATO_BANRI
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_INTEGRAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_MOVTO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_MOV { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_EXTRATO_BANRI_ID { get; set; }
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
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IDENT { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string MEMO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CHECKNUM { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BU_EXTRATO_BANRI { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"DECLARE\n  V_ID       NUMBER(10);\n  V_SALDO_ID NUMBER(10);\n\n  cursor c1 is\n    SELECT S.BEG_FIN_BCO_SALDO_ID,\n           s.beg_banco_id,\n           s.beg_agencia_id,\n           s.beg_fin_conta_corrente_id\n      FROM BEG_FIN_BCO_SALDO S\n     WHERE S.DT_SALDO = :NEW.DATA\n       AND S.BEG_FIN_PORTADOR_ID = :NEW.BEG_FIN_PORTADOR_ID;\n  R1 C1%ROWTYPE;\n\nBEGIN\n\n  IF UPDATING AND :NEW.IND_INTEGRAR = 'Y' AND\n     :NEW.BEG_FIN_BCO_CONTA_ID IS NULL THEN\n  \n    RAISE_APPLICATION_ERROR(-20001, 'Falta informar a conta de destino!');\n  \n  END IF;\n\n  IF :NEW.IND_INTEGRAR = 'Y' AND :OLD.IND_INTEGRAR = 'N' THEN\n  \n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n  \n    V_SALDO_ID := R1.beg_fin_bco_saldo_id;\n  \n    IF V_SALDO_ID IS NULL THEN\n    \n      V_SALDO_ID := beg_fnc_ad_sequence('BEG_FIN_BCO_SALDO');\n\n      INSERT INTO BEG_FIN_BCO_SALDO\n        (BEG_FIN_BCO_SALDO_ID,\n         AD_CLIENT_ID,\n         AD_ORG_ID,\n         ISACTIVE,\n         CREATED,\n         CREATEDBY,\n         UPDATED,\n         UPDATEDBY,\n         DT_SALDO,\n         SALDO_DIA_ANTERIOR,\n         TOTAL_DEBITOS,\n         TOTAL_CREDITOS,\n         SALDO_DIA,\n         BEG_BANCO_ID,\n         BEG_AGENCIA_ID,\n         BEG_FIN_CONTA_CORRENTE_ID,\n         DOCSTATUS,\n         BEG_FIN_PORTADOR_ID,\n         DT_TRANFERENCIA,\n         IND_TRANSFERENCIA)\n      VALUES\n        (V_SALDO_ID,\n         1000000, --AD_CLIENT_ID              ,\n         0, --AD_ORG_ID                 ,\n         'Y', --ISACTIVE                  ,\n         SYSDATE, --CREATED                   ,\n         :NEW.CREATEDBY,\n         SYSDATE, --UPDATED                   ,\n         :NEW.UPDATEDBY,\n         :NEW.DATA, --DT_SALDO                  ,\n         0, --SALDO_DIA_ANTERIOR        ,\n         0, --TOTAL_DEBITOS             ,\n         0, --TOTAL_CREDITOS            ,\n         0, --SALDO_DIA                 ,\n         R1.BEG_BANCO_ID,\n         R1.BEG_AGENCIA_ID,\n         R1.BEG_FIN_CONTA_CORRENTE_ID,\n         'WC', --DOCSTATUS                 ,\n         :NEW.BEG_FIN_PORTADOR_ID,\n         NULL, --DT_TRANFERENCIA           ,\n         NULL --IND_TRANSFERENCIA\n         );\n      -- COMMIT;\n    END IF;\n  \n    V_ID := BEG_FNC_AD_SEQUENCE('BEG_FIN_BCO_MOVTO');\n  \n    INSERT INTO BEG_FIN_BCO_MOVTO\n      (BEG_FIN_BCO_MOVTO_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_BANCO_ID,\n       BEG_AGENCIA_ID,\n       BEG_FIN_CONTA_CORRENTE_ID,\n       TIPO_MOV,\n       DATA_LANC,\n       VALOR,\n       BEG_FIN_BCO_CONTA_ID,\n       BEG_FIN_BCO_SALDO_ID,\n       HISTORICO)\n    values\n      (V_ID,\n       1000000, --AD_CLIENT_ID              ,\n       0, --AD_ORG_ID                 ,\n       'Y', --ISACTIVE                  ,\n       SYSDATE, --CREATED                   ,\n       :NEW.CREATEDBY,\n       SYSDATE, --UPDATED                   ,\n       :NEW.UPDATEDBY,\n       R1.BEG_BANCO_ID,\n       R1.BEG_AGENCIA_ID,\n       R1.BEG_FIN_CONTA_CORRENTE_ID,\n       :NEW.TIPO_MOV, -- TIPO_MOV            ,\n       :NEW.DATA, --DATA_LANC           ,\n       :NEW.VALOR,\n       :NEW.BEG_FIN_BCO_CONTA_ID, --BEG_FIN_BCO_CONTA_ID,\n       V_SALDO_ID,\n       :NEW.HISTORICO);\n    :NEW.BEG_FIN_BCO_MOVTO_ID := V_ID;\n  \n  END IF;\nEND;\n"}`;
    
    }
}
