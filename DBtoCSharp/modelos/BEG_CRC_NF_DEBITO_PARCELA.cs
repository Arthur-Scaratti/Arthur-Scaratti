
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_NF_DEBITO_PARCELA
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_NF_DEBITO_PARCELA_ID { get; set; }
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
        public int BEG_VEN_FORMA_COBRANCA_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_NF_DEBITO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_LOCALIZACAO_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string ORIGEM { get; set; }

    }
}
