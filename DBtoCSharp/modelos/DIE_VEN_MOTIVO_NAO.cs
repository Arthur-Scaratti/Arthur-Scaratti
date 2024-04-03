
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VEN_MOTIVO_NAO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_VEN_MOTIVO_NAO_ID { get; set; }
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
    [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// P - ATENDIMENTO PRESENCIAL T - TELEVENDAS
        /// </summary>
        public string IND_ATENDIMENTO { get; set; }

    }
}
