
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_TPMOV
    {
            [StringLength(5)]
        /// <summary>
        /// Codigo da conta contabil de contrapartida para este tipo de movimento
        /// </summary>
        public string CONTRA_PARTIDA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// ID do tipo de movimento
        /// </summary>
        public int BEG_CPG_TPMOV_ID { get; set; }
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
        /// Codigo do tipo de movimento
        /// </summary>
        public int VALUE { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// Descric?o do tipo de movimento
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indicador de debito ou credito do tipo de movimento
        /// </summary>
        public string DEBITO_CREDITO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica se historicos deste tipo de movimento saem na listagem do diario auxiliar
        /// </summary>
        public string DIARIO_AUXILIAR { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indicador de movimento: P - Parcial / L - Liquidac?o / T - Total
        /// </summary>
        public string IND_MOV { get; set; }

        [NotMapped]
        public string Trigger_TRG_BD_BEG_CPG_TPMOV { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  VN_BEG_CPG_TPMOV_ID BEG_CPG_TPMOV.BEG_CPG_TPMOV_ID%type;\n\nbegin\n  VN_BEG_CPG_TPMOV_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                               'Contas a Pagar',\n                                                               'TPMOV_LIQ_RENEG_C'));\n\n  if VN_BEG_CPG_TPMOV_ID = :old.BEG_CPG_TPMOV_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo de movimento parametrizado como liquidac?o para renegociac?o a credito!');\n  end if;\n\n  VN_BEG_CPG_TPMOV_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                               'Contas a Pagar',\n                                                               'TPMOV_TOT_RENEG_C'));\n\n  if VN_BEG_CPG_TPMOV_ID = :old.BEG_CPG_TPMOV_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo de movimento parametrizado como baixa total para renegociac?o a credito!');\n  end if;\n\n  VN_BEG_CPG_TPMOV_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                               'Contas a Pagar',\n                                                               'TPMOV_LIQ_RENEG_D'));\n\n  if VN_BEG_CPG_TPMOV_ID = :old.BEG_CPG_TPMOV_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo de movimento parametrizado como liquidac?o para renegociac?o a debito!');\n  end if;\n\n  VN_BEG_CPG_TPMOV_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAM_GERAL('Financeiro',\n                                                               'Contas a Pagar',\n                                                               'TPMOV_TOT_RENEG_D'));\n\n  if VN_BEG_CPG_TPMOV_ID = :old.BEG_CPG_TPMOV_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Tipo de movimento parametrizado como baixa total para renegociac?o a debito!');\n  end if;\n\nend TRG_BD_BEG_CPG_TPMOV;\n"}`;
    
    }
}
