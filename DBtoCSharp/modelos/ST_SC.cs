
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ST_SC
    {
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string CEST { get; set; }
            [StringLength(65)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }

    }
}
