
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_RESTRICAO
    {
            [Required]
        /// <summary>
        /// Bloqueia a geracao de aviso
        /// </summary>
        public string DIE_BLOQ_GERA_AVISO { get; set; }
            [Required]
        /// <summary>
        /// Bloqueia a geracao de dados para cobranca
        /// </summary>
        public string DIE_BLOQ_GERA_COBRANCA { get; set; }
        
        /// <summary>
        /// Elimina divegencias da cobranca
        /// </summary>
        public string DIE_ELIMINA_DIVERGENCIA { get; set; }
            [Required]
        /// <summary>
        /// Bloqueia a geracao de envio para o SPC
        /// </summary>
        public string DIE_BLOQ_GERA_SPC { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id da restricao
        /// </summary>
        public int BEG_RESTRICAO_ID { get; set; }
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
    [StringLength(50)]
        /// <summary>
        /// Descricao da restricao
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// Bloqueia venda
        /// </summary>
        public string BLOQUEIA_VENDA { get; set; }
        
        /// <summary>
        /// Forma de pagamento 
        /// </summary>
        public int BEG_VEN_FORMA_PAGAMENTO_ID { get; set; }

        [NotMapped]
        public string Trigger_BEG_TRG_BIU_RESTRICAO { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"declare\n  -- local variables here\nbegin\n  --\n  :new.DESCRICAO := UPPER(BEG_PCK_UTIL.CONVERTE_ACENTOS(:new.DESCRICAO));\n  --\nend BEG_TRG_BIU_RESTRICAO;\n"}`;
    
    }
}
