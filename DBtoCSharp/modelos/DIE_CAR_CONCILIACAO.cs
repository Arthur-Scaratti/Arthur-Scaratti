
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAR_CONCILIACAO
    {
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NR_ANTECIPACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_VCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARTAO_PARCELA_ID { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_ESTORNO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PROCESSADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TX_ADIANTAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_ESTORNO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string STATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_COM_SEM_DESBL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COM_SEM_DESBL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CAR_TPMOV { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string MEIO_PAGTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VALE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_LIBERACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PAGTO_CLI { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_CONCILIACAO_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_CREDITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO_RESUMO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELA { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NSU_BANCO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_AUTORIZACAO_TEF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CAR_TIPO_VENDA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CONTA_CORRENTE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_TAXA_FINANCEIRA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_LIQUIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CAR_BANDEIRA_ID { get; set; }
            [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_PAGTO_EST { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGA_B2W { get; set; }

    }
}
