
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_ITEDEF
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int ACRESCIMO { get; set; }
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
        public int QTDE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLUNITARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IPI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTEMISSAO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PICM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASEICM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLICM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BASESUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ICMSSUBST { get; set; }
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
        public int FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MVA { get; set; }

    }
}
