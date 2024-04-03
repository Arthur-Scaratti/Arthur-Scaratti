
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_FECH_CAIXA_LJ_TMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PINSTANCE_ID { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string REMCONSERTO { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string RETCONSERTO { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string DEVOLVENDA { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string RECANTEC { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string RECCANC { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string NFSCANCELADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_FECH_CAIXALJ_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
        
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
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
            [StringLength(1000)]
        /// <summary>
        /// 
        /// </summary>
        public string NOTAS_FISCAIS { get; set; }
            [StringLength(3000)]
        /// <summary>
        /// 
        /// </summary>
        public string NRO_NOTAS { get; set; }

    }
}
