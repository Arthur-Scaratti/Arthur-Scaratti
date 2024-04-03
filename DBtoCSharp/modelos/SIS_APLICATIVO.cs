
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class SIS_APLICATIVO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int PAF_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PAF_VERSAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PAF_NRO_CREDENCIAMENTO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string PAF_NOME_COMERCIAL { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string PAF_NOME_EMPRESA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PAF_CNPJ_DESENVOLVEDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ATIVO { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_SIS_APLICATIVO { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n:new.paf_id := beg_fnc_ad_sequence('SIS_APLICATIVO');\n\nend;\n"}`;
    
    }
}
