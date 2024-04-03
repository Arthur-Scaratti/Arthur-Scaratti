
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_INS_NFE_ITEM
    {
            [Required]
    [Key]
        /// <summary>
        /// ID dos itens da nota fiscal de entrada em inspec?o
        /// </summary>
        public int BEG_INS_NFE_ITEM_ID { get; set; }
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
        /// <summary>
        /// Saldo do produto em inspec?o (atualizado a cada nota de entrada ou liberac?o). No caso de liberac?o automatica, indica a quantidade liberada
        /// </summary>
        public int QTD_SALDO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Indica que o item foi inspecionado (Y) ou liberado automaticamente (N)
        /// </summary>
        public string IND_INSPECIONADO { get; set; }
            [Required]
        /// <summary>
        /// ID do item da nota fiscal de entrada
        /// </summary>
        public int BEG_CPR_NFE_ITEM_ID { get; set; }

    }
}
