
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DEPT
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DEPTNO { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string DNAME { get; set; }
            [StringLength(13)]
        /// <summary>
        /// 
        /// </summary>
        public string LOC { get; set; }

    }
}
