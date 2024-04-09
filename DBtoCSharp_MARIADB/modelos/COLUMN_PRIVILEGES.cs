
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class COLUMN_PRIVILEGES
    {
            [Required]
    [StringLength(385)]
        /// <summary>
        /// 
        /// </summary>
        public string GRANTEE { get; set; }
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
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string COLUMN_NAME { get; set; }
            [Required]
    [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string PRIVILEGE_TYPE { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IS_GRANTABLE { get; set; }

}
}
