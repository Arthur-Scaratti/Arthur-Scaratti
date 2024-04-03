
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_CC_CONTA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CC_CONTA_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// Nivel da conta de acordo com a mascara (atualizado via trigger)
        /// </summary>
        public int NIVEL_CONTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo de conta: A - Analitica / S - Sintetica (atualizado via trigger)
        /// </summary>
        public string TP_CONTA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTA_CONTABIL { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FIN_CC_CONTA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*-------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida a mascara da conta cadastrada para os movimentos de CC.\n  Modulo.......: FIN - Financeiro\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  17/08/2006  Tiago Gabriel  Criac?o.\n  -------------------------------------------------------------------------------------------------*/\n  VC_MSG_ERRO varchar2(200);\n  VC_MASCARA  BEG_PARAMETRO_SISTEMA.CARACTER%type;\n\nbegin\n  -- Busca a mascara dos parametros\n  VC_MASCARA := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                            'Contas Correntes',\n                                            'MASCARA_CONTA_CC');\n\n  if VC_MASCARA is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Mascara n?o parametrizada para o moviento de conta corrente!');\n  end if;\n\n  -- Procedure para validac?o\n  BEG_VALIDA_CONTAS(:new.value,\n                    VC_MASCARA,\n                    :new.TP_CONTA,\n                    :new.NIVEL_CONTA,\n                    VC_MSG_ERRO);\n\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n\nend TRG_BIU_BEG_FIN_CC_CONTA;\n"}`;
    
    }
}
