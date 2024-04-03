
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VEN_LN_PRODUTO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_VEN_LN_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_VEN_LISTA_NOIVA_ID { get; set; }
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
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_VOLTAGEM_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_COR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QUANTIDADE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string ATENDIDO { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTE_ATENDIDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_PENDENTE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_VENDIDA { get; set; }

        [NotMapped]
        public string Trigger_DIE_BIU_VEN_LN_PRODUTO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\n  cursor C1 is\n    select p.*, SK.BEG_PRD_SKU_ID\n      from beg_produto p, BEG_PRD_SKU SK\n     where p.beg_produto_id = :NEW.BEG_PRODUTO_ID\n       AND SK.BEG_PRODUTO_ID = P.BEG_PRODUTO_ID\n       AND SK.ISACTIVE = 'Y';\n  R1 C1%rowtype;\n\nbegin\n\n  open C1;\n  fetch C1\n    into R1;\n  close C1;\n\n  :NEW.BEG_PRD_VOLTAGEM_ID := R1.BEG_PRD_VOLTAGEM_ID;\n  :NEW.BEG_PRD_COR_ID      := R1.BEG_PRD_COR_ID;\n  :NEW.BEG_PRD_SKU_ID      := R1.BEG_PRD_SKU_ID;\n  \n  IF :NEW.QUANTIDADE =0 THEN\n        RAISE_APPLICATION_ERROR(-20002,'Quantidade deve ser maior que zero. Verifique!!!');    \n  END IF;\n  \n  if inserting then\n  \n   :new.qtde_pendente := :new.quantidade;\n    \n  end if;\n  \n  if updating then \n  :new.qte_atendida  := :old.qte_atendida + :new.qtde_vendida;\n--  :new.qtde_pendente := :old.qtde_pendente - :new.qtde_vendida;\n  :new.qtde_pendente := :new.quantidade - :new.qte_atendida;\n  \n     if  :new.quantidade < :new.qte_atendida then \n        \n        RAISE_APPLICATION_ERROR(-20002,'Quantidade vendida não pode ser maior que a solicitada. Verifique!!!');         \n     end if;\n  \n  end if; \n\n  :new.qtde_vendida :=0;\n\nend;\n"}`;
    
    }
}
