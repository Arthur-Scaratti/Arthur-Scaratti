
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class DIE_FIN_CAIXA_MOVTO_TMP
    {
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int DIE_FIN_CAIXA_MOVTO_TMP_ID { get; set; }
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
        
        /// <summary>
        /// 
        /// </summary>
        public int NRO_CAIXA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_SALDO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_MOV { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_FIN_CAIXA_MOVIMENTO_ID { get; set; }
            [StringLength(30)]
        /// <summary>
        /// 
        /// </summary>
        public string USUARIO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NR_AUTENTICACAO { get; set; }
            [StringLength(1047)]
        /// <summary>
        /// 
        /// </summary>
        public string HISTORICO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SAIDA { get; set; }
            [StringLength(18)]
        /// <summary>
        /// 
        /// </summary>
        public string OPERACAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int ORDENADOR { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION_ID { get; set; }
            [StringLength(10)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCSTATUS { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PINSTANCE_ID { get; set; }

    }
}
