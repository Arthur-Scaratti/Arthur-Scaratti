
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_FECH_FORN
    {
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_FECH_FORN_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUM_CONTA { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCR_CONTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DIA { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DEBITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREDITO { get; set; }

    }
}
