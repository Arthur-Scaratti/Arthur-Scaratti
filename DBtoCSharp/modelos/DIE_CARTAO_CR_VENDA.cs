
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARTAO_CR_VENDA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_VENDA_ID { get; set; }
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
            [StringLength(19)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_CARTAO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_TRANSACAO { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string ESTABELECIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_TRANSACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VENDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TP_PARC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PLANO { get; set; }
            [StringLength(12)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_AUTOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_AUTOR_CANC { get; set; }
            [StringLength(12)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NSUCAPTURA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int IOF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TAC { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CNPJ_ESTAB { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_LOJA { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string LOJA { get; set; }
            [StringLength(11)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_CARTAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PREV_REPASSE { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_PRODUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_PARCELA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_COMPRAS_ID { get; set; }

    }
}
