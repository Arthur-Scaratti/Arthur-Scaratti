
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_COMERCIAL_CLASS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GPR_DADOS_VENDA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_COMERCIAL_CLASS_ID { get; set; }
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
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_CONTA { get; set; }
            [Required]
    [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NIVEL_CONTA { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_CLASSE { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_PRD_COML_CLASS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  OMENSAGEM varchar2(250);\n  --\n  VC_MASCARA BEG_PARAMETRO_SISTEMA.CARACTER%type;\n  \n  \n\n\nbegin\n  -- Busca a mascara dos parametros\n  VC_MASCARA := BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                          :new.AD_ORG_ID,\n                                          'Geral',\n                                          null,\n                                          'CLASSIFICACAO_COMERCIAL');\n\n  if VC_MASCARA is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Mascara n?o parametrizada para a classificac?o comercial!');\n  end if;\n\n  :NEW.DESCRICAO := upper(FNC_BEG_REMOVE_CE(:NEW.DESCRICAO));\n\n  --\n  -- Procedure para validac?o das contas - ver beg_parametro_sistema.\n  --\n  /*\n  OMENSAGEM := null;\n  BEG_VALIDA_CONTAS(:new.AD_CLIENT_ID, -- PADCLIENT\n                    :new.AD_ORG_ID, -- PADORG\n                    :new.value,\n                    'CLASSIFICACAO_COMERCIAL',\n                    :new.TP_CONTA,\n                    :new.NIVEL_CONTA,\n                    OMENSAGEM);*/\n\n  -- Altera a chamada da procedure\n  BEG_VALIDA_CONTAS(:new.value,\n                    VC_MASCARA,\n                    :new.TP_CONTA,\n                    :new.NIVEL_CONTA,\n                    OMENSAGEM);\n\n  --\n  if OMENSAGEM is not null then\n    RAISE_APPLICATION_ERROR(-20001, OMENSAGEM);\n  end if;\n  --\n\n  -- Nivel da conta\n  if :new.NIVEL_CONTA = 1 then\n    if :new.IND_CLASSE is null then\n      RAISE_APPLICATION_ERROR(-20002,\n                              'E obrigatorio informar Indicador para Classe para este nivel de conta');\n    end if;\n  else\n    if :new.IND_CLASSE is not null then\n      RAISE_APPLICATION_ERROR(-20002,\n                              'Indicador para Classe não pode ser informado para este nivel de conta');\n    end if;\n  end if;\n  --\nend TRG_BIU_BEG_PRD_COML_CLASS;\n"}`;
    
    }
}
