
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class KEYWORDS
    {
            [StringLength(64)]
        /// <summary>
        /// 
        /// </summary>
        public string WORD { get; set; }

}
}
