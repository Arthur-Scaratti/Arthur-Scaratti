
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_SALDO_INV_CONTAB
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_SALDO_INV_CONTAB_ID { get; set; }
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
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPRODUTO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
            [Required]
        /// <summary>
        /// Custo Unitario original no momenrto que foi gerado este saldo de estoque
        /// </summary>
        public int CUSTO { get; set; }
            [Required]
        /// <summary>
        /// Agrupados almoxarifados e cores
        /// </summary>
        public int QTDE { get; set; }
            [Required]
        /// <summary>
        /// A data sera sempre o ultimo dia do mes.
        /// </summary>
        public string DATA { get; set; }
            [Required]
        /// <summary>
        /// Custo medio unitario gerado para apuracao do inventario
        /// </summary>
        public int CUSTO_MEDIO { get; set; }
        
        /// <summary>
        /// Fica sendo o cálculo de Base do icms st da última compra x 18%, quando algum produto possa ter redução de base de cálculo faz-se x 12%.. Valor unitario por produto.
        /// </summary>
        public int ICMS_RECUPERAR { get; set; }

    }
}
