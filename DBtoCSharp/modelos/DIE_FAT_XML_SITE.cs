
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_XML_SITE
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_XML_SITE_ID { get; set; }
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
        public int NR_PEDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ID_MARKETPLACE { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME_CLIENTE { get; set; }
            [StringLength(14)]
        /// <summary>
        /// 
        /// </summary>
        public string CPF_CNPJ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_PEDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_ULTIMA_ALTERACAO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string BAIRRO { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string LOGRADOURO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string NUMERO { get; set; }
            [StringLength(150)]
        /// <summary>
        /// 
        /// </summary>
        public string COMPLEMENTO { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CEP { get; set; }
            [StringLength(110)]
        /// <summary>
        /// 
        /// </summary>
        public string TRANSPORTADORA { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_TRANSPORTADORA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PRAZO_ESTIMADO_ENTREGA { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string TID_CIELO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string TID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PARCELAS { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string PROTOCOLO_PAGAMENTO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string FORMA_PAGAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_TOTAL_ITENS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_TOTAL_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_TOTAL_JUROS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_DESCONTO_FRETE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_TOTAL_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_CUPOM_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_PROG_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_FORMA_DESCONTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_FINAL_PEDIDO { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string ENTREGA_B2W { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_UF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_FORMA_PAGAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_TRANSPORTADORA_ID { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string DOC_STATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_VALE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAR_TAXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CRC_RECIBO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PESO_LIQUIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PESO_BRUTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_VOLUME { get; set; }
            [StringLength(500)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FAT_PRE_NFS_ID { get; set; }

    }
}
