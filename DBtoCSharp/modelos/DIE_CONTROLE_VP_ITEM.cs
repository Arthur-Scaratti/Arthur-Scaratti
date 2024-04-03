
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CONTROLE_VP_ITEM
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CONTROLE_VP_ITEM_ID { get; set; }
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
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUMERO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPRODUTO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string SEQUENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO_FINAL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CDVENDEDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_VP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_ITEM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO_LISTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_ITEPED_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string JUSTIFICATIVA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESC_EXTRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CONT_VP_ITEN_LOJA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CONTROLE_VP_ID { get; set; }

    }
}
