
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_RESUMO_RECEITAS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RESUMO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
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
        public int AD_ORG_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_RESUMO { get; set; }

    }
}
