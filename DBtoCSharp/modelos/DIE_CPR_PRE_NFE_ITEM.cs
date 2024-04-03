
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPR_PRE_NFE_ITEM
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int ALQ_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_OUTROS_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ICMS_SUBST { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE_ISENTO_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ICMS_SUBST { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CPR_PRE_NFE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_ATENDIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_HST_NOTA_FISCAL_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CPR_PRE_NFE_ITEM_ID { get; set; }
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
        public int SEQUENCIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_UNITARIO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BI_CPR_PRE_NFE_ITEM { get; set; } = `{"triggering_event":"UPDATE","trigger_body":"DECLARE\n\nBEGIN\n\n  IF :NEW.ISACTIVE = 'N' AND :OLD.ISACTIVE = 'N' AND :NEW.QTD_ATENDIDA > 0 THEN\n  \n    :NEW.ISACTIVE := 'Y';\n  \n  END IF;\n\n  IF :NEW.ISACTIVE = 'Y' AND :NEW.QTD_ATENDIDA = 0 THEN\n  \n    RAISE_APPLICATION_ERROR(-20501,\n                            'Faltou informar a quantidade de produtos que retornou');\n  \n  END IF;\n\n  IF :NEW.QTD_ATENDIDA > :NEW.QTD THEN\n  \n    RAISE_APPLICATION_ERROR(-20501,\n                            'Quantidade de retorno não pode ser maior que a enviada');\n  \n  END IF;\n\n  IF :NEW.ISACTIVE = 'Y' AND :OLD.ISACTIVE = 'N' THEN\n  \n    UPDATE DIE_CPR_PRE_NFE N\n       SET N.VLR_TOTAL_PRODUTOS = N.VLR_TOTAL_PRODUTOS +\n                                  (:NEW.QTD_ATENDIDA * :NEW.VLR_UNITARIO)\n    \n     WHERE N.DIE_CPR_PRE_NFE_ID = :NEW.DIE_CPR_PRE_NFE_ID;\n  \n  END IF;\n  \n  IF :NEW.QTD_ATENDIDA<> :OLD.QTD_ATENDIDA and :NEW.ISACTIVE = 'Y' AND :OLD.ISACTIVE = 'Y' THEN\n  \n\n  \n    UPDATE DIE_CPR_PRE_NFE N\n       SET N.VLR_TOTAL_PRODUTOS = N.VLR_TOTAL_PRODUTOS -\n                                  (:OLD.QTD_ATENDIDA * :OLD.VLR_UNITARIO)+(:NEW.QTD_ATENDIDA * :NEW.VLR_UNITARIO)\n    \n     WHERE N.DIE_CPR_PRE_NFE_ID = :NEW.DIE_CPR_PRE_NFE_ID;\n  \n\n  \n  END IF;\n\n  IF :NEW.ISACTIVE = 'N' AND :OLD.ISACTIVE = 'Y' THEN\n  \n\n  \n    UPDATE DIE_CPR_PRE_NFE N\n       SET N.VLR_TOTAL_PRODUTOS = N.VLR_TOTAL_PRODUTOS -\n                                  (:OLD.QTD_ATENDIDA * :OLD.VLR_UNITARIO)\n    \n     WHERE N.DIE_CPR_PRE_NFE_ID = :NEW.DIE_CPR_PRE_NFE_ID;\n  \n    :NEW.QTD_ATENDIDA := 0;\n  \n  END IF;\n   \n  \nEND;\n"}`;
    
    }
}
