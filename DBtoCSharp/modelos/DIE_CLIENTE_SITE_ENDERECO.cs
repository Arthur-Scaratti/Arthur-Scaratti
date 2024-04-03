
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CLIENTE_SITE_ENDERECO
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CLIENTE_SITE_ENDERECO_ID { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        public int ID_ENDERECO_F1 { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string DESTINATARIO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string LOGRADOURO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TELEFONE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CELULAR { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string IBGE { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_ENDERECO { get; set; }
        
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
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO_ENDERECO { get; set; }

    }
}
