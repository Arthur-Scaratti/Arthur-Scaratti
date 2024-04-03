
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_MONITOR01
    {
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string PROMOCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FILIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRODUTO { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string UNIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRECO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string USUARIO { get; set; }

    }
}
