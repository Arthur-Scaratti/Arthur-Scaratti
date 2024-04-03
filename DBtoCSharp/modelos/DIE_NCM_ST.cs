
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_NCM_ST
    {
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NCM { get; set; }

    }
}
