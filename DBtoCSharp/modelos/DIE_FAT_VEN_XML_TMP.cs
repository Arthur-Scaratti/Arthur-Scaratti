
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_VEN_XML_TMP
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_CONTROLE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_CUPON_FISCAL { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOTAL_NFS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVE_ACESSO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_NFS_ID { get; set; }

    }
}
