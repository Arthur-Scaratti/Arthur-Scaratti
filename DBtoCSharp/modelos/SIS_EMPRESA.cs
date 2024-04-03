
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class SIS_EMPRESA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int EMP_ID { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMP_NOME { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMP_NOME_LOJA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string EMP_ENDERECO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string EMP_FONE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string EMP_CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string EMP_UF { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_SIS_EMPRESA { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n:new.emp_id := beg_fnc_ad_sequence('SIS_EMPRESA');\n\nend;\n"}`;
    
    }
}
