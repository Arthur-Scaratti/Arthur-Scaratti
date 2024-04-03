
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_TAXA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_TAXA_ID { get; set; }
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
        /// 
        /// </summary>
        public int BEG_CAR_BANDEIRA_ID { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CAR_TIPO_VENDA_ID { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string REDE_AUTORIZADA { get; set; }
            [Required]
    [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string MODALIDADE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TAXA_AVISTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRAZO_AVISTA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int TAXA_PARC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PRAZO_PARC { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRO_MAX_PARCELA { get; set; }
            [StringLength(5)]
        /// <summary>
        /// CODIGO DO CARTAO DA TABELA DBF
        /// </summary>
        public string VALUE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string OPERACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_INI_PARCELA { get; set; }
        
        /// <summary>
        /// INDICA O PADRAO DA OPERACAO NO CADASTRO, SENDO 1-VENDA , 2-PGTO CARNE
        /// </summary>
        public int TIPO_TRANSACAO { get; set; }

        [NotMapped]
        public string Trigger_DIE_TRG_BIU_CAR_TAXA { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n\nbegin\n\n  if :new.BEG_CAR_BANDEIRA_ID != 1000004\n     and :new.BEG_CAR_TIPO_VENDA_ID = 1000001\n     and\n     (:new.TAXA_PARC > 0 or :new.PRAZO_PARC > 0 or :new.NRO_MAX_PARCELA > 0) then\n  \n    RAISE_APPLICATION_ERROR(-20002,\n                            'Este cartão só permite Taxa e Prazo à Vista e Máximo Parcela Zero!');\n  \n  end if;\n\nend DIE_TRG_BIU_CAR_TAXA;\n"}`;
    
    }
}
