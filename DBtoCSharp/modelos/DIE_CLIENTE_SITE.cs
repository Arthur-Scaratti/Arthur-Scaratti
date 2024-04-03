
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CLIENTE_SITE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CLIENTE_SITE_ID { get; set; }
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
        public int ID_CLIENTE_F1 { get; set; }
            [Required]
    [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string APELIDO { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
            [Required]
    [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF_CNPJ { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IE_RG { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IM { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string RESPONSAVEL_CLI { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TELEFONE1 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TELEFONE2 { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FAX { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CELULAR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEXO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_NASCIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_CADASTRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_MODIFICACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ATIVO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ACEITA_NEWSLETTER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }

    }
}
