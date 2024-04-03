
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CAILOJA_BKP
    {
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRAUTESTOR { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SRAJU { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPOFI { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CODFINANC { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRDEPOSITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTDEPOSITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTBANCO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string IDORACLE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCALPG { get; set; }
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
        public string TPVENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTVENCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLRENEG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLRECEBIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ACRESCIMO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPOPAGTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRRECIBO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEQECF { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRAUTENTI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRCAIXA { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string NRBANCO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string NRAGENCIA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCONTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALORAUT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDOATU { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTESTORNO { get; set; }

    }
}
