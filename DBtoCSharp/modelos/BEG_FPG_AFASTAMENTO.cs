
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FPG_AFASTAMENTO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FPG_AFASTAMENTO_ID { get; set; }
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
    [StringLength(10)]
        /// <summary>
        /// Código do afastamento.
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [StringLength(70)]
        /// <summary>
        /// Descrição do afastamento.
        /// </summary>
        public string NAME { get; set; }
            [Required]
        /// <summary>
        /// Gera demissão do empregado.
        /// </summary>
        public string GERA_DEMISSAO { get; set; }
            [Required]
        /// <summary>
        /// Gera férias.
        /// </summary>
        public string GERA_FERIAS { get; set; }
            [Required]
        /// <summary>
        /// Situação do empregado durante o afastamento.
        /// </summary>
        public int BEG_FPG_SITUACAO_ID { get; set; }

    }
}
