
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_BCO_CONTA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CPG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string IND_CRC { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ORIGEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_CPG_CONTA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_LOTE_CONVENIO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_INTEGRACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_BLOQUEIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_CONTA_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_CONTA_ID { get; set; }
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
        /// 
        /// </summary>
        public int NIVEL_CONTA { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_CONTA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTA_CONTABIL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_EXPORTADOR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_RATEIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_BEG_FIN_BCO_CONTA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  /*-------------------------------------------------------------------------------------------------\n  Objetivo(s)..: Trigger que valida a mascara da conta cadastrada para os movimentos de caixa.\n  Modulo.......: FIN - Financeiro\n  Analista.....: Tiago Gabriel\n  Alterac?es:\n  Data        Desenvolvedor  Alterac?o\n  17/08/2006  Tiago Gabriel  Criac?o.\n  -------------------------------------------------------------------------------------------------*/\n  VC_MSG_ERRO varchar2(200);\n  VC_MASCARA  BEG_PARAMETRO_SISTEMA.CARACTER%type;\n\nbegin\n  -- Busca a mascara dos parametros\n  VC_MASCARA := BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                            'Caixa',\n                                            'MASCARA_CONTA_CX');\n\n  if VC_MASCARA is null then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Mascara n?o parametrizada para o movimento de caixa!');\n  end if;\n\n  -- Procedure para validac?o\n  BEG_VALIDA_CONTAS(:new.value,\n                    VC_MASCARA,\n                    :new.TP_CONTA,\n                    :new.NIVEL_CONTA,\n                    VC_MSG_ERRO);\n\n  if VC_MSG_ERRO is not null then\n    RAISE_APPLICATION_ERROR(-20001, VC_MSG_ERRO);\n  end if;\n  if :new.BEG_VW_FIN_BCO_CONTA_id = :new.BEG_FIN_BCO_CONTA_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Conta pai nao pode ser igual a conta filha');\n  end if;\nend TRG_BIU_BEG_FIN_BCO_CONTA;\n"}`;
    
    }
}
