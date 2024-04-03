
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PARAMETROS_FIL
    {
            [StringLength(1)]
        /// <summary>
        /// Indica que a loja esta utilizando o novo simulador
        /// </summary>
        public string IND_SIM_NOVO { get; set; }
        
        /// <summary>
        /// Data em que o PDV foi implantado na loja
        /// </summary>
        public string IMPLANTACAO_PDV { get; set; }
        
        /// <summary>
        /// Percentual paga ao cobrador para montagem interna ( estoque)
        /// </summary>
        public int PERC_MON_INTERNA { get; set; }
        
        /// <summary>
        /// Percentual paga ao cobrador para montagem externa ( OM gerada sobre venda)
        /// </summary>
        public int PERC_MON_EXTERNA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PARAMETROS_FIL_ID { get; set; }
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
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica que a loja possui gerente comercial.
        /// </summary>
        public string IND_GERENTE_LJ { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica que a loja nao aprova pedidos de cvenda a crediario.
        /// </summary>
        public string IND_APROVA_MTZ { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica que a loja está no controle de vendas de seguro.
        /// </summary>
        public string IND_OBRIGA_SEGURO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Indica que a loja possui entrega direta pelo CD.
        /// </summary>
        public string IND_ENTREGA_DIRETA { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIUD_DIE_PARAMETROS_FIL { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"DECLARE\n\n  CURSOR C1 IS\n  SELECT A.*\n   FROM AD_ORG A\n WHERE A.AD_ORG_ID = :NEW.AD_ORG_ID;\n R1 C1%ROWTYPE;\n\n BEGIN\n\n\n IF INSERTING OR UPDATING THEN\n\n   OPEN C1;\n   FETCH C1\n   INTO R1;\n   CLOSE C1;\n\n   :NEW.VALUE := R1.VALUE;\n\n END IF;\n\n\n\n\n END;\n"}`;
    
    }
}
