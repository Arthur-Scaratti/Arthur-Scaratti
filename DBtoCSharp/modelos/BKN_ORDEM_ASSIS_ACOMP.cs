
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BKN_ORDEM_ASSIS_ACOMP
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BKN_ORDEM_ASSIS_ACOMP_ID { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public int BKN_ORDEM_ASSISTENCIA_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string RESPONSAVEL_PGTO { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }

    }
}
