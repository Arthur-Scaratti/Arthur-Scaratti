
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_CPG_RESUMO_CONTA_TOT
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_CPG_RESUMO_CONTA_TOT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_ORG_ID { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string ISACTIVE { get; set; }
        
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
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string VALUE { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int VLR_ABERTO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESC_CONTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CONTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_RECEBIMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// 
        /// </summary>
        public string NRCONTA { get; set; }

    }
}
