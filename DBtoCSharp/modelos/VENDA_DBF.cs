
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class VENDA_DBF
    {
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
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CDVENDEDOR { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NOTADEV { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPDEVOL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NOTAREF { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NOTAEMP { get; set; }
        
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
        public int TAIMBU { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CUSTO { get; set; }
        
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
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCPCR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTMOVIM { get; set; }
            [StringLength(7)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCUPOM { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string NOVOECF { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTDEP { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CDCARTAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TAXA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string MANUAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRPARCELAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLCARTAO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CDCARTAO2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRPARCELA2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLCARTAO2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TAXA2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAS2 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string MANUAL2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTDEP2 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string VENDAPAGA { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRRECIBO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRRECCOMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTRECCOMP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTRECIBO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLGARANTIA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPOFI { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string NRAUTOR1 { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string NRAUTOR2 { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CONVENIADA { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NRASSOC { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NFEMPVEI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SEGURO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CODFINANC { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTBANCO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_NOTA { get; set; }
            [StringLength(44)]
        /// <summary>
        /// 
        /// </summary>
        public string CHAVENFCE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPEMISSAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string NFCESERIE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NFCE { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NRPEDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLSEGUROS { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string APEXNOME { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string APEXID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALORCT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ICMSSUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASESUBST { get; set; }

    }
}
