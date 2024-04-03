
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_BAIXA_DEV
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_BAIXA_DEV_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_BAIXAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_MOVIMENTO { get; set; }
            [StringLength(400)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// IP ( Em progresso), CO ( Ccompleto)
        /// </summary>
        public string DOCSTATUS { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_AI_CPG_BAIXA_DEV { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n\n  CURSOR C1 IS\n    select T.*\n      from BEG_CPG_TITULO T\n     where T.DT_PGTO IS NULL\n       AND T.BEG_VW_FORNECEDOR_ID =\n           (SELECT TIT.BEG_VW_FORNECEDOR_ID\n              FROM BEG_CPG_TITULO TIT\n             WHERE TIT.BEG_CPG_TITULO_ID = :NEW.BEG_CPG_TITULO_ID)\n       AND T.BEG_CPG_TITULO_ID <> :NEW.BEG_CPG_TITULO_ID;\n\n  R_C1 C1%ROWTYPE;\n\nBEGIN\n\n  OPEN C1;\n  FETCH C1\n    INTO R_C1;\n  CLOSE C1;\n\n--- comentado em 05/01/2023 permitindo assim incluir manualmente titulos a baixar\n/*  IF R_C1.BEG_CPG_TITULO_ID IS NULL THEN\n  \n    RAISE_APPLICATION_ERROR(-20001,\n                            'Sem títulos em aberto deste fornecedor para baixa!');\n  \n  END IF;*/\n\n  FOR X IN C1 LOOP\n    INSERT INTO BEG_CPG_BAIXA_DEV_ORIGEM\n      (BEG_CPG_BAIXA_DEV_ORIGEM_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       BEG_CPG_TITULO_ID,\n       BEG_CPG_BAIXA_DEV_ID\n       \n       )\n    VALUES\n      (BEG_FNC_AD_SEQUENCE('BEG_CPG_BAIXA_DEV_ORIGEM'),\n       :NEW.AD_CLIENT_ID,\n       :NEW.AD_ORG_ID,\n       'N',\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       X.BEG_CPG_TITULO_ID,\n       :NEW.BEG_CPG_BAIXA_DEV_ID);\n  \n  END LOOP;\n\nEND;\n"}`;
    
        [NotMapped]
        public string Trigger_BEG_TRG_CPG_BAIXA_DEV { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n  --\n  CURSOR C1 IS\n    SELECT B.VLR_ABERTO\n      FROM BEG_CPG_TITULO B\n     WHERE B.BEG_CPG_TITULO_ID = :NEW.BEG_CPG_TITULO_ID;\n  --\n  cursor C_FECH_CONT is\n    select MAX(C.DT_FINAL) DT_FINAL\n      from BEG_FECH_CONTABIL C;\n  --\n  R_FECH_CONT C_FECH_CONT%rowtype;\n  --\n    cursor C_FECH_CONT1 is\n    select ind_escrita from BEG_FECH_CONTABIL C where c.dt_final = R_FECH_CONT.DT_FINAL;\n  --\n  R_FECH_CONT1 C_FECH_CONT1%rowtype;\n\n\nBEGIN\n  --\n  OPEN C1;\n  FETCH C1 INTO :NEW.VLR_ABERTO;\n  CLOSE C1;\n  --\n  OPEN  C_FECH_CONT;\n  FETCH C_FECH_CONT INTO R_FECH_CONT;\n  CLOSE C_FECH_CONT;\n\n\n   OPEN  C_FECH_CONT1;\n  FETCH C_FECH_CONT1 INTO R_FECH_CONT1;\n  CLOSE C_FECH_CONT1;\n  \n  \n  IF R_FECH_CONT.DT_FINAL > :NEW.DT_MOVIMENTO  THEN \n    \n    if nvl(r_FECH_CONT1.ind_escrita,'N') ='N' then\n    RAISE_APPLICATION_ERROR(-20501,'Movimento ja encerrado para este periodo.');\n    end if;\n  \n  END IF;\nEND;\n"}`;
    
    }
}
