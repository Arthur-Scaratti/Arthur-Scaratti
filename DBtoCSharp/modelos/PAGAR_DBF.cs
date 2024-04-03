
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PAGAR_DBF
    {
            [StringLength(14)]
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
        public string TPFORNEC { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPORTADOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTENTRADA { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLBLOQUETO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
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
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int JUROS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string NRNF { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS2 { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRREGISTRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASEICM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRADIANTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRADIANTA2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRADIANTA3 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLADIANTA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPDEVOL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string NFDEVOL { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SRDEVOL { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCONTAB { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string CODBARRAS { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CODINSS { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string IDENTIF { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPETEN { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string FAVOREC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int OUTRASENT { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string BANCO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string AGENCIA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string DVAGENCIA { get; set; }
            [StringLength(12)]
        /// <summary>
        /// 
        /// </summary>
        public string CONTA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string DVCONTA { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CGC { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string NRBANCO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRARQUIVO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CONDPGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLIRRF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TARIFADOC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLDEVOL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PISCOFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int INSS { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string RAZAO { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CNPJFOR { get; set; }

    }
}
