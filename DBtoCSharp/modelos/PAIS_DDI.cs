
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PAIS_DDI
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int ZONA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }

    }
}
