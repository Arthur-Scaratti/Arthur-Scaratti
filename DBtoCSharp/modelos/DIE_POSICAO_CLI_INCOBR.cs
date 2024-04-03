
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_POSICAO_CLI_INCOBR
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_POSICAO_CLI_INCOBR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_POSICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCR_MES_ANO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MES_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ANO_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ANO_ANT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TITULO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CLIENTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_FILIAL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CONTINGENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TX_FINANCEIRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_GARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGURO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SEGUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IMPRESSAO { get; set; }

    }
}
