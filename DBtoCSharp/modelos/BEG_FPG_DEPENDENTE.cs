
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_FPG_DEPENDENTE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FPG_DEPENDENTE_ID { get; set; }
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
        /// ID do funcionário.
        /// </summary>
        public int BEG_FPG_PESSOA_ID { get; set; }
            [Required]
    [StringLength(52)]
        /// <summary>
        /// Nome do dependente.
        /// </summary>
        public string NOME { get; set; }
            [Required]
        /// <summary>
        /// Data de nascimento.
        /// </summary>
        public string DT_NASCIMENTO { get; set; }
            [Required]
        /// <summary>
        /// Tipo de dependente.
        /// </summary>
        public string TIPO_DEPENDENTE { get; set; }
            [Required]
        /// <summary>
        /// Dependente para o salário família.
        /// </summary>
        public string DEPENDENTE_SF { get; set; }
            [Required]
        /// <summary>
        /// Dependente para o imposto de renda.
        /// </summary>
        public string DEPENDENTE_IR { get; set; }
            [Required]
        /// <summary>
        /// Sexo do dependente.
        /// </summary>
        public string SEXO { get; set; }

    }
}
