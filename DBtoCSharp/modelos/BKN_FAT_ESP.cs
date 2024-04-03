
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BKN_FAT_ESP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int CST_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CST_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CST_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_PIS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_COFINS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_PIS_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIS_CST_COFINS_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_NF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VEN_TIPO_PEDIDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_TIPO_NF_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERC_ICMS_ST { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BKN_FAT_ESP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CREATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREATEDBY { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string UPDATED { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int UPDATEDBY { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CFOP_ID { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_CFOP { get; set; }
            [StringLength(300)]
        /// <summary>
        /// 
        /// </summary>
        public string HIST_PADR { get; set; }
            [StringLength(50)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_PRODUTO { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string VALOR_INF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_PARCELA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_VALOR { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_MES { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_NOTA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DATA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DESCRICAO { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string OBS { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_NF_DEV { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_FILIAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string FINALIDADE { get; set; }

    }
}
