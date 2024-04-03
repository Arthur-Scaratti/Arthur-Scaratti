
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PRD_NBM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_NBM_ID { get; set; }
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
    [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_NBM { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_PRD_NBM { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  --\n  WVAR      varchar2(1);\n  OMENSAGEM varchar2(250);\n  --\n  VC_MASCARA BEG_PARAMETRO_SISTEMA.CARACTER%type;\n\nbegin\n  -- Busca a mascara dos parametros\n  VC_MASCARA := BEG_FNC_RETORNA_PARAMETRO(:new.AD_CLIENT_ID,\n                                          :new.AD_ORG_ID,\n                                          'Geral',\n                                          null,\n                                          'NBM');\n\n  if VC_MASCARA is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Mascara nao parametrizada para o NBM!');\n  end if;\n\n  -- Altera a chamada da procedure\n  BEG_VALIDA_CONTAS(:new.value, VC_MASCARA, WVAR, WVAR, OMENSAGEM);\n\n  --\n  if OMENSAGEM is not null then\n    RAISE_APPLICATION_ERROR(-20001, OMENSAGEM);\n  end if;\n  --\nend TRG_BIU_BEG_PRD_NBM;\n"}`;
    
    }
}
