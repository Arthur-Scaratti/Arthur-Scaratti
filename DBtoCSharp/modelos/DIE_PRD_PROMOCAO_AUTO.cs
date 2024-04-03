
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRD_PROMOCAO_AUTO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_PROMOCAO_AUTO_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FIM { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIAS1 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIAS2 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIAS3 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC1 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC2 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_GRUPO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_SUBGRUPO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_COMERCIAL_CLASS_ID { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIAS4 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC4 { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// indicativo quando marcado gera uma promocao para a rede e testa os produtos sem giro/venda em todas as lojas
        /// </summary>
        public string IND_REDE { get; set; }

    }
}
