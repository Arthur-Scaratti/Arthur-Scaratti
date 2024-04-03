
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_ESTATISTICA_VENDA
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_VENDA_CO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_VENDA_CO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_ESTAT_VEN_ID { get; set; }
        
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
        public string UPDATED { get; set; }
        
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
        public int COD_FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_FIM { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_VENDA_AP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_VENDA_AP { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_VENDA_AV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_VENDA_AV { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_VENDA_CC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_VENDA_CC { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_VENDA_FI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_VENDA_FI { get; set; }

    }
}
