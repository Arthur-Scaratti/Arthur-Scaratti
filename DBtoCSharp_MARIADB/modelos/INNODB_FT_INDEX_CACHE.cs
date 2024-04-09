
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_FT_INDEX_CACHE
    {
            [Required]
    [StringLength(337)]
        /// <summary>
        /// 
        /// </summary>
        public string WORD { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long FIRST_DOC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long LAST_DOC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long DOC_COUNT { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long DOC_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public long POSITION { get; set; }

}
}
