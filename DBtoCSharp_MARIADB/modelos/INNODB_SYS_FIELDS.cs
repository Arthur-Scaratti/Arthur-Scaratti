
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_SYS_FIELDS
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long INDEX_ID { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int POS { get; set; }

}
}
