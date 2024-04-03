
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_DATA_TMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string DIA { get; set; }

    }
}
