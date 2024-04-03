
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NBM
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NBM { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }

    }
}
