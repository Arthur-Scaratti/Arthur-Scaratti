
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_POSICAO_ATRASO_TMP
    {
            [Required]
    [Key]
        /// <summary>
        /// Id da posicao atraso (tmp)
        /// </summary>
        public int DIE_CRC_POSICAO_ATRASO_TMP_ID { get; set; }
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
        /// Valor do atraso inferior a 121 dias
        /// </summary>
        public int VLR_INF121 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 121 a 180 dias
        /// </summary>
        public int VLR_121180 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 181 a 365 dias
        /// </summary>
        public int VLR_181365 { get; set; }
        
        /// <summary>
        /// Valor do atraso superior a 365 dias
        /// </summary>
        public int VLR_SUP365 { get; set; }
        
        /// <summary>
        /// codigo da filial
        /// </summary>
        public int COD_FIL { get; set; }
        
        /// <summary>
        /// Valor do atraso de 001 a 030 dias
        /// </summary>
        public int VLR_001030 { get; set; }
        
        /// <summary>
        /// Id do tipo da filial
        /// </summary>
        public int BEG_GER_TIPO_FILIAL_ID { get; set; }
        
        /// <summary>
        /// Valor do atraso de 031 a 060 dias
        /// </summary>
        public int VLR_031060 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 061 a 090 dias
        /// </summary>
        public int VLR_061090 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 091 a 120 dias
        /// </summary>
        public int VLR_091120 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 121 a 150 dias
        /// </summary>
        public int VLR_121150 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 151 a 180 dias
        /// </summary>
        public int VLR_151180 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 181 a 210 dias
        /// </summary>
        public int VLR_181210 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 211 a 240 dias
        /// </summary>
        public int VLR_211240 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 241 a 270 dias
        /// </summary>
        public int VLR_241270 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 271 a 300 dias
        /// </summary>
        public int VLR_271300 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 301 a 330 dias
        /// </summary>
        public int VLR_301330 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 331 a 360 dias
        /// </summary>
        public int VLR_331360 { get; set; }
        
        /// <summary>
        /// Valor do atraso sup 360
        /// </summary>
        public int VLR_SUP360 { get; set; }
            [Required]
        /// <summary>
        /// data de referencia
        /// </summary>
        public string DT_REFERENCIA { get; set; }
        
        /// <summary>
        /// Valor do atrsao de 1 a 14 dias
        /// </summary>
        public int VLR_001014 { get; set; }
        
        /// <summary>
        /// Valor do atraso de 15 a 30 dias
        /// </summary>
        public int VLR_015030 { get; set; }
        
        /// <summary>
        /// Valor superior a 120 dias
        /// </summary>
        public int VLR_SUP120 { get; set; }
        
        /// <summary>
        /// Valor de 361 a 1800 dias 
        /// </summary>
        public int VLR_3611800 { get; set; }
        
        /// <summary>
        /// Valor superior a 1800 dias
        /// </summary>
        public int VLR_SUP1800 { get; set; }

    }
}
