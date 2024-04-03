
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_VISA_REG2
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int PLANO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NSU { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VENCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TX_FINANCEIRA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_TEF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOT_PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TOTAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string TID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_TRANSACAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_VENDA { get; set; }

    }
}
