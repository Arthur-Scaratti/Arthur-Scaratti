
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_HST_NOTA_FISCAL
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do hist.dos vinculos entre nfs
        /// </summary>
        public int BEG_HST_NOTA_FISCAL_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// Filial
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo - Y ou N (yes or no)
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// Data da criacao do registro
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que criou o registro
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// Data da ultima alteracao do registro
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// Usuario que fez a ultima alteracao do registro
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// Id da NF saida
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }
        
        /// <summary>
        /// Id do item da NF saida
        /// </summary>
        public int BEG_FAT_NFS_ITEM_ID { get; set; }
        
        /// <summary>
        /// Id da NF entrada
        /// </summary>
        public int BEG_CPR_NFE_ID { get; set; }
        
        /// <summary>
        /// Id do item da nf entrada
        /// </summary>
        public int BEG_CPR_NFE_ITEM_ID { get; set; }
        
        /// <summary>
        /// Quantidade total do item
        /// </summary>
        public int QTD_TOTAL { get; set; }
        
        /// <summary>
        /// Quantidade total devolvida do item
        /// </summary>
        public int QTD_DEVOLVIDA { get; set; }
        
        /// <summary>
        /// Quantidade faltante 
        /// </summary>
        public int QTD_FALTANTE { get; set; }
        
        /// <summary>
        /// Id do produto
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// Id do sku do produto
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }

    }
}
