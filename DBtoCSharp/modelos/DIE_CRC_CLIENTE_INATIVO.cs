
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_CLIENTE_INATIVO
    {
            [Required]
    [Key]
        /// <summary>
        /// Id do cliente inativo
        /// </summary>
        public int DIE_CRC_CLIENTE_INATIVO_ID { get; set; }
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
            [Required]
        /// <summary>
        /// Id do parceiro comercial - cliente
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Data da ultima compra
        /// </summary>
        public string DT_ULT_COMPRA { get; set; }
        
        /// <summary>
        /// Valor da ultima Compra
        /// </summary>
        public int VLR_ULT_COMPRA { get; set; }
        
        /// <summary>
        /// Id do tipo do titulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
        
        /// <summary>
        /// Numero do ultimo contrato
        /// </summary>
        public int CONTRATO { get; set; }
        
        /// <summary>
        /// Quantidade de meses inativo
        /// </summary>
        public int QTD_MES_INATIVO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// Codigo da filial
        /// </summary>
        public string CD_FILIAL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Condicao de pagamento
        /// </summary>
        public string CONDICAO { get; set; }
        
        /// <summary>
        /// Valor medio das parcelas
        /// </summary>
        public int VLR_MEDIO_PARC { get; set; }

    }
}
