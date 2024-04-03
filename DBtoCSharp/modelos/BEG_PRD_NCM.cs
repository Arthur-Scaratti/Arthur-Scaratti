
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_NCM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_NCM_ID { get; set; }
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
    [StringLength(2000)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_NCM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_IPI { get; set; }
            [StringLength(40)]
        /// <summary>
        /// codigo da ncm nova 
        /// </summary>
        public string DIE_NCM_NOVO { get; set; }
            [Required]
        /// <summary>
        /// Margem de Valor Agregado
        /// </summary>
        public int MVA { get; set; }
            [Required]
        /// <summary>
        /// Aliquota para calculo do imposto produto nacional ( tabela IBPT)
        /// </summary>
        public int ALIQ_NACIONAL { get; set; }
            [Required]
        /// <summary>
        /// Aliquota para calculo do imposto produto importado ( tabela IBPT)
        /// </summary>
        public int ALIQ_IMPORTADO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CEST { get; set; }
            [StringLength(10)]
        /// <summary>
        /// Codigo de beneficio fiscal da ST
        /// </summary>
        public string CBENEF { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_PRD_NCM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  WVAR      varchar2(1);\n  OMENSAGEM varchar2(250);\n  --\n  VC_MASCARA BEG_PARAMETRO_SISTEMA.CARACTER%type;\n  VC_MASCARA_CEST BEG_PARAMETRO_SISTEMA.CARACTER%type;\n\n  ---\n  V_NCM varchar2(10);\n  V_CEST varchar2(9);\nbegin\n\n  if NVL(:new.DESC_NCM, '^') != '^' then\n    :new.DESC_NCM := BEG_PCK_UTIL.CONVERTE_ACENTOS(UPPER(:new.DESC_NCM));\n  end if;\n\n  -- Busca a mascara dos parametros\n  VC_MASCARA := BEG_FNC_RETORNA_PARAM_GERAL('Produto', null, 'NCM');\n\n  if VC_MASCARA is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Mascara n?o parametrizada para o NCM!');\n  end if;\n\n  V_NCM := :new.value;\n  if INSTR(V_NCM, '.') <> 5 then\n    RAISE_APPLICATION_ERROR(-20001, 'Mascara invalida 1');\n  end if;\n  V_NCM := SUBSTR(V_NCM, 6);\n  if INSTR(V_NCM, '.') <> 3 then\n    RAISE_APPLICATION_ERROR(-20001, 'Mascara invalida 2');\n  end if;\n  V_NCM := SUBSTR(V_NCM, 4);\n  if LENGTH(V_NCM) <> 2 then\n    RAISE_APPLICATION_ERROR(-20001, 'Mascara invalida 3' || LENGTH(V_NCM));\n  end if;\n  -- Busca masrcara CEST\n  VC_MASCARA_CEST := BEG_FNC_RETORNA_PARAM_GERAL('Produto', null, 'CEST');\n\n  if VC_MASCARA_CEST is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Mascara n?o parametrizada para o CEST!');\n  end if;\n\n  V_CEST := :new.Cest;\n  if INSTR(V_CEST, '.') <> 3 then\n    RAISE_APPLICATION_ERROR(-20001, 'Mascara invalida 1');\n  end if;\n  V_CEST := SUBSTR(V_CEST, 4);\n  if INSTR(V_CEST, '.') <> 4 then\n    RAISE_APPLICATION_ERROR(-20001, 'Mascara invalida 2');\n  end if;\n  --\n  if OMENSAGEM is not null then\n    RAISE_APPLICATION_ERROR(-20001, OMENSAGEM);\n  end if;\n  --\nend TRG_BIU_BEG_PRD_NCM;\n"}`;
    
    }
}
