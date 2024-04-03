
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PARCELA_CONDICAO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PARCELA_CONDICAO_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PORCENTAGEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIA_DESCONTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIAS_VENCIMENTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONDICAO_PAGAMENTO_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BEG_PARC_COND_BIU { get; set; } = `{"triggering_event":"INSERT OR UPDATE","trigger_body":"begin\n\n  if :new.PORCENTAGEM = 0 then\n  \n    RAISE_APPLICATION_ERROR(-20001,\n                            'PERCENTUAL DA PARCELA NAO PODE SER ZERO !');\n  \n  end if;\n\n  update BEG_CONDICAO_PAGAMENTO BCP\n     set BCP.ISACTIVE = 'N'\n   where BCP.BEG_CONDICAO_PAGAMENTO_ID = :new.BEG_CONDICAO_PAGAMENTO_ID;\n\nend TRG_BEG_PESSOA_NAME_BIU;\n"}`;
    
    }
}
