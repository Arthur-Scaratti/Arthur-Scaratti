
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRD_PROD_ENCOMENDA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_PROD_ENCOMENDA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_MARCA_ID { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string COR { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCIA { get; set; }
            [Required]
    [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string VOLTAGEM { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string PRECO_LISTA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string PRAZO_ENTREGA { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_FABRICANTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
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
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }

    }
}
