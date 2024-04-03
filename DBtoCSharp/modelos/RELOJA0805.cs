
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class RELOJA0805
    {
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
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCALPG { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string OCORRENCIA { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCUPOM { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CDCOBRADOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTVENCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTPAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTREINSC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTAVISO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLPAGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int JUROS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IMPRESSO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IMPAVISO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string AVISO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int NRCAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRRECIBO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTRECIBO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTRAPAGA { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NFDEVOL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPDEVOL { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLRENEG { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLGARANTIA { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CONVENIADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEGURO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTGERAAVI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTENVCOBRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTBANCO { get; set; }

    }
}
