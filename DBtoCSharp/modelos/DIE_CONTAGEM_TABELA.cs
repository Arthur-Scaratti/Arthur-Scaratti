
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONTAGEM_TABELA
    {
            [Required]
    [StringLength(20)]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_BEG_PESSOA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIFERENCA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CONTAGEM { get; set; }
            [Required]
    [StringLength(30)]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string TABELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_TIT1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_TIT2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TIT1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TIT2 { get; set; }

    }
}
