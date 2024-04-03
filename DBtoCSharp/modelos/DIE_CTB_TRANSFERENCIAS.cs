
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CTB_TRANSFERENCIAS
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CTB_TRANSF_ID { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_EMISSAO_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_NFS { get; set; }
            [StringLength(2)]
        /// <summary>
        /// 
        /// </summary>
        public string SERIE_NFS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int LC { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DESTINO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_BEG_DADO_ID { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string FILIAL { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string CANCELADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_TOTAL_NFS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_BASE_ICMS_SUBST { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_ICMS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VL_APROV_ICMS { get; set; }

    }
}
