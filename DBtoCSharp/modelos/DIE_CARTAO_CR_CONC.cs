
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARTAO_CR_CONC
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_CONC_ID { get; set; }
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
        public string TP_MOVTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_FATURA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PAGO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_PAGTO { get; set; }
            [StringLength(15)]
        /// <summary>
        /// 
        /// </summary>
        public string LOCAL_PGTO { get; set; }
            [StringLength(4)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_PRODUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_MOVIMENTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_LOCAL_PAGTO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// lojista onde compra foi realizada registro 74
        /// </summary>
        public string COD_LOJA { get; set; }
            [StringLength(4)]
        /// <summary>
        /// loja onde compra foi realizada registro 74
        /// </summary>
        public string LOJA { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string CD_HISTORICO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ORIGINAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CONTABIL { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_HISTORICO { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string SITUACAO { get; set; }
        
        /// <summary>
        /// data real do pagamento
        /// </summary>
        public string DT_EVENTO { get; set; }
            [StringLength(6)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_CARTAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_CR_HISTORICO_ID { get; set; }

    }
}
