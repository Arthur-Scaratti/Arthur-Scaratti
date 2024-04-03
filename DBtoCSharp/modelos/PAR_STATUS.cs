
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PAR_STATUS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int STATUS_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS_DESCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ATIVO { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_PAR_STATUS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n:new.status_id := beg_fnc_ad_sequence('PAR_STATUS');\n\nend;\n"}`;
    
    }
}
