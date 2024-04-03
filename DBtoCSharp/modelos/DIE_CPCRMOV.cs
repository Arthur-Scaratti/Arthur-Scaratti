
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPCRMOV
    {
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRNF { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SRCP { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NOTA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPCLIENTE { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTENTREGA { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CDVENDEDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLNF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLIPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLICM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASEICM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESPESA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CUSTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRAZO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLPARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTVENCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTPROG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ICM { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string NOP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTMOVIM { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CANCELADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTESTORNO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTESTORAV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTBANCO { get; set; }

    }
}
