
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARTAO_SALDOS_CONTAB
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_SALDOS_CONTAB_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SALDO_ANT { get; set; }
            [Required]
        /// <summary>
        /// Valor total da venda
        /// </summary>
        public int VLR_VENDA { get; set; }
            [Required]
        /// <summary>
        /// Valor efetivo creditado no banco
        /// </summary>
        public int VLR_REPASSE { get; set; }
            [Required]
        /// <summary>
        /// Valor da tarifa sobr as vendas
        /// </summary>
        public int VLR_TARIFA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CANCELAMENTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_NF_SERV { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESC_DUPLICATA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SALDO_ATU { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// Valor da tarifa por antecipacao.
        /// </summary>
        public int VLR_TARIFA_ANTEC { get; set; }

        [NotMapped]
        public string Trigger_TRG_BIU_CAR_SALDOS_CONTAB { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"DECLARE\n\nBEGIN\n\n  :NEW.VLR_SALDO_ATU := :NEW.VLR_SALDO_ANT + :NEW.VLR_VENDA -\n                        :NEW.VLR_REPASSE - :NEW.VLR_TARIFA -\n                        :NEW.VLR_CANCELAMENTO - :NEW.VLR_NF_SERV -\n                        :NEW.VLR_DESC_DUPLICATA - :NEW.VLR_TARIFA_ANTEC;\n                        \n  :NEW.DATA   := LAST_DAY(:NEW.DATA);                   \n\nEND;\n"}`;
    
    }
}
