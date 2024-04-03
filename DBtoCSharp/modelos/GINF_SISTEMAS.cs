
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class GINF_SISTEMAS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int SIS_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string SIS_PROGRAMA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string SIS_VERSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SIS_DATA_VERSAO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string SIS_OBSERVACOES { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SIS_DATA_LIMITE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string SIS_CHANGE_LOG { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_GINF_SISTEMAS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n:new.sis_id := beg_fnc_ad_sequence('GINF_SISTEMAS');\n\nend;\n"}`;
    
    }
}
