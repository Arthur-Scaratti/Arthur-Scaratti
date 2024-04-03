
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_COB_DIVERGENCIA
    {
            [StringLength(14)]
        /// <summary>
        /// CPF ou CNPJ
        /// </summary>
        public string CPFCNPJ { get; set; }
        
        /// <summary>
        /// 1.Aviso 2.SPC 3.Cobranca
        /// </summary>
        public int TP_DIVERGENCIA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// id da divergencia
        /// </summary>
        public int DIE_COB_DIVERGENCIA_ID { get; set; }
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
        /// Id do parceiro comercial
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
    [StringLength(500)]
        /// <summary>
        /// Descrição da divergencia
        /// </summary>
        public string DESC_DIVERGENCIA { get; set; }

    }
}
