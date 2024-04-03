
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_EST_ALMOXARIFADO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
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
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ALMOXARIFADO_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica almoxarifado disponivel
        /// </summary>
        public string IND_DISPONIVEL { get; set; }

        [NotMapped]
        public string Trigger_TRG_BD_BEG_EST_ALMOXARIFADO { get; set; } = `{"triggering_event":"DELETE","trigger_body":"declare\n  VN_BEG_EST_ALMOXARIFADO_ID BEG_EST_ALMOXARIFADO.BEG_EST_ALMOXARIFADO_ID%type;\n\nbegin\n  VN_BEG_EST_ALMOXARIFADO_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:old.AD_CLIENT_ID,\n                                                                    :old.AD_ORG_ID,\n                                                                    'Estoque',\n                                                                    null,\n                                                                    'ALMOXARIFADO_INSPECAO'));\n\n  if VN_BEG_EST_ALMOXARIFADO_ID = :old.BEG_EST_ALMOXARIFADO_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Almoxarifado parametrizado como almoxarifado de inspec?o!');\n  end if;\n\n  VN_BEG_EST_ALMOXARIFADO_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:old.AD_CLIENT_ID,\n                                                                    :old.AD_ORG_ID,\n                                                                    'Estoque',\n                                                                    null,\n                                                                    'ALMOXARIFADO_LIBERACAO'));\n\n  if VN_BEG_EST_ALMOXARIFADO_ID = :old.BEG_EST_ALMOXARIFADO_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Almoxarifado parametrizado como almoxarifado de liberac?o!');\n  end if;\n\n  VN_BEG_EST_ALMOXARIFADO_ID := TO_NUMBER(BEG_FNC_RETORNA_PARAMETRO(:old.AD_CLIENT_ID,\n                                                                    :old.AD_ORG_ID,\n                                                                    'Estoque',\n                                                                    'Faturamento',\n                                                                    'ALMOXARIFADO_FATURAMENTO'));\n\n  if VN_BEG_EST_ALMOXARIFADO_ID = :old.BEG_EST_ALMOXARIFADO_ID then\n    RAISE_APPLICATION_ERROR(-20001,\n                            'Almoxarifado parametrizado como almoxarifado de faturamento!');\n  end if;\n\nend TRG_BD_BEG_EST_ALMOXARIFADO;\n"}`;
    
    }
}
