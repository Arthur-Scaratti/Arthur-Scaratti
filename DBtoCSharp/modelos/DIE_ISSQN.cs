
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_ISSQN
    {
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string REFERENCIA { get; set; }
            [StringLength(254)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCR { get; set; }

    }
}
