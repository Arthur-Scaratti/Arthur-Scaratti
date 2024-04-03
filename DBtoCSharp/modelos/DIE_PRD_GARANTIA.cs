
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRD_GARANTIA
    {
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Tipo de servico R - reparo T - troca
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// Itens ativos quando foi bloqueada a venda - 05/11/2022
        /// </summary>
        public string ATIVOS { get; set; }
            [StringLength(9)]
        /// <summary>
        /// Código para exportação via arquivo da Mapfre
        /// </summary>
        public string CODMAPHRE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id da garantia estendida 
        /// </summary>
        public int DIE_PRD_GARANTIA_ID { get; set; }
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
        /// Codigo da garantia
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
            [StringLength(60)]
        /// <summary>
        /// Descricao da garantia estendida
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// Valor inicial de referencia
        /// </summary>
        public int VLR_INICIAL { get; set; }
            [Required]
        /// <summary>
        /// Valor Final de referencia
        /// </summary>
        public int VLR_FINAL { get; set; }
            [Required]
        /// <summary>
        /// Valor do custo
        /// </summary>
        public int VLR_CUSTO { get; set; }
            [Required]
        /// <summary>
        /// Valor da garantia estendida
        /// </summary>
        public int VLR_PRECO { get; set; }

    }
}
