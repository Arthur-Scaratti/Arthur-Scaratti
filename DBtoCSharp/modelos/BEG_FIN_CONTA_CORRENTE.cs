
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FIN_CONTA_CORRENTE
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CODIGO_CONTA_ANTIGA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ACEITA_DEPOSITO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_NRDEPOSITO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
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
        /// Conta corrente
        /// </summary>
        public int CONTA_CORRENTE { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// Digito da conta corrente
        /// </summary>
        public string DIG_CTA_CORRENTE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_BANCO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_AGENCIA_ID { get; set; }

        [NotMapped]
        public string Trigger_TRG_BI_BEG_FIN_CONTA_CORRENTE { get; set; } = `{"triggering_event":"INSERT","trigger_body":"declare\n  -- local variables here\n  /*--------------------------------------------------------------------------------------\n  FUNC?0: Atualizar beg_banco_id quando for cadastrar uma conta corrente relacionado a uma\n          agencia\n  Analista: Aroldo O. Krul\n  Data:     19/05/2006\n  Desenvolvedor: Aroldo O. Krul\n  ----------------------------------------------------------------------------------------\n  Alterac?o        \n  ---------------------------------------------------------------------------------------*/\nbegin\n  select A.BEG_BANCO_ID\n    into :new.BEG_BANCO_ID\n    from BEG_AGENCIA A\n   where A.BEG_AGENCIA_ID = :new.BEG_AGENCIA_ID;\nend TRG_BI_BEG_FIN_CONTA_CORRENTE;\n"}`;
    
    }
}
