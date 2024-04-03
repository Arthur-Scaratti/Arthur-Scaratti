
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_POS_ATR_GR_PLANO
    {
            [Required]
    [Key]
        /// <summary>
        /// Id da posicao de atrasos do contas a receber - Mapao
        /// </summary>
        public int DIE_CRC_POS_ATR_GR_PLANO_ID { get; set; }
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
        
        /// <summary>
        /// Vlr. a vencer - dt_vecto >= sysdate + 30
        /// </summary>
        public int VL_AVENCER { get; set; }
        
        /// <summary>
        /// Vlr. Vincendo - dt_vecto > sysdate and dt_vecto < sysdate+30
        /// </summary>
        public int VL_VINCENDO { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 1    e 14 dias
        /// </summary>
        public int VL_0114 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 15 e 30 dias
        /// </summary>
        public int VL_1530 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 31 e 60 dias
        /// </summary>
        public int VL_3160 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 61 e 90 dias
        /// </summary>
        public int VL_6190 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 91 e 120 dias
        /// </summary>
        public int VL_91120 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos a mais de 120 dias
        /// </summary>
        public int VL_MAIS120 { get; set; }
        
        /// <summary>
        /// Vlr. da devolucao
        /// </summary>
        public int VL_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// Valor total (a vencer + vencendo + vl_0114 + vl_1530 + vl_3160 + vl_6190 + vl_91120 + vl_mais120)
        /// </summary>
        public int VL_TOTAL { get; set; }
        
        /// <summary>
        /// % a vencer - (vl_avencer / vl_total ) * 100
        /// </summary>
        public int PER_AVENCER { get; set; }
        
        /// <summary>
        /// % vincendo
        /// </summary>
        public int PER_VINCENDO { get; set; }
        
        /// <summary>
        /// % dos vencidos de 1 a 14 dias
        /// </summary>
        public int PER_0114 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 15 a 30 dias
        /// </summary>
        public int PER_1530 { get; set; }
        
        /// <summary>
        /// % dos vendidos de 31 a 60 dias
        /// </summary>
        public int PER_3160 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 61 a 90 dias
        /// </summary>
        public int PER_6190 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 91 a 120 dias
        /// </summary>
        public int PER_91120 { get; set; }
        
        /// <summary>
        /// % dos vencidos a mais de 120 dias
        /// </summary>
        public int PER_MAIS120 { get; set; }
        
        /// <summary>
        /// Vlr.total dos vencidos
        /// </summary>
        public int VL_TOT_VENCIDOS { get; set; }
        
        /// <summary>
        /// Mes e Ano do valor acumulado
        /// </summary>
        public string DT_REFERENCIA { get; set; }
        
        /// <summary>
        /// Id do tipo da filial
        /// </summary>
        public int BEG_GER_TIPO_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Codigo da filial
        /// </summary>
        public int COD_FIL { get; set; }
        
        /// <summary>
        /// Id do grupo
        /// </summary>
        public int DIE_PRD_GRUPO_ID { get; set; }
        
        /// <summary>
        /// plano de venda - qtde de parcelas geradas
        /// </summary>
        public int PLANO_VENDA { get; set; }
        
        /// <summary>
        /// Indice de rateio
        /// </summary>
        public int IND_RATEIO { get; set; }
        
        /// <summary>
        /// Vlr.dos vencidos entre 1  e 30 dias
        /// </summary>
        public int VL_0130 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 1 a 30 dias
        /// </summary>
        public int PER_0130 { get; set; }
            [StringLength(2)]
        /// <summary>
        /// Descricao resunida do gruopo do produto
        /// </summary>
        public string DESC_GRUPO { get; set; }

    }
}
