
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class OPERADORES
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int OPER_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string OPER_NOME { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string OPER_USUARIO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string OPER_SENHA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string OPER_NIVEL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string OPER_SUPERVISOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string OPER_ADMINISTRADOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string OPER_TELEFONE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string OPER_FUNCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ATIVO { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_OPERADORES { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n:new.oper_id := beg_fnc_ad_sequence('OPERADORES');\n\nend;\n"}`;
    
    }
}
