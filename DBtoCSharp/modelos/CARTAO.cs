
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CARTAO
    {
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CNPJADMIN { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string CDCARTAO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string REDEAUTOR { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string REDEANT { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string BANDEIRA { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string BANDANT { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string MODALIDADE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TAXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TAXAPARC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIASPARC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCMAX { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string MANUAL { get; set; }

    }
}
