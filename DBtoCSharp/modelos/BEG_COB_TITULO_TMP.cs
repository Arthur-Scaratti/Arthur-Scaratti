
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_COB_TITULO_TMP
    {
        
        /// <summary>
        /// Id da cidade do cliente
        /// </summary>
        public int BEG_CIDADE_ID { get; set; }
        
        /// <summary>
        /// Indica se ja foi enviado para cobrador
        /// </summary>
        public string IND_COBRADOR { get; set; }
        
        /// <summary>
        /// Data de pagamento na assessoria
        /// </summary>
        public string DT_PGTO_COBRANCA { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id da tabela temporaria ref. aos titulos vencidos para a cobranca
        /// </summary>
        public int BEG_COB_TITULO_TMP_ID { get; set; }
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
        /// 
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
            [Required]
        /// <summary>
        /// Id do titulo
        /// </summary>
        public int BEG_CRC_TITULO_ID { get; set; }
            [Required]
        /// <summary>
        /// parcela do titulo
        /// </summary>
        public int PARCELA { get; set; }
            [Required]
        /// <summary>
        /// data de emissao do titulo
        /// </summary>
        public string DT_EMISSAO { get; set; }
            [Required]
        /// <summary>
        /// data de vencimento
        /// </summary>
        public string DT_VCTO { get; set; }
            [Required]
        /// <summary>
        /// Valor em aberto
        /// </summary>
        public int VLR_ABERTO { get; set; }
        
        /// <summary>
        /// Filial - naum deve ser mais usado
        /// </summary>
        public int FILIAL { get; set; }
            [Required]
        /// <summary>
        /// id do parceiro comercial - cliente
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// Id da filial - naum deve ser usado
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [Required]
        /// <summary>
        /// Id do tipo do titulo
        /// </summary>
        public int BEG_TIPO_TITULO_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// tipo do titulo - naum deve ser mais usado
        /// </summary>
        public string TIPO_TITULO { get; set; }
        
        /// <summary>
        /// numero de dias de atraso - ref. ao titulo
        /// </summary>
        public int DIAS_ATRASADO { get; set; }
        
        /// <summary>
        /// Id do cobrador
        /// </summary>
        public int BEG_COBRADOR_ID { get; set; }
        
        /// <summary>
        /// Data de aviso de pagamento
        /// </summary>
        public string DT_AVISO_PGTO { get; set; }

    }
}
