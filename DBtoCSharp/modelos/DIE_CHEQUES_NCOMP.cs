
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CHEQUES_NCOMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CHEQUES_NCOMP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CHQ_CHEQUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_CHEQUE { get; set; }
        
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
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_BASE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_VCTO { get; set; }
        
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
