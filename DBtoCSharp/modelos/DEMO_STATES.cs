
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DEMO_STATES
    {
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string ST { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string STATE_NAME { get; set; }

    }
}
