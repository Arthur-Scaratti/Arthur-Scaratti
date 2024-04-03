
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_AVISO
    {
        
        /// <summary>
        /// Indica que o aviso sera gerado
        /// </summary>
        public string IND_GERAR_AVISO { get; set; }
        
        /// <summary>
        /// Indica que o aviso é de recuperacao de crédito
        /// </summary>
        public string IND_RECUPERA_CRED { get; set; }
        
        /// <summary>
        /// valor parametro inicial
        /// </summary>
        public int VLR_PARAM_INICIAL { get; set; }
        
        /// <summary>
        /// Valor parametro final
        /// </summary>
        public int VLR_PARAM_FINAL { get; set; }
            [Required]
        /// <summary>
        /// Indicar negativar o cliente (SPC)
        /// </summary>
        public string IND_NEGATIVAR { get; set; }
            [Required]
        /// <summary>
        /// Se estiver desmarcado,  será gerado o aviso, mas não será enviado para o cliente
        /// </summary>
        public string IND_ENVIAR { get; set; }
            [Required]
        /// <summary>
        /// Numero do aviso
        /// </summary>
        public int VALUE { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// Descricao do aviso
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do aviso
        /// </summary>
        public int BEG_COB_AVISO_ID { get; set; }
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
        /// Numero de dias inicial
        /// </summary>
        public int DIAS_INICIAL { get; set; }
            [Required]
        /// <summary>
        /// Numero de dias finais
        /// </summary>
        public int DIAS_FINAL { get; set; }
            [Required]
    [StringLength(600)]
        /// <summary>
        /// Texto do aviso
        /// </summary>
        public string TEXTO_AVISO { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_COB_AVISO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  if :new.IND_GERAR_AVISO = :new.IND_RECUPERA_CRED then\n    if :new.IND_GERAR_AVISO = 'Y'\n       and :new.IND_RECUPERA_CRED = 'Y' then\n      RAISE_APPLICATION_ERROR(-20001,\n                              'Escolha uma alternativa - Gerar Aviso Cobrança ou Recuperacao Credito?');\n    end if;\n  end if;\n  if UPDATING('ind_gerar_aviso')\n     and :new.IND_GERAR_AVISO = 'N' then\n    :new.IND_ENVIAR    := 'N';\n    :new.IND_NEGATIVAR := 'N';\n  end if;\nend BEG_TRG_BIU_COB_AVISO;\n"}`;
    
    }
}
