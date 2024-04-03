
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_CORRESP_MOV
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CORRESP_MOV_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CORRESP_ID { get; set; }
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
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(2)]
        /// <summary>
        /// WC, CO
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// ID da integracao no Movimento caixa geral
        /// </summary>
        public int BEG_FIN_CAIXA_MOVIMENTO_ID { get; set; }
        
        /// <summary>
        /// ID da integracao no Saldo caixa geral
        /// </summary>
        public int BEG_FIN_CAIXA_SALDO_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BI_FIN_CORRESP_MOV { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"DECLARE\n\n  VDATA  DATE;\n  VN_BEG_FIN_CAIXA_SALDO_ID NUMBER(10);\n  VN_BEG_FIN_CAIXA_MOV_ID   NUMBER(10);\n  \n  cursor c1 is\n    select c.*\n      from DIE_FIN_CORRESP c\n     where c.die_fin_corresp_id = :NEW.DIE_FIN_CORRESP_ID;\n  R1 C1%ROWTYPE;\n\n  CURSOR C2 IS \n     SELECT CA.*\n       FROM BEG_FIN_CAIXA_SALDO CA\n      WHERE CA.DATA =  VDATA\n       AND CA.BEG_FIN_CAIXA_ID = 2000070;\n  R2 C2%ROWTYPE;\n       \n\nBEGIN\n\n  IF INSERTING THEN\n    open C1;\n    fetch C1\n      into R1;\n    CLOSE C1;\n    IF R1.DOCSTATUS = 'CO' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Lote ja encerrado não permite inclusão');\n    END IF;\n  \n  \n   IF :NEW.BEG_FILIAL_ID = 1000016 THEN \n    VDATA := R1.DATA;\n      open C2;\n    fetch C2\n      into R2;\n--    CLOSE C2;\n    \n     IF C2%NOTFOUND THEN \n       \n        VN_BEG_FIN_CAIXA_SALDO_ID := BEG_FNC_AD_SEQUENCE('BEG_FIN_CAIXA_SALDO');\n      --\n      INSERT INTO BEG_FIN_CAIXA_SALDO (BEG_FIN_CAIXA_SALDO_ID\n                                      ,AD_CLIENT_ID\n                                      ,AD_ORG_ID\n                                      ,ISACTIVE\n                                      ,CREATED\n                                      ,CREATEDBY\n                                      ,UPDATED\n                                      ,UPDATEDBY\n                                      ,DATA\n                                      ,DOCSTATUS\n                                      ,BEG_FIN_CAIXA_ID\n                                      ,SALDO_REALIZADO\n                                      ,SALDO_PREVISTO\n                                      ,SALDO_ANTERIOR\n                                      )\n                               VALUES (VN_BEG_FIN_CAIXA_SALDO_ID\n                                      ,1000000\n                                      ,0\n                                      ,'Y'\n                                      ,SYSDATE\n                                      ,1000000\n                                      ,SYSDATE\n                                      ,1000000\n                                      ,R1.DATA\n                                      ,'IP'\n                                      ,2000070\n                                      ,0\n                                      ,0\n                                      ,0\n                                      );\n                                      \n                                                    \n     ELSE\n       VN_BEG_FIN_CAIXA_SALDO_ID := R2.Beg_Fin_Caixa_Saldo_Id;\n         \n     \n     END IF; \n       \n       VN_BEG_FIN_CAIXA_MOV_ID := BEG_FNC_AD_SEQUENCE('BEG_FIN_CAIXA_MOVIMENTO');\n        \n     INSERT INTO BEG_FIN_CAIXA_MOVIMENTO (BEG_FIN_CAIXA_MOVIMENTO_ID\n                                        ,BEG_FIN_CAIXA_ID\n                                        ,AD_CLIENT_ID\n                                        ,AD_ORG_ID\n                                        ,ISACTIVE\n                                        ,CREATED\n                                        ,CREATEDBY\n                                        ,UPDATED\n                                        ,UPDATEDBY\n                                        ,BEG_FIN_CAIXA_CONTA_ID\n                                        ,BEG_FIN_CAIXA_HISTORICO_ID\n                                        ,TP_MOVTO\n                                        ,VLR_MOVIMENTO\n                                        ,BEG_FIN_CAIXA_SALDO_ID\n                                        ,DATA_PREVISTA\n                                        ,BEG_FILIAL_ID\n                                        ,IND_INTEGRADO\n                                        )\n                                 VALUES (VN_BEG_FIN_CAIXA_MOV_ID\n                                        ,2000070\n                                        ,1000000\n                                        ,0\n                                        ,'Y'\n                                        ,SYSDATE\n                                        ,1000000\n                                        ,SYSDATE\n                                        ,1000000\n                                        ,2000042\n                                        ,2000001\n                                        ,'E' -- MUDAR\n                                        ,:NEW.VALOR --129.25 -- TIRAR OS VALORES FIXOS\n                                        ,VN_BEG_FIN_CAIXA_SALDO_ID--2023195 -- TIRAR OS VALORES FIXOS\n                                        ,R1.DATA--SYSDATE -- TIRAR OS VALORES FIXOS\n                                        ,:NEW.BEG_FILIAL_ID\n                                        ,'Y'\n                                        );\n     \n     \n        \n     :NEW.BEG_FIN_CAIXA_MOVIMENTO_ID := VN_BEG_FIN_CAIXA_MOV_ID;\n     :NEW.BEG_FIN_CAIXA_SALDO_ID := VN_BEG_FIN_CAIXA_SALDO_ID;\n   CLOSE C2;  \n   END IF;\n  \n  \n    \n  END IF;\n  \n  IF  UPDATING  AND :NEW.BEG_FIN_CAIXA_SALDO_ID IS NOT NULL AND :NEW.BEG_FILIAL_ID IN( 0, 1000016,1000134) THEN \n    UPDATE BEG_FIN_CAIXA_MOVIMENTO C SET \n        C.VLR_MOVIMENTO = :NEW.VALOR\n     WHERE C.BEG_FIN_CAIXA_MOVIMENTO_ID = :NEW.BEG_FIN_CAIXA_MOVIMENTO_ID;\n        \n  END IF ;\n\n    \n  IF  DELETING  AND :OLD.BEG_FIN_CAIXA_SALDO_ID IS NOT NULL AND :OLD.BEG_FILIAL_ID IN( 0, 1000016,1000134) THEN \n    DELETE BEG_FIN_CAIXA_MOVIMENTO C      \n     WHERE C.BEG_FIN_CAIXA_MOVIMENTO_ID = :OLD.BEG_FIN_CAIXA_MOVIMENTO_ID;\n        \n  END IF ;\n\n\nEND DIE_TRG_BI_FIN_CORRESP_MOV;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_FIN_CORRESP_MOV { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n PRAGMA AUTONOMOUS_TRANSACTION;\nBEGIN\n\nIF INSERTING THEN\n  UPDATE DIE_FIN_CORRESP A SET\n     A.Valortotal = A.Valortotal + :NEW.VALOR\n  WHERE A.DIE_FIN_CORRESP_ID = :NEW.DIE_FIN_CORRESP_ID;\n\nEND IF;\n\nIF UPDATING  AND :OLD.DOCSTATUS <>'CO' AND :OLD.VALOR <> :NEW.VALOR THEN\n  UPDATE DIE_FIN_CORRESP A SET\n     A.Valortotal = A.Valortotal - :OLD.VALOR + :NEW.VALOR\n  WHERE A.DIE_FIN_CORRESP_ID = :OLD.DIE_FIN_CORRESP_ID;\n\nEND IF;\n\n\nIF DELETING   AND :OLD.DOCSTATUS <>'CO' THEN\n  UPDATE DIE_FIN_CORRESP A SET\n     A.Valortotal = A.Valortotal - :OLD.VALOR\n  WHERE A.DIE_FIN_CORRESP_ID = :OLD.DIE_FIN_CORRESP_ID;\n\nEND IF;\n\nIF DELETING  AND :OLD.DOCSTATUS ='CO' THEN\n  RAISE_APPLICATION_ERROR(-20001,'Lote ja encerrado não permite exclusão');\n\nEND IF;\n\nIF UPDATING   AND :OLD.DOCSTATUS ='CO' THEN\n  RAISE_APPLICATION_ERROR(-20001,'Lote ja encerrado não permite alteracao');\n\nEND IF;\n\nCOMMIT;\nEND DIE_TRG_BIUD_FIN_CORRESP_MOV;\n"}`;
    
    }
}
