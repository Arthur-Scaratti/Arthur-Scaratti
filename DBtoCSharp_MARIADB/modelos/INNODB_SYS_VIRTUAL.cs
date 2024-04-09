
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_SYS_VIRTUAL
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long TABLE_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int POS { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BASE_POS { get; set; }

}
}
