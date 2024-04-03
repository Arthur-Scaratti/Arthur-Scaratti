
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_EMAILS_PROBLEMAS
    {
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string P_SENDORADDRESS { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string P_RECEIVERADDRESS { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string P_SUBJECT { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string P_MESSAGE { get; set; }
            [StringLength(4000)]
        /// <summary>
        /// 
        /// </summary>
        public string ERRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DTHR { get; set; }

    }
}
