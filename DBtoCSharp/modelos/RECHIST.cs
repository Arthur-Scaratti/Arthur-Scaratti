
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class RECHIST
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int FALSO_ID { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CDDUPL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string PARCELA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SRDUP { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string PROBLEMA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLPARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLDEVIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PORCONTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MULTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRRECIBO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCALPG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CRC_HISTORICO_ID { get; set; }

    }
}
