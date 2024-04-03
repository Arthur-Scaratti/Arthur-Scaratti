
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ST_RECUPERAR
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string PERIODO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_INICIAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_FINAL { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }

    }
}
