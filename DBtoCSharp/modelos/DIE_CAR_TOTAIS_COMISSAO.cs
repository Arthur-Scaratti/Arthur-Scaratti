
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_TOTAIS_COMISSAO
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string VENDEDOR { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string MESBASE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLRVENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLCOMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLREPOUSO { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }

    }
}
