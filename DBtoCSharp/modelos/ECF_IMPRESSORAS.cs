
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ECF_IMPRESSORAS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int ECF_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ECF_NUMERO_SERIE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ECF_CNPJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LOJA_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ECF_TIPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ECF_NUMERO_CAIXA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ECF_MARCA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ECF_MODELO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ECF_VERSAO_FIRMWARE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ECF_NRO_CREDENCIAMENTO_PAF { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ATIVO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ECF_ULTIMA_ATUALIZACAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ECF_ULTIMO_MOVIMENTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ECF_UTIMA_REDUCAO { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_ECF_IMPRESSORAS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n:new.ecf_id := beg_fnc_ad_sequence('ECF_IMPRESSORAS');\n\nend;\n"}`;
    
    }
}
