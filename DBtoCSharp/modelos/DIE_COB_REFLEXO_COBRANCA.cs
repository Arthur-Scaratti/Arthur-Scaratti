
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_COB_REFLEXO_COBRANCA
    {
            [Required]
    [Key]
        /// <summary>
        /// id do reflexo na cobranca
        /// </summary>
        public int DIE_COB_REFLEXO_COBRANCA_ID { get; set; }
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
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
        /// Id do tipo de movimento
        /// </summary>
        public int BEG_CRC_TPMOV_ID { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// Descricao do reflexo
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// indica necessidade da data do movimento
        /// </summary>
        public string IND_DT_MOVTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// indica necessidade do valor do movimento
        /// </summary>
        public string IND_VL_MOVTO { get; set; }

    }
}
