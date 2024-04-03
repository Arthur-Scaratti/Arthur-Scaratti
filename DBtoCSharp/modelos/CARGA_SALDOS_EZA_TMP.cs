
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CARGA_SALDOS_EZA_TMP
    {
            [StringLength(5)]
        /// <summary>
        /// 
        /// </summary>
        public string TIPO { get; set; }
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

    }
}
