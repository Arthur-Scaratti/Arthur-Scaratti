
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PRE_CRC_TITULO
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MOEDA_ID { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_NF_SAIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_PRE_NFS_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_COBRANCA { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CONVENIO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGURO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_GARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TX_FINANCEIRA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SRDUP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PAGO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRE_CRC_TITULO_ID { get; set; }
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
        /// 
        /// </summary>
        public int PARCELA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }

    }
}
