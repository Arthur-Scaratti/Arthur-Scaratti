
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CARGA_DIARIO_CLI_2022
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CARGA_DIARIO_CLI_ID { get; set; }
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
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string TP_DIARIO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public string DT_LANCAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_LANCAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int CONTRAPARTIDA { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int VL_LANCAMENTO { get; set; }
            [Required]
    [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DEB_CRE { get; set; }
            [Required]
    [StringLength(200)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CODFIL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string CODIGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int MES_LANCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ANO_LANCTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_LANCTO_CRE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_LANCTO_DEB { get; set; }
            [StringLength(3)]
        /// <summary>
        /// 
        /// </summary>
        public string CODFIL_LANCTO_ORIGINAL { get; set; }

    }
}
