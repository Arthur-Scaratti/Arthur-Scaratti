
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_CAIXA_DESPESA
    {
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_CAIXA_DESPESA_ID { get; set; }
        
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
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDO_REALIZADO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDO_PREVISTO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_ENTRADAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int TOTAL_SAIDAS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_CAIXA { get; set; }
            [StringLength(1)]
        /// <summary>
        /// 
        /// </summary>
        public string IND_GERA_INTEGRACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_SALDO_ID { get; set; }
            [StringLength(20)]
        /// <summary>
        /// 
        /// </summary>
        public string NRMEMO { get; set; }

    }
}
