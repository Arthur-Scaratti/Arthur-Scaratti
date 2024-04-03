
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPG_APROVA_TIT_LOTE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CPG_APROVA_TIT_LOTE_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FORNECEDOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISS_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISS_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_REALIZADA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ATIVO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CPG_APR_TIT_LOTE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"declare\n\nbegin\n\n IF INSERTING AND :NEW.BEG_VW_FORNECEDOR_ID IS NULL AND :NEW.BEG_CPG_TIPO_TITULO_ID IS NULL AND :NEW.DT_VCTO_INI IS NULL AND :NEW.DT_VCTO_FIM IS NULL AND\n    :NEW.DT_EMISS_INI IS NULL AND :NEW.DT_EMISS_FIM IS NULL THEN\n    \n    RAISE_APPLICATION_ERROR(-20001,\n                                'Informar pelo menos um dos parametros!');\n    \n END IF;   \n\n IF :NEW.DT_VCTO_FIM < :NEW.DT_VCTO_INI OR :NEW.DT_EMISS_FIM < :NEW.DT_EMISS_INI THEN\n   \n    RAISE_APPLICATION_ERROR(-20001,\n                                'Periodo de datas fora da ordem!');\n\n \n \n END IF;\n\n  IF (:NEW.DT_VCTO_FIM IS NOT NULL  AND :NEW.DT_VCTO_INI IS NULL )OR (:NEW.DT_VCTO_FIM IS NULL  AND :NEW.DT_VCTO_INI IS NOT NULL )\n     OR (:NEW.DT_EMISS_FIM IS NOT NULL AND :NEW.DT_EMISS_INI IS NULL) OR (:NEW.DT_EMISS_FIM IS NULL AND :NEW.DT_EMISS_INI IS NOT NULL) THEN\n   \n    RAISE_APPLICATION_ERROR(-20001,\n                                'Informar data inicial e data final!');\n\n \n \n END IF;\n\n\nend;\n"}`;
    
        [NotMapped]
        public string Trigger_DIE_TRG_AI_APR_TITLOTE { get; set; } = `{"triggering_event":"INSERT","trigger_body":"DECLARE\n\n  CURSOR C1 IS\n    SELECT T.*\n      FROM BEG_CPG_TITULO T\n     WHERE T.BEG_VW_FORNECEDOR_ID =\n           NVL(:NEW.BEG_VW_FORNECEDOR_ID, T.BEG_VW_FORNECEDOR_ID)\n       AND T.BEG_CPG_TIPO_TITULO_ID =\n           NVL(:NEW.BEG_CPG_TIPO_TITULO_ID, T.BEG_CPG_TIPO_TITULO_ID)\n       AND T.DOCSTATUS = 'WC'\n       AND T.DT_VCTO BETWEEN NVL(:NEW.DT_VCTO_INI, T.DT_VCTO) AND\n           NVL(:NEW.DT_VCTO_FIM, T.DT_VCTO)\n       AND T.DT_EMISSAO BETWEEN NVL(:NEW.DT_EMISS_INI, T.DT_EMISSAO) AND\n           NVL(:NEW.DT_EMISS_FIM, T.DT_EMISSAO);\n\nBEGIN\n\n  FOR X IN C1 LOOP\n  \n    INSERT INTO DIE_CPG_APROVA_TITULOS\n      (DIE_CPG_APROVA_TITULOS_ID,\n       AD_CLIENT_ID,\n       AD_ORG_ID,\n       ISACTIVE,\n       VALUE,\n       CREATED,\n       CREATEDBY,\n       UPDATED,\n       UPDATEDBY,\n       DIE_CPG_APROVA_TIT_LOTE_ID,\n       BEG_VW_FORNECEDOR_ID,\n       BEG_CPG_TITULO_ID,\n       DT_EMISSAO,\n       DT_VCTO,\n       VLR_TITULO\n       )\n    VALUES\n      (BEG_FNC_AD_SEQUENCE('DIE_CPG_APROVA_TITULOS'),\n       X.AD_CLIENT_ID,\n       X.AD_ORG_ID,\n       :NEW.IND_ATIVO, --ISACTIVE                   ,\n       X.VALUE,\n       :NEW.CREATED,\n       :NEW.CREATEDBY,\n       :NEW.UPDATED,\n       :NEW.UPDATEDBY,\n       :NEW.DIE_CPG_APROVA_TIT_LOTE_ID,\n       X.BEG_VW_FORNECEDOR_ID,\n       X.BEG_CPG_TITULO_ID,\n       X.DT_EMISSAO,\n       X.DT_VCTO,\n       X.VLR_TITULO);\n  \n  END LOOP;\n\nEND;\n"}`;
    
    }
}
