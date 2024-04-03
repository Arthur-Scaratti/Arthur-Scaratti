
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CARTEIRA_PROC_JUDICIAIS
    {
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string ID_CLIENTE { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFC { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CLIENTE { get; set; }

    }
}
