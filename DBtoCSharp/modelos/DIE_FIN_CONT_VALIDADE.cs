
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_CONT_VALIDADE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CONT_VALIDADE_ID { get; set; }
        
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
        public int DIE_FIN_CONTRATOS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FIM { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(400)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_IR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_INSS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_IR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ISSQN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_INSS { get; set; }
        
        /// <summary>
        /// Dia do primeiro vcto(faturamento)
        /// </summary>
        public string DT_VCTO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CONT_VALIDADE { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"BEGIN\n\n  IF (INSERTING OR UPDATING) AND :NEW.DOCSTATUS = 'WC' THEN\n  \n    IF :NEW.DT_FIM <= :NEW.DT_INICIO THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Data final do contrato não pode ser menor ou igual a data inicial');\n    \n    END IF;\n  \n    IF :NEW.VLR_BRUTO = 0 THEN\n    \n      RAISE_APPLICATION_ERROR(-20001,\n                              'Faltou informar o valor bruto do contrato');\n    \n    END IF;\n  \n    IF :NEW.PERC_IR > 0 THEN\n    \n      :NEW.VLR_IR := ROUND((:NEW.VLR_BRUTO * :NEW.PERC_IR) / 100, 2);\n    \n    END IF;\n  \n    IF :NEW.PERC_PIS > 0 THEN\n    \n      :NEW.VLR_PIS := ROUND((:NEW.VLR_BRUTO * :NEW.PERC_PIS) / 100, 2);\n    \n    END IF;\n  \n    IF :NEW.PERC_COFINS > 0 THEN\n    \n      :NEW.VLR_COFINS := ROUND((:NEW.VLR_BRUTO * :NEW.PERC_COFINS) / 100, 2);\n    \n    END IF;\n  \n    IF :NEW.PERC_ISSQN > 0 THEN\n    \n      :NEW.VLR_ISSQN := ROUND((:NEW.VLR_BRUTO * :NEW.PERC_ISSQN) / 100, 2);\n    \n    END IF;\n  \n    IF :NEW.PERC_INSS > 0 THEN\n    \n      :NEW.VLR_INSS := ROUND((:NEW.VLR_BRUTO * :NEW.PERC_INSS) / 100, 2);\n    \n    END IF;\n  \n    :NEW.VLR_LIQUIDO := :NEW.VLR_BRUTO - :NEW.VLR_IR - :NEW.VLR_PIS -\n                        :NEW.VLR_COFINS - :NEW.VLR_ISSQN - :NEW.VLR_INSS;\n  \n    UPDATE DIE_FIN_CONTRATOS S\n       SET S.DT_VCTO     = :NEW.DT_FIM,\n           S.PERC_IR     = :NEW.PERC_IR,\n           S.PERC_ISSQN  = :NEW.PERC_ISSQN,\n           S.PERC_PIS    = :NEW.PERC_PIS,\n           S.PERC_COFINS = :NEW.PERC_COFINS,\n           S.PERC_INSS   = :NEW.PERC_INSS,\n           S.VLR_IR      = :NEW.VLR_IR,\n           S.VLR_ISSQN   = :NEW.VLR_ISSQN,\n           S.VLR_PIS     = :NEW.VLR_PIS,\n           S.VLR_COFINS  = :NEW.VLR_COFINS,\n           S.VLR_INSS    = :NEW.VLR_INSS,\n           S.VLR_BRUTO   = :NEW.VLR_BRUTO,\n           S.VLR_LIQUIDO = :NEW.VLR_LIQUIDO,\n           S.DIA_VCTO    = :NEW.DT_VCTO,\n           S.DOCSTATUS   = :NEW.DOCSTATUS          \n     WHERE S.DIE_FIN_CONTRATOS_ID = :NEW.DIE_FIN_CONTRATOS_ID;\n  \n  END IF;\n\n  IF DELETING THEN\n  \n    IF :OLD.DOCSTATUS = 'CO' THEN\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Contrato ja processado, não pode ser excluído');\n    END IF;\n  \n    UPDATE DIE_FIN_CONTRATOS S\n       SET S.DT_VCTO     = NULL,\n           S.PERC_IR     = 0,\n           S.PERC_ISSQN  = 0,\n           S.PERC_PIS    = 0,\n           S.PERC_COFINS = 0,\n           S.PERC_INSS   = 0,\n           S.VLR_IR      = 0,\n           S.VLR_ISSQN   = 0,\n           S.VLR_PIS     = 0,\n           S.VLR_COFINS  = 0,\n           S.VLR_INSS    = 0,\n           S.VLR_BRUTO   = 0,\n           S.VLR_LIQUIDO = 0,\n           S.DIA_VCTO    = NULL\n     WHERE S.DIE_FIN_CONTRATOS_ID = :OLD.DIE_FIN_CONTRATOS_ID;\n  \n  END IF;\n\nEND;\n"}`;
    
    }
}
