
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_PARAMETRO_SISTEMA_BKP
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PARAMETRO_SISTEMA_ID { get; set; }
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
    [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NAME { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_PARAMETRO { get; set; }
            [StringLength(60)]
        /// <summary>
        /// 
        /// </summary>
        public string CARACTER { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NUMERO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int PERCENTUAL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_MODULO_SISTEMA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_VW_SUBMODULO_SISTEMA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_TABLE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_COLUMN_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_USER_ID { get; set; }

    }
}
