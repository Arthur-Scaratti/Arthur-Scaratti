
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_MONTAGEM_INTERNA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_MONTAGEM_INTERNA_ID { get; set; }
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
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PREVISAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_BAIXA { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int NRMONTAGEM { get; set; }
            [Required]
    [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// Percentual paga ao cobrador para montagem interna ( estoque) - TABELA DIE_PARAMETROS_FIL ( PERC_MON_INTERNA ) 
        /// </summary>
        public int PERC_MONTAGEM { get; set; }

        [NotMapped]
        public string Trigger_TRG_BI_DIE_FAT_MONT_INTERNA { get; set; } = `{"triggering_event":"INSERT","trigger_body":"BEGIN\n\n\n\n  :NEW.DOCSTATUS := 'WC';\n\n\nEND;\n"}`;
    
    }
}
