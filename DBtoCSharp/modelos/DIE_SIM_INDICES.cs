
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_SIM_INDICES
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_SIM_INDICES_ID { get; set; }
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
        public int NR_PARCELAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_FINANCEIRA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int INDICE { get; set; }
        
        /// <summary>
        /// Para vendas financeira que determina o vcto da 1ª parcela
        /// </summary>
        public int DIAS_CARENCIA { get; set; }
        
        /// <summary>
        /// Taxa de juros aplicada no indice
        /// </summary>
        public int TAXA { get; set; }

    }
}
