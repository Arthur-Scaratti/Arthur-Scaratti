
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VW_TOT_CPG_TMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CHEQUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PREVISAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_VW_TOT_CPG_TMP_ID { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public int VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string DIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DUPLICATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OBRIGACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SUBTOTAL { get; set; }

    }
}
