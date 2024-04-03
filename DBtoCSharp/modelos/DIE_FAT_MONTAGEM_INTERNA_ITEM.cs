
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_MONTAGEM_INTERNA_ITEM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_MONTAGEM_INT_ITEM_ID { get; set; }
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
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_UNITARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_MONTAGEM_INTERNA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_MON_INTERNA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_DIE_FAT_MONT_INT_ITEM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n\n  V_GR_ID NUMBER(10);\n\n  CURSOR C_PROD IS\n    SELECT SK.BEG_PRD_SKU_ID\n      FROM BEG_PRD_SKU SK\n     WHERE SK.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID\n       AND SK.ISACTIVE = 'Y';\n  R_PROD C_PROD%ROWTYPE;\n\n  CURSOR C_GRUPO IS\n    SELECT (G.PERC_MAX_DESCONTO_VENDA + G.PER_DESC_GERENTE) PER_DESC\n      FROM DIE_PRD_GRUPO G, BEG_PRODUTO P\n     WHERE G.DIE_PRD_GRUPO_ID = P.DIE_PRD_GRUPO_ID\n       AND P.BEG_PRODUTO_ID = :NEW.BEG_PRODUTO_ID;\n  R_GRUPO C_GRUPO%ROWTYPE;\n\n  CURSOR C_PERC IS\n    SELECT F.PERC_MON_INTERNA\n      FROM DIE_PARAMETROS_FIL F\n     WHERE F.AD_ORG_ID = :NEW.AD_ORG_ID;\n  R_PERC C_PERC%ROWTYPE;\n\nBEGIN\n\n  IF NVL(:NEW.VLR_UNITARIO, 0) = 0 OR\n     (UPDATING AND :NEW.BEG_PRODUTO_ID <> :OLD.BEG_PRODUTO_ID) THEN\n\n    OPEN C_PROD;\n    FETCH C_PROD\n      INTO R_PROD;\n    CLOSE C_PROD;\n\n    OPEN C_GRUPO;\n    FETCH C_GRUPO\n      INTO R_GRUPO;\n    CLOSE C_GRUPO;\n\n    :NEW.VLR_UNITARIO := BEG_FNC_PRD_PRECO(0,\n                                           :NEW.BEG_PRODUTO_ID,\n                                           R_PROD.BEG_PRD_SKU_ID,\n                                           NULL,\n                                           'C',\n                                           SYSDATE);\n\n    :NEW.VLR_UNITARIO := :NEW.VLR_UNITARIO -\n                         ROUND(:NEW.VLR_UNITARIO * (R_GRUPO.PER_DESC / 100),\n                               2);\n\n    OPEN C_PERC;\n    FETCH C_PERC\n      INTO R_PERC;\n    CLOSE C_PERC;\n\n    :NEW.PERC_MON_INTERNA := R_PERC.PERC_MON_INTERNA;\n\n  END IF;\n\nEND;\n"}`;
    
    }
}
