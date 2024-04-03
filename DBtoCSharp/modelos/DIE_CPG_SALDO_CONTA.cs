
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CPG_SALDO_CONTA
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CPG_SALDO_CONTA_ID { get; set; }
        
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
        /// Value da filial
        /// </summary>
        public string VALUE { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string REPROCESSAR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CREDITO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int DEBITO { get; set; }
        
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
        /// conta contabil
        /// </summary>
        public int CONTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_LANCAMENTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FILIAL_ID { get; set; }
            [StringLength(40)]
        /// <summary>
        /// contra partida
        /// </summary>
        public string NRCONTA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_INICIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DT_FIM { get; set; }

    }
}
