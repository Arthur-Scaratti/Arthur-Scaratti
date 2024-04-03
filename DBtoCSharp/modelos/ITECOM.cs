
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ITECOM
    {
            [StringLength(8)]
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
        public int QTDEDEV { get; set; }
        
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

    }
}
