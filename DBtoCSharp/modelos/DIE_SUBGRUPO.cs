
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_SUBGRUPO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int CODIGO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string GARANTIA1 { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string MONTAGEM { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string ASSURANT { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string GAR_ANTERI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EST_MINIMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int EST_MAXIMO { get; set; }

    }
}
