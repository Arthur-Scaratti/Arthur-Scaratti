
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_SALDO_CONTABIL
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_SALDO_CONTABIL_ID { get; set; }
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
            [StringLength(3)]
        /// <summary>
        /// Codigo da filial
        /// </summary>
        public string COD_FILIAL { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string ORDEM { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_ACESSO { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_TERCEIROS { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string COD_CCUSTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_SALDO_INI { get; set; }
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_DEB_CRE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_JAN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_FEV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_MAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_ABR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_MAI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_JUN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_JUL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_AGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_SET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_OUT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_NOV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_DEB_DEZ { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_JAN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_FEV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_MAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_ABR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_MAI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_JUN { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_JUL { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_AGO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_SET { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_OUT { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_NOV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_MOVTO_CRE_DEZ { get; set; }
        
        /// <summary>
        /// (C)liente / (F)ornecedor
        /// </summary>
        public string TP_DIARIO { get; set; }
        
        /// <summary>
        /// Saldo de qual ano
        /// </summary>
        public int ANO_SALDO { get; set; }

    }
}
