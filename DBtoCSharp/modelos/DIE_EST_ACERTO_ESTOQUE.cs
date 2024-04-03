
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_EST_ACERTO_ESTOQUE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_EST_ACERTO_ESTOQUE_ID { get; set; }
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
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_ACERTO_ESTOQUE { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n\n  CURSOR C_ALMOX IS\n    SELECT A.BEG_EST_ALMOXARIFADO_ID\n      FROM BEG_EST_ALMOXARIFADO A\n     WHERE A.Ad_Org_Id = :NEW.AD_ORG_ID\n       AND A.IND_DISPONIVEL = 'Y';\n  R_ALMOX C_ALMOX%ROWTYPE;\n\n  CURSOR C1 IS\n    SELECT E.DATA\n      FROM DIE_EST_ACERTO_ESTOQUE E\n     WHERE E.DOCSTATUS = 'WC'\n       AND E.AD_ORG_ID = :NEW.AD_ORG_ID;\n  R1 C1%ROWTYPE;\n\nBEGIN\n  IF INSERTING THEN\n  \n    :NEW.DATA := TRUNC(SYSDATE);\n    \n    IF :NEW.BEG_EST_ALMOXARIFADO_ID IS NULL THEN\n  \n    OPEN C_ALMOX;\n    FETCH C_ALMOX\n      INTO R_ALMOX;\n    CLOSE C_ALMOX;\n  \n    :NEW.BEG_EST_ALMOXARIFADO_ID := R_ALMOX.BEG_EST_ALMOXARIFADO_ID;\n    \n    END IF; \n  \n    OPEN C1;\n    FETCH C1\n      INTO R1;\n    CLOSE C1;\n  \n    IF R1.DATA IS NOT NULL THEN\n    \n      raise_application_error(-20001,\n                              'Já existe um lote de acerto do dia ' ||\n                              TO_CHAR(R1.DATA, 'DD/MM/YYYY') ||\n                              ' em andamento.Verifique .');\n    \n    END IF;\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
