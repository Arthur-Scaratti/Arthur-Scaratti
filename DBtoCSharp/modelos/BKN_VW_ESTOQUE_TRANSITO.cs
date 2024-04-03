
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BKN_VW_ESTOQUE_TRANSITO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_ESTOQUE_TRANSITO_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }

    }
}
