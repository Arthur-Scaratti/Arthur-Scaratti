
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_DEPOSITOS_IDENTI_MF
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_DEPOSITOS_IDENTI_MF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_SALDO_ID { get; set; }
        
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
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_SALDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_IDENTIFICACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FIN_BCO_CONTA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_PORTADOR_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }

    }
}
