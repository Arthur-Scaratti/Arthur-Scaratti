
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CTB_RECARGAVIVO
    {
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
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_FIM { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_RECEBIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_RECIBO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTA_RECARGA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CDFILIAL_CONTABIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CTB_RECARGA_ID { get; set; }
        
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

    }
}
