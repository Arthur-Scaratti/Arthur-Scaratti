
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ITEVEN_DBF
    {
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLRTRIB { get; set; }
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
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPRODUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDEDEV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDEATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLUNITARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IPI { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string CDVENDEDOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CLASSIF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASEICM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PICMS { get; set; }
            [StringLength(100)]
        /// <summary>
        /// Descricao do produto
        /// </summary>
        public string NOME { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TPGARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALORDESC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERCDESC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECOFINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ACRESCIMO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPOPRECO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MVA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FRETE { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ICMSSUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASESUBST { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CST { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string CFOP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLICM { get; set; }

    }
}
