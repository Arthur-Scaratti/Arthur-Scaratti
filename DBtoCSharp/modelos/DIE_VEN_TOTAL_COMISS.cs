
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_VEN_TOTAL_COMISS
    {
        
        /// <summary>
        /// Código do Funcionário na Diementz
        /// </summary>
        public int CODIGO { get; set; }
        
        /// <summary>
        /// Código da Filial na Eza
        /// </summary>
        public int CD_FILIAL_CONTABIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PRECO_VENDIDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_PERC_COMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_REPOUSO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_AV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_AP { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VALOR_TF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string CBO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_VEN_TOTAL_COMISS_ID { get; set; }
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
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_GER_VENDEDOR_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_BASE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_BASE { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_REPOUSO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VLR_COMISSAO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_FECHAMES { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_PRD_GRUPO_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COMISSAO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_INICIAL { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DATA_FINAL { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string OBSERVACAO { get; set; }
            [Required]
        /// <summary>
        /// codigo do evento(comissao) na folha de pagamento
        /// </summary>
        public int DIE_FPG_EVENTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ELEGIVEIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QUANT_VENDIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ELEGIVEIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_POR_GARANTIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QUANT_CANC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_CANC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TM { get; set; }
        
        /// <summary>
        /// Código do registro na Contabilidade
        /// </summary>
        public int COD_EZA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FPG_PESSOA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }

    }
}
