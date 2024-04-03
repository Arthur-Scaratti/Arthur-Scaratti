
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_PESSOA_CARTAO
    {
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CR { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PESSOA_CARTAO_ID { get; set; }
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
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CPFCNPJ { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SEXO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string E_MAIL { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DDD { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CELULAR { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string UF { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string CIDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CADASTRO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_NASCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_COMPRAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTDE_COMPRAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ULTIMA_COMPRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_ULTIMA_COMPRA { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string IDADE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIMITE_A_VISTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIMITE_PARCELADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIMITE_A_VISTA_DISPONÍVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LIMITE_PARCELADO_DISPONÍVEL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PONTOS_DISPONÍVEIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int RENDA { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }

    }
}
