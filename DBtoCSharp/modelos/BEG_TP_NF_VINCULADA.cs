
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_TP_NF_VINCULADA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TP_NF_VINCULADA_ID { get; set; }
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
        /// 
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
        
        /// <summary>
        /// indica se a nota tera produtos
        /// </summary>
        public string IND_PRODUTO { get; set; }
        
        /// <summary>
        /// indica se o icms proprio ser calculado
        /// </summary>
        public string IND_ICMS_PROPRIO { get; set; }
        
        /// <summary>
        /// indica se a nota tera o icms subst tributaria
        /// </summary>
        public string IND_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// indica se a nota gerada tera total da nota 
        /// </summary>
        public string IND_TOTAL_NF { get; set; }
        
        /// <summary>
        /// tipo de nota fiscal gerado.
        /// </summary>
        public int BEG_VW_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// Tipo da nota entrada ou saida
        /// </summary>
        public string TP_NF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TP_NF_CFOP_CONV_ID { get; set; }

    }
}
