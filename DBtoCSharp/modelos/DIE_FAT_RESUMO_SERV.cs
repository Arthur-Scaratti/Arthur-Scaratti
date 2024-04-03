
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FAT_RESUMO_SERV
    {
        
        /// <summary>
        /// Quantidade Vendida
        /// </summary>
        public int QTDE_VENDIDA { get; set; }
        
        /// <summary>
        /// Quantidade Cancelada no mês
        /// </summary>
        public int QTDE_CANC_MES { get; set; }
        
        /// <summary>
        /// Quantidade Cancelada no mês anterior
        /// </summary>
        public int QTDE_CANC_ANT { get; set; }
        
        /// <summary>
        /// Número do Arquivo
        /// </summary>
        public int NRO_ARQUIVO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FAT_RESUMO_SERV_ID { get; set; }
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
        /// Valor bruto da venda do periodo
        /// </summary>
        public int VLR_VENDIDO { get; set; }
        
        /// <summary>
        /// Valor dos servicos vendidos no periodo e devolvidos
        /// </summary>
        public int VLR_ESTORNADO { get; set; }
        
        /// <summary>
        /// Valor liquido vendido
        /// </summary>
        public int VLR_LIQUIDO_VENDIDO { get; set; }
        
        /// <summary>
        /// Valor dos servicos devolvidos no periodo e que foram vendidos anteriormente
        /// </summary>
        public int VLR_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// Valor do repasse
        /// </summary>
        public int VLR_REPASSE { get; set; }
        
        /// <summary>
        /// Data previsao do repasse
        /// </summary>
        public string DT_REPASSE { get; set; }
            [StringLength(2)]
        /// <summary>
        /// GE-Garantia, PF-Protecao, AP-Seguro AP Premiado, DE-Decessos
        /// </summary>
        public string MODALIDADE_SERVICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PERIODO_APURACAO { get; set; }

    }
}
