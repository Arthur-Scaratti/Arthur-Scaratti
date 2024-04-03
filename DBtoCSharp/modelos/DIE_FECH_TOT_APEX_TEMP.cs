
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FECH_TOT_APEX_TEMP
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FECH_TOT_APEX_TEMP_ID { get; set; }
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
        public int NRO_CAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_SALDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(16)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_MERC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VENDA_CF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VENDA_NF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SERVICOS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_GERAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORDENADOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PINSTANCE_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }

    }
}
