
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PORTADOR_DBF
    {
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CDPORTADOR { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string NOPORTADOR { get; set; }

    }
}
