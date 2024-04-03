
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DEMO_IMAGES
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int IMAGE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int FILE_OBJECT_ID { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string IMAGE_NAME { get; set; }

    }
}
