
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_FISCAL_CLASS
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NIVEL_CONTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_CONTA { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_FISCAL_CLASS_ID { get; set; }
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

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_PRD_FISCAL_CLASS { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  OMENSAGEM varchar2(250);\n  --\n  VC_MASCARA BEG_PARAMETRO_SISTEMA.CARACTER%type;\n\nbegin\n  -- Busca a mascara dos parametros\n  VC_MASCARA := BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                          :new.AD_ORG_ID,\n                                          'Geral',\n                                          null,\n                                          'CLASSIFICACAO_FISCAL');\n\n  if VC_MASCARA is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Mascara n?o parametrizada para a classificac?o fiscal!');\n  end if;\n\n  --\n  -- Procedure para validac?o das contas - ver beg_parametro_sistema.\n  --\n  /*\n  OMENSAGEM := null;\n  BEG_VALIDA_CONTAS(:new.AD_CLIENT_ID, -- PADCLIENT\n                    :new.AD_ORG_ID, -- PADORG\n                    :new.value, -- PCODIGO\n                    'CLASSIFICACAO_FISCAL', -- PSISTEMA\n                    :new.TP_CONTA, -- PTIPO\n                    :new.NIVEL_CONTA, -- PNIVEL\n                    OMENSAGEM); -- PMENSAGEM*/\n\n  -- Altera a chamada da procedure\n  BEG_VALIDA_CONTAS(:new.value, -- PCODIGO\n                    VC_MASCARA, -- PSISTEMA\n                    :new.TP_CONTA, -- PTIPO\n                    :new.NIVEL_CONTA, -- PNIVEL\n                    OMENSAGEM); -- PMENSAGEM*/\n\n  --\n  if OMENSAGEM is not null then\n    RAISE_APPLICATION_ERROR(-20001, OMENSAGEM);\n  end if;\n  --\nend TRG_BIU_BEG_PRD_FISCAL_CLASS;\n"}`;
    
    }
}
