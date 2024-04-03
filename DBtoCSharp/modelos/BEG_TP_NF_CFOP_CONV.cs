
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_TP_NF_CFOP_CONV
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TP_NF_CFOP_CONV_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// CFOP de Saida na nota de entrada 
        /// </summary>
        public int BEG_VW_CFOP_SAI_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// ESTA INFORMACAO NAO SERA UTILIZADA PELO EMISSOR
        /// </summary>
        public int FINNFE { get; set; }

    }
}
