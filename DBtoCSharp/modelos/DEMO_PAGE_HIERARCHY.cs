
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DEMO_PAGE_HIERARCHY
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int PAGE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARENT_PAGE_ID { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string PAGE_NAME { get; set; }

    }
}
