
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CREATE$JAVA$LOB$TABLE
    {
            [StringLength(700)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] LOB { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string LOADTIME { get; set; }

    }
}
