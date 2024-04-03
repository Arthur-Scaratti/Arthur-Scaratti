
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_RENEG_OUTLJ
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_GARANTIA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGURO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGUROS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TX_FINANCEIRA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RENEG_OUTLJ_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// FILIAL ORIGINAL DA DIVIDA
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
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TIT_ORIGINAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_RENEG { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PAGO { get; set; }
        
        /// <summary>
        /// FILIAL NOVO CONTRATO
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_RENEGOCIACAO_ID { get; set; }

    }
}
