
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_GER_FERIADO
    {
            [Required]
    [Key]
        /// <summary>
        /// id do feriado
        /// </summary>
        public int BEG_GER_FERIADO_ID { get; set; }
            [Required]
        /// <summary>
        /// Empresa
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
        /// <summary>
        /// 0 (*)  = para todas as filaiis
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// Ativo
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
    [StringLength(100)]
        /// <summary>
        /// Descricao do feriado
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// Data do feriado
        /// </summary>
        public string DT_FERIADO { get; set; }
            [Required]
        /// <summary>
        /// (N)acional, (M)unicipal e (E)stadual
        /// </summary>
        public string TP_FERIADO { get; set; }

    }
}
