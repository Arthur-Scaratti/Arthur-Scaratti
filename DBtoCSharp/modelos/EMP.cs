
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class EMP
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int EMPNO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string ENAME { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string JOB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MGR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string HIREDATE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COMM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DEPTNO { get; set; }

    }
}
