
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_VW_BANCO_CUSTODIA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_BANCO_CUSTODIA_ID { get; set; }
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_COB_ESCRITURAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PAG_ESCRITURAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public byte[] LOGO_BOLETO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string DIG_BANCO { get; set; }

    }
}
