
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VW_EXTRATO_BB
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IDENT { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string CHECKNUM { get; set; }
            [StringLength(150)]
        /// <summary>
        /// 
        /// </summary>
        public string MEMO { get; set; }

    }
}
