
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class LOJAS
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int LOJA_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_CODIGO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_CNPJ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_IE { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_NOME { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_REDUZIDO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_ENDERECO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_NUMERO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_COMPL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_BAIRRO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_CIDADE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_UF { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_IBGE_CIDADE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA_IBGE_UF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ATIVO { get; set; }

        [NotMapped]
        public string Trigger_DIE_BI_LOJAS { get; set; } = `{"triggering_event":"INSERT","trigger_body":"begin\n\n:new.loja_id := beg_fnc_ad_sequence('LOJAS');\n\nend;\n"}`;
    
    }
}
