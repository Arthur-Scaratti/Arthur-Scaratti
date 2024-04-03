
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class JOB_OUTPUT
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string A { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string B { get; set; }

    }
}
