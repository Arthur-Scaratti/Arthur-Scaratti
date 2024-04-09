
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class VIEWS
    {
            [Required]
    [StringLength(512)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_CATALOG { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_SCHEMA { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string TABLE_NAME { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VIEW_DEFINITION { get; set; }
            [Required]
    [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string CHECK_OPTION { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IS_UPDATABLE { get; set; }
            [Required]
    [StringLength(384)]
        /// <summary>
        /// 
        /// </summary>
        public string DEFINER { get; set; }
            [Required]
    [StringLength(7)]
        /// <summary>
        /// 
        /// </summary>
        public string SECURITY_TYPE { get; set; }
            [Required]
    [StringLength(32)]
        /// <summary>
        /// 
        /// </summary>
        public string CHARACTER_SET_CLIENT { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string COLLATION_CONNECTION { get; set; }
            [Required]
    [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string ALGORITHM { get; set; }

}
}
