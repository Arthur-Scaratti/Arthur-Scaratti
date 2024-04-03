
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CHAMADO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CHAMADO_ID { get; set; }
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
    [StringLength(10)]
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
        public int AD_USER_ID { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_TELEFONE { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string MEIO_CONTATO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string SETOR { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_ABERTURA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_SOLICITACAO_CHAMADO_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string EQUIPAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PATRIMONIO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PRIORIDADE { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string SOLUCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ENCERRAMENTO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string RESPONSABILIDADE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_FECHADO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIUD_CHAMADO { get; set; } = `{"triggering_event":"INSERT OR UPDATE OR DELETE","trigger_body":"BEGIN\n\n IF INSERTING OR UPDATING  THEN\n   \n  IF :NEW.IND_FECHADO = 'Y' AND trim(:NEW.SOLUCAO) IS NULL  THEN \n    RAISE_APPLICATION_ERROR(-20001,'Não é possivel encerrar chamado sem informar solução. Verifique!'); \n\n  END IF;\n  \n  IF :NEW.IND_FECHADO = 'Y' AND  :NEW.DT_ENCERRAMENTO IS NULL THEN \n    RAISE_APPLICATION_ERROR(-20001,'Não é possivel encerrar chamado sem informar data de encerramento. Verifique!'); \n\n  END IF;\n  \n  IF :NEW.IND_FECHADO = 'Y' AND LENGTH (trim(:NEW.SOLUCAO)) < 10  THEN \n    RAISE_APPLICATION_ERROR(-20001,'Não é possivel encerrar chamado com menos de 10 caracteres na solução. Verifique!');\n    \n    END IF;\n     \n    IF nvl(LENGTH (trim(:NEW.Descricao)),0) < 10  THEN \n    RAISE_APPLICATION_ERROR(-20001,'Não é possivel encerrar chamado com menos de 10 caracteres na descrição. Verifique!');\n    \n    END IF;\n    \n END IF;\n\n END ;\n"}`;
    
    }
}
