
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CRC_POSICAO_ATRASO_TMP_BKP
    {
            [Required]
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public int VLR_INF121 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_121180 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_181365 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SUP365 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_TIPO_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_FIL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_001030 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_031060 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_061090 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_091120 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_121150 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_151180 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_181210 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_211240 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_241270 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_271300 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_301330 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_331360 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SUP360 { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_REFERENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_001014 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_015030 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_SUP120 { get; set; }

    }
}
