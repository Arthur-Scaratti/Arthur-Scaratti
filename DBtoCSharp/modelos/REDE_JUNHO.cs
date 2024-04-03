
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class REDE_JUNHO
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int ESTABELECI { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_DA_VE { get; set; }
            [StringLength(8)]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_DE_RE { get; set; }
            [StringLength(7)]
        /// <summary>
        /// 
        /// </summary>
        public string PRAZO_DE_R { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RESUMO_DE_ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QUANTIDADE { get; set; }
            [StringLength(9)]
        /// <summary>
        /// 
        /// </summary>
        public string BANDEIRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUID { get; set; }

    }
}
