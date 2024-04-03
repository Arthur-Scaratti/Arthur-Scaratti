
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_POSICAO_ATRASO
    {
        
        /// <summary>
        /// % dos vencidos de 151 a 180 dias
        /// </summary>
        public int PER_151180 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 181a 210 dias
        /// </summary>
        public int PER_181210 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 211 a 240 dias
        /// </summary>
        public int PER_211240 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 241 a 270 dias
        /// </summary>
        public int PER_241270 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 271 a 300 dias
        /// </summary>
        public int PER_271300 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 301 a 330 dias
        /// </summary>
        public int PER_301330 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 331 a 360 dias
        /// </summary>
        public int PER_331360 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 361 a 1800 dias
        /// </summary>
        public int PER_3611800 { get; set; }
        
        /// <summary>
        /// % dos vencidos a mais de 1800 dias
        /// </summary>
        public int PER_MAIS1800 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_361720 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_7211080 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_10811440 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_14411800 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_18012160 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_21612520 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_25212880 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_28813240 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_32413600 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MAIS3601 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_361720 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_7211080 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_10811440 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_14411800 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_18012160 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_21612520 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_25212880 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_28813240 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_32413600 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_MAIS3601 { get; set; }
        
        /// <summary>
        /// Codigo da filial
        /// </summary>
        public int COD_FIL { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// Id da posicao de atrasos do contas a receber - Mapao
        /// </summary>
        public int BEG_CRC_POSICAO_ATRASO_ID { get; set; }
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
            [StringLength(10)]
        /// <summary>
        /// Codigo da filial
        /// </summary>
        public string COD_FILX { get; set; }
        
        /// <summary>
        /// Mes e Ano do valor acumulado
        /// </summary>
        public string DT_REFERENCIA { get; set; }
        
        /// <summary>
        /// Id do tipo da filial
        /// </summary>
        public int BEG_GER_TIPO_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 121 a 150 dias
        /// </summary>
        public int VL_121150 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 151 a 180 dias
        /// </summary>
        public int VL_151180 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 181 a 210 dias
        /// </summary>
        public int VL_181210 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 211 a 240 dias
        /// </summary>
        public int VL_211240 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 241 a 270 dias
        /// </summary>
        public int VL_241270 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 271 a 300 dias
        /// </summary>
        public int VL_271300 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 301 a 330dias
        /// </summary>
        public int VL_301330 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 331 a 360 dias
        /// </summary>
        public int VL_331360 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos entre 361 a 1800 dias
        /// </summary>
        public int VL_3611800 { get; set; }
        
        /// <summary>
        /// Vlr. dos vencidos a mais de 1800 dias
        /// </summary>
        public int VL_MAIS1800 { get; set; }
        
        /// <summary>
        /// % dos vencidos de 121 a 150 dias
        /// </summary>
        public int PER_121150 { get; set; }

    }
}
