
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_REDECARD_AUX
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }
            [StringLength(12)]
        /// <summary>
        /// 
        /// </summary>
        public string NSU { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_AUTOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VENCTO { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string RV { get; set; }

    }
}
