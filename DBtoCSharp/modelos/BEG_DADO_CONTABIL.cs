
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_DADO_CONTABIL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_DADO_CONTABIL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_CONTA_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string GRUPO_CONTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }

    }
}
