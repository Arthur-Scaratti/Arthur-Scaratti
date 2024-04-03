
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VEN_CONV_FAT_LOT_ITEM
    {
            [Required]
        /// <summary>
        /// Numero do contrato (value de beg_crc_titulo)
        /// </summary>
        public int CONTRATO { get; set; }
        
        /// <summary>
        /// Codigo do cliente filial
        /// </summary>
        public int COD_CLIENTE_FILIAL { get; set; }
        
        /// <summary>
        /// id do titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// Parcela do contrato
        /// </summary>
        public int PARCELA { get; set; }
        
        /// <summary>
        /// Data de vencimento do titulo
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// Codigo do conveniado
        /// </summary>
        public int COD_CONVENIADO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id do item do lote do convenio
        /// </summary>
        public int BEG_VEN_CONV_FAT_LOT_ITEM_ID { get; set; }
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
        /// id do convenio
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
            [Required]
        /// <summary>
        /// id da pessoa - cliente
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// Valor do titulo
        /// </summary>
        public int VLR_TITULO { get; set; }
            [Required]
        /// <summary>
        /// Data de emissao do titulo
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Id do lote do convenio
        /// </summary>
        public int BEG_VEN_CONV_FAT_LOT_ID { get; set; }

    }
}
