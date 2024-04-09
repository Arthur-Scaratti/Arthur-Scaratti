
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class INNODB_FT_DEFAULT_STOPWORD
    {
            [Required]
    [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string value { get; set; }

}
}
