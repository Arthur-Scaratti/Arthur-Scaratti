
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class APPLICABLE_ROLES
    {
            [Required]
    [StringLength(385)]
        /// <summary>
        /// 
        /// </summary>
        public string GRANTEE { get; set; }
            [Required]
    [StringLength(128)]
        /// <summary>
        /// 
        /// </summary>
        public string ROLE_NAME { get; set; }
            [Required]
    [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IS_GRANTABLE { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IS_DEFAULT { get; set; }

}
}
