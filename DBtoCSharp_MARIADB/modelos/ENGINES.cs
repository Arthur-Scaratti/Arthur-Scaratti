
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ENGINES
    {
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string ENGINE { get; set; }
            [Required]
    [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string SUPPORT { get; set; }
            [Required]
    [StringLength(160)]
        /// <summary>
        /// 
        /// </summary>
        public string COMMENT { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string TRANSACTIONS { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string XA { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string SAVEPOINTS { get; set; }

}
}
