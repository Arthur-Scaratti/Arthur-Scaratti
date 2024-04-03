
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_VISA_CANC
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_VISA_CANC_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
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
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_REGISTRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_PV { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO_RESUMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_AJUSTE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_AJUSTE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string DEBITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CAR_BANDEIRA_ID { get; set; }

    }
}
