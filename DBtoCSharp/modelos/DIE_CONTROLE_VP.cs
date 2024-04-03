
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONTROLE_VP
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CONTROLE_VP_ID { get; set; }
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
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VP_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SALDO_VP { get; set; }
            [StringLength(400)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_AIUD_CONTROLE_VP { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"BEGIN\n  -------------- insert\n  IF INSERTING then\n    declare\n      v_user VARCHAR2(8);\n      V_SQL  varchar2(1500);\n    \n      CURSOR C_FILIAL IS\n        select substr (a.value,2)local , a.* from ad_org a WHERE a.ad_org_id = :NEW.AD_ORG_ID;\n    \n      R_FILIAL C_FILIAL%rowtype;\n    \n    begin\n      OPEN C_FILIAL;\n      FETCH C_FILIAL\n        into R_FILIAL;\n      CLOSE C_FILIAL;\n      V_USER := R_FILIAL.local;\n    \n      IF V_USER > 0 THEN\n        v_sql := 'insert  INTO die_controle_vp@FILIAL' || v_user ||\n                 '         \n      (DIE_CONTROLE_VP_ID ,\n       AD_CLIENT_ID       ,\n       AD_ORG_ID          ,\n       ISACTIVE           ,\n       CREATED            ,\n       CREATEDBY          ,\n       UPDATED            ,\n       UPDATEDBY          ,\n       VALUE              ,\n       DT_INICIAL         ,\n       DT_FINAL           ,\n       VLR_VP_TOTAL       ,\n       VLR_SALDO_VP   ,\n       OBS                ,\n       AD_USER_ID          )\n       VALUES\n        (' || :NEW.DIE_CONTROLE_VP_ID || ' ,' ||\n                 :NEW.AD_CLIENT_ID || ' ,' || :NEW.AD_ORG_ID || ' ,''' ||\n                 :NEW.ISACTIVE || ''' ,''' || :NEW.CREATED || ''' ,' ||\n                 :NEW.CREATEDBY || ' ,''' || :NEW.UPDATED || ''' ,' ||\n                 :NEW.UPDATEDBY || ' ,' || :NEW.VALUE || ' ,''' ||\n                 :NEW.DT_INICIAL || ''' ,''' || :NEW.DT_FINAL || ''' ,' ||\n                 :NEW.VLR_VP_TOTAL || ' ,' || nvl(:NEW.VLR_VP_TOTAL, 0) ||\n                 ' ,''' || nvl(:NEW.OBS, 'Inclusao') || ''' ,' ||\n                 nvl(:NEW.AD_USER_ID, 0) || '\n       )';\n      \n        execute immediate V_SQL;\n      \n      END IF;\n    \n    END;\n  END IF;\n  ----- Delete  \n  IF DELETING THEN\n    DIE_PRC_CONTROLE_VP_DELETE(:OLD.DIE_CONTROLE_VP_ID, :OLD.AD_ORG_ID);\n  END IF;\n  ----- Update\n  IF updating then\n    if :OLD.DT_INICIAL <> :NEW.DT_INICIAL OR :OLD.DT_FINAL <> :NEW.DT_FINAL OR\n       :OLD.VLR_VP_TOTAL <> :NEW.VLR_VP_TOTAL THEN\n      declare\n        v_user VARCHAR2(8);\n        V_SQL  varchar2(1500);\n      \n        CURSOR C_FILIAL IS\n  --        select * from ad_org WHERE ad_org_id = :NEW.AD_ORG_ID;\n      select substr (a.value,2)local , a.* from ad_org a WHERE a.ad_org_id = :NEW.AD_ORG_ID;\n        R_FILIAL C_FILIAL%rowtype;\n      \n      begin\n        OPEN C_FILIAL;\n        FETCH C_FILIAL\n          into R_FILIAL;\n        CLOSE C_FILIAL;\n        V_USER := R_FILIAL.local;\n      \n        IF V_USER > 0 THEN\n          v_sql := ('UPDATE die_controle_vp@FILIAL' || v_user || ' SET         \n       DT_INICIAL         = '''||:NEW.DT_INICIAL || ''' ,\n       DT_FINAL           = '''||:NEW.DT_FINAL   || ''' ,\n       VLR_VP_TOTAL       = '||:NEW.VLR_VP_TOTAL || ' ,\n       OBS                = '''||:NEW.OBS||'''\n       WHERE die_controle_vp_id= '||:OLD.DIE_CONTROLE_VP_ID);\n   \n   DBMS_OUTPUT.PUT_LINE(V_SQL);      \n          execute immediate V_SQL;\n        \n        END IF;\n      \n      END;\n    END IF;\n  END IF;\n\nEND DIE_TRG_AIUD_CONTROLE_VP;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_CONTROLE_VP { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"DECLARE\n\n   V_DIE_CONTROLE_VP_ID NUMBER(10);\n   \n   CURSOR  C_DIE_CONTROLE_VP  IS\n       SELECT DIE_CONTROLE_VP_ID\n       FROM   DIE_CONTROLE_VP C\n       WHERE  C.DIE_CONTROLE_VP_ID = :new.DIE_CONTROLE_VP_ID;\nBEGIN\n   --\n   IF  INSERTING  THEN\n      IF :NEW.AD_ORG_ID = 0 THEN\n         RAISE_APPLICATION_ERROR(-20001, 'Informe uma Filial!');\n      END IF;                      \n      IF :NEW.DT_FINAL < :NEW.DT_INICIAL THEN\n         RAISE_APPLICATION_ERROR(-20001, 'Data Final é menor que a Data Inicial!');\n      END IF;  \n      IF TRUNC(NVL(:NEW.DT_INICIAL, SYSDATE)) < TRUNC(SYSDATE) THEN \n         RAISE_APPLICATION_ERROR(-20001, 'Data Inicial deve ser igual ou maior que a Data Atual!');\n      END IF;\n      IF :NEW.VLR_VP_TOTAL = 0 THEN \n         RAISE_APPLICATION_ERROR(-20001, 'Informe um Valor!');\n      END IF;\n   END IF;  \n   \n   IF UPDATING THEN\n     IF :NEW.DT_FINAL < :NEW.DT_INICIAL THEN\n         RAISE_APPLICATION_ERROR(-20001, 'Data Final é menor que a Data Inicial!');\n      END IF;  \n   END IF;\n   \n   --\n   IF INSERTING AND :NEW.VLR_SALDO_VP IS NULL THEN\n     :NEW.VLR_SALDO_VP := :NEW.VLR_VP_TOTAL;\n   END IF;  \n   --\n   IF INSERTING THEN\n      OPEN  C_DIE_CONTROLE_VP;\n      FETCH C_DIE_CONTROLE_VP\n      INTO  V_DIE_CONTROLE_VP_ID;\n  \n   IF C_DIE_CONTROLE_VP %FOUND THEN\n      :NEW.DIE_CONTROLE_VP_ID := V_DIE_CONTROLE_VP_ID;\n   END IF;\n  \n   CLOSE C_DIE_CONTROLE_VP;\n  \n   END IF;\n  --\nEND DIE_TRG_CONTROLE_VP;\n"}`;
    
    }
}
