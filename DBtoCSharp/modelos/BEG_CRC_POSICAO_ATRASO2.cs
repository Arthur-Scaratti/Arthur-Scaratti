
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CRC_POSICAO_ATRASO2
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
            [Required]
    [Key]
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
        public int VL_AVENCER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_VINCENDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_0114 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_1530 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_3160 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_6190 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_91120 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MAIS120 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_DEVOLUCAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOTAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_AVENCER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_VINCENDO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_0114 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_1530 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_3160 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_6190 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_91120 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PER_MAIS120 { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_FILX { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public string DT_REFERENCIA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_GER_TIPO_FILIAL_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_FIL { get; set; }

    }
}
