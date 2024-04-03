
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CTB_VALORES_FECH
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CTB_VALORES_ID { get; set; }
        
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
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_NOTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_CUSTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_DESCONTO { get; set; }

    }
}
