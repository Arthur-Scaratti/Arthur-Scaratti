
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class MLOG$_BEG_COB_PARAMETRO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_COB_PARAMETRO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SNAPTIME$$ { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string DMLTYPE$$ { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string OLD_NEW$$ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] CHANGE_VECTOR$$ { get; set; }

    }
}
