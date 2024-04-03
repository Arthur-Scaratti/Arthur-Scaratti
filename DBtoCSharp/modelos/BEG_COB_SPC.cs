
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_SPC
    {
            [Required]
    [Key]
        /// <summary>
        /// ID REGISTROS SPC
        /// </summary>
        public int BEG_COB_SPC_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// Codigo da Filial no SPC
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
            [StringLength(5)]
        /// <summary>
        /// Codigo do SPC Estadual
        /// </summary>
        public string COD_SPC_ESTADUAL { get; set; }
        
        /// <summary>
        /// Codigo do Associado no SPC Estadual
        /// </summary>
        public int COD_SPC_ASSOC_ESTADUAL { get; set; }
            [StringLength(5)]
        /// <summary>
        /// Codigo do SPC Local
        /// </summary>
        public string COD_SPC_LOCAL { get; set; }
        
        /// <summary>
        /// Codigo do Associado no SPC Local
        /// </summary>
        public int COD_SPC_ASSOC_LOCAL { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Senha de acesso a o SPC pela Internet
        /// </summary>
        public string SENHA_INTERNET { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Senha de acesso ao SPC pelo telefone
        /// </summary>
        public string SENHA_TELEFONE { get; set; }
            [StringLength(20)]
        /// <summary>
        /// Nome do Usuario Web
        /// </summary>
        public string USUARIO_WEB { get; set; }

    }
}
