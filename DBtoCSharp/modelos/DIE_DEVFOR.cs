
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_DEVFOR
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string APEXID { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string APEXNOME { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string IDORACLE { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTENTREGA { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string NOP { get; set; }
        
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
        public int ICM { get; set; }
        
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
        public int FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ACRESCIMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESPESA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IMPRESSO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CANCELADO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NOTAREF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTMOVIM { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPDEVOL { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string NFCOMPRA { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SRCOMPRA { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string HORA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTBANCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASESUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ICMSSUBST { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IPI { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string SEQ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALORCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRNF { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }

    }
}
