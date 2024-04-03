
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class FORALINHA
    {
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
            [StringLength(98)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string MARCA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AVISTA { get; set; }

    }
}
