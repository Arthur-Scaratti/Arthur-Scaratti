
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class BEG_EST_EXTRATO_TMP
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PESSOA_ID { get; set; }
            [StringLength(80)]
        /// <summary>
        /// 
        /// </summary>
        public string NOME { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_INI { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA_FIM { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int NRNF { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_MOVTO_ESTOQUE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_PINSTANCE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int COD_PROD { get; set; }
        
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
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int AD_SESSION_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_TP_ESPECIE_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRD_SKU_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_ALMOXARIFADO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ENTRADA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string SAIDA { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int QTD_MOVTO { get; set; }
            [Required]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_PRODUTO_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int SALDO { get; set; }
            [StringLength(100)]
        /// <summary>
        /// 
        /// </summary>
        public string DESCRICAO { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DATA { get; set; }
            [StringLength(150)]
        /// <summary>
        /// 
        /// </summary>
        public string DOCUMENTO { get; set; }
            [Required]
    [Key]
        /// <summary>
        /// 
        /// </summary>
        public int BEG_EST_EXTRATO_TMP_ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int AD_CLIENT_ID { get; set; }

    }
}
